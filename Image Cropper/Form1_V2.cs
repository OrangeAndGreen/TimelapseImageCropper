using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Image_Cropper
{
    /*
     * 
     * Prompt for image folder at startup
     * 
     * Inputs:
     *      Image Interval (s)
     *      Take Every nth image
     *      Video Frame Rate
     *      Video Frame Size
     * 
     * ToDo:
     *      -Batch files: load settings from a file instead of manually setting everything up
	 *      -Dashed frame outline on image
	 *      -Find a cooler way to combine frames
     */
    public partial class Form1_V2 : Form
    {
        private string mDirectory = null;
        private string[] mFiles = null;
        private ImageCropper mCropper = null;

        public List<VideoSize> mVideoSizes = null;

        private List<ClipInfo> mKeyFrameInfo = null;
        private List<ClipInfo> mAllFrameInfo = null;

        private int mSelectedIndex;
        private bool mIgnoreChangeEvent = false;

        private int mCurrentFile;
        private int mTotalFiles;
        private Image mLastImage = null;

        private DateTime mStartTime;

        public Form1_V2()
        {
            InitializeComponent();

            progressBar.Visible = false;
            statusLabel.Text = "";
            mKeyFrameInfo = new List<ClipInfo>();

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select PDF directory";
            DialogResult result = dialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                mDirectory = dialog.SelectedPath;
                mFiles = Directory.GetFiles(mDirectory);

                if (mFiles.Length < 2)
                {
                    MessageBox.Show("Not enough images", "Not enough images", MessageBoxButtons.OK);
                    Close();
                }

                Image firstImage = Image.FromFile(mFiles[0]);
                inputsLabel.Text = string.Format("Inputs:\n{0} files\n{1} x {2}", mFiles.Length, firstImage.Width, firstImage.Height);

                frameSlider.Maximum = mFiles.Length - 1;
                frameIndex.Maximum = mFiles.Length - 1;

                PrepareVideoSizes();

                mSelectedIndex = 0;
                UpdateClipInfo();
                UpdateOutputStatus();
            }
            else
            {
                Close();
            }
        }

        public void PrepareVideoSizes()
        {
            mVideoSizes = new List<VideoSize>();
            mVideoSizes.Add(new VideoSize(864, 480, "480p"));
            mVideoSizes.Add(new VideoSize(1024, 576, "576p"));
            mVideoSizes.Add(new VideoSize(1280, 720, "720p"));
            mVideoSizes.Add(new VideoSize(1920, 1080, "1080p"));
            mVideoSizes.Add(new VideoSize(0, 0, "Custom"));

            foreach (VideoSize size in mVideoSizes)
                VideoSize.Items.Add(size.Displayable);

            mIgnoreChangeEvent = true;
            VideoSize.SelectedIndex = mVideoSizes.Count - 2;
            mIgnoreChangeEvent = false;
        }

        public void UpdateClipInfo()
        {
            mAllFrameInfo = new List<ClipInfo>();

            for (int i = 0; i < mFiles.Length; i++)
            {
                ClipInfo info = null;

                foreach (ClipInfo searchClip in mKeyFrameInfo)
                {
                    if (i == searchClip.Index)
                    {
                        info = searchClip;
                    }
                }

                if (info == null)
                {
                    info = new ClipInfo();
                    info.Index = i;
                    info.IsKeyFrame = false;
                    info.Zoom = 1;
                    info.FrameSize = mVideoSizes[VideoSize.SelectedIndex];

                    bool custom = info.FrameSize.Label == "Custom";
                    widthInput.Visible = custom;
                    widthLabel.Visible = custom;
                    heightInput.Visible = custom;
                    heightLabel.Visible = custom;
                    if (custom)
                    {
                        info.FrameSize.Height = (int)heightInput.Value;
                        info.FrameSize.Width = (int)widthInput.Value;
                    }

                    //Interpolate to find the clip info for this frame
                    ClipInfo beforeInfo = null;
                    ClipInfo afterInfo = null;
                    foreach (ClipInfo searchInfo in mKeyFrameInfo)
                    {
                        if (searchInfo.Index < info.Index)
                        {
                            beforeInfo = searchInfo;
                        }

                        if (searchInfo.Index > info.Index && afterInfo == null)
                        {
                            afterInfo = searchInfo;
                        }
                    }

                    if (beforeInfo == null)
                    {
                        if (afterInfo == null)
                        {
                            //No before, no after
                        }
                        else
                        {
                            //No before, after
                            info.Offset = new Point(afterInfo.Offset.X, afterInfo.Offset.Y);
                            info.Zoom = afterInfo.Zoom;
                        }
                    }
                    else
                    {
                        if (afterInfo == null)
                        {
                            //Before, no after
                            info.Offset = new Point(beforeInfo.Offset.X, beforeInfo.Offset.Y);
                            info.Zoom = beforeInfo.Zoom;
                        }
                        else
                        {
                            //Before, after
                            double ratio = (double)(info.Index - beforeInfo.Index) / (afterInfo.Index - beforeInfo.Index);
                            info.Offset = new Point((int)(ratio * (afterInfo.Offset.X - beforeInfo.Offset.X) + beforeInfo.Offset.X),
                                                    (int)(ratio * (afterInfo.Offset.Y - beforeInfo.Offset.Y) + beforeInfo.Offset.Y));
                            info.Zoom = ratio * (afterInfo.Zoom - beforeInfo.Zoom) + beforeInfo.Zoom;
                        }
                    }
                }

                mAllFrameInfo.Add(info);
            }

            //Update the listbox
            keyFramesListBox.Items.Clear();
            foreach (ClipInfo clipInfo in mKeyFrameInfo)
            {
                keyFramesListBox.Items.Add(string.Format("{0}: ({1},{2})  {3}", clipInfo.Index, clipInfo.Offset.X, clipInfo.Offset.Y, clipInfo.Zoom));
            }

            DrawImage(mSelectedIndex);
        }

        public void DrawImage(int imageIndex)
        {
            mSelectedIndex = imageIndex;
            frameIndex.Value = imageIndex;
            frameSlider.Value = imageIndex;

            ClipInfo clipInfo = mAllFrameInfo[imageIndex];

            mIgnoreChangeEvent = true;
            StartXOffset.Value = clipInfo.Offset.X;
            StartYOffset.Value = clipInfo.Offset.Y;
            StartZoom.Value = (decimal)clipInfo.Zoom;
            mIgnoreChangeEvent = false;

            if (clipInfo.IsKeyFrame)
            {
                keyButton.Text = "Clear Key";

                StartXOffset.Enabled = true;
                StartYOffset.Enabled = true;
                StartZoom.Enabled = true;
            }
            else
            {
                keyButton.Text = "Make Key";

                StartXOffset.Enabled = false;
                StartYOffset.Enabled = false;
                StartZoom.Enabled = false;
            }

            string filename = mFiles[imageIndex];

            //if (clipInfo.SavedImage == null)
            //{
            //    clipInfo.SavedImage = Image.FromFile(filename);
            //}
            Image image = Image.FromFile(filename);
            double inputRatio = (double)image.Width / image.Height;
            int outputHeight = (int)(imageDisplay.Size.Width / inputRatio);
            double imageZoom = (double)image.Width / imageDisplay.Size.Width;

            Bitmap bitmap = new Bitmap(image, imageDisplay.Size.Width, outputHeight);
            Graphics grap = Graphics.FromImage(bitmap);
            grap.InterpolationMode = InterpolationMode.HighQualityBicubic;

            Rectangle rect = new Rectangle(
                (int)(clipInfo.Offset.X / imageZoom),
                (int)(clipInfo.Offset.Y / imageZoom),
                (int)(clipInfo.FrameSize.Width * clipInfo.Zoom / imageZoom),
                (int)(clipInfo.FrameSize.Height * clipInfo.Zoom / imageZoom));

            Pen pen = clipInfo.IsKeyFrame ? Pens.Cyan : Pens.DarkGreen;

            grap.DrawRectangle(pen, rect);
            grap.Dispose();

            image.Dispose();

            imageDisplay.Image = bitmap;
        }

        public void UpdateOutputStatus()
        {
            int numInputs = mFiles.Length;
            int skipRate = (int)ImageSkip.Value;
            int numOutputs = numInputs / skipRate;

            double imageInterval = (double)ImageInterval.Value;
            double frameRate = (double)VideoFrameRate.Value;
            double speedupFactor = imageInterval * frameRate * skipRate;

            TimeSpan originalDuration = new TimeSpan(0, 0, (int)(numInputs * imageInterval));
            TimeSpan outputDuration = new TimeSpan(0, 0, (int)(numInputs * imageInterval / speedupFactor));

            VideoSize vidSize = mVideoSizes[VideoSize.SelectedIndex];
            outputsLabel.Text = string.Format("Outputs:\n{0} frames\n{1} x {2}", numOutputs, vidSize.Width, vidSize.Height);

            calculatorLabel.Text = string.Format("Timing:\nOrig: {0}\nOut: {1}\nSpeedup: {2}x", originalDuration, outputDuration, speedupFactor);
        }

        private void StartInput_ValueChanged(object sender, EventArgs e)
        {
            if (!mIgnoreChangeEvent)
            {
                ClipInfo info = mAllFrameInfo[mSelectedIndex];

                info.Offset = new Point((int)StartXOffset.Value, (int)StartYOffset.Value);
                info.Zoom = (double)StartZoom.Value;

                UpdateClipInfo();
            }
        }

        private void VideoSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!mIgnoreChangeEvent)
            {
                ClipInfo info = mAllFrameInfo[mSelectedIndex];
                info.FrameSize = mVideoSizes[VideoSize.SelectedIndex];

                if (info.FrameSize.Label.Equals("Custom") && info.FrameSize.Width == 0 && info.FrameSize.Height == 0)
                {
                    Image firstImage = Image.FromFile(mFiles[0]);
                    widthInput.Value = firstImage.Width;
                    heightInput.Value = firstImage.Height;
                }
            }

            UpdateClipInfo();
            UpdateOutputStatus();
        }

        private void Output_ValueChanged(object sender, EventArgs e)
        {
            UpdateClipInfo();
            UpdateOutputStatus();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Visible = true;

            double imageInterval = (double)ImageInterval.Value;
            double frameRate = (double)VideoFrameRate.Value;
            int skipRate = (int)ImageSkip.Value;
            double speedupFactor = imageInterval * frameRate * skipRate;

            string[] directoryComponents = mDirectory.Split('\\');
            string label = directoryComponents[directoryComponents.Length-1];
            mCropper = new ImageCropper(mFiles, label, mAllFrameInfo, (int)ImageSkip.Value, (int)speedupFactor, mDirectory);

            mCropper.Event += new EventHandler<CropperEventArgs>(OnCropperEvent);

            mStartTime = DateTime.Now;
            mCropper.Start();
        }

        private void OnCropperEvent(object sender, CropperEventArgs args)
        {
            mCurrentFile = args.CurrentIndex;
            mTotalFiles = args.Total;
            mLastImage = args.LastImage;

            UpdateProgress();
        }

        public void UpdateProgress()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(UpdateProgress));
                return;
            }

            string status = null;
            if (mCurrentFile == mTotalFiles)
            {
                progressBar.Visible = false;

                status = string.Format("Finished processing {0} files", mTotalFiles);
            }
            else
            {
                int progress = (int)((double)mCurrentFile / (mTotalFiles - 1) * 100);
                progressBar.Visible = true;
                progressBar.Value = progress;

                TimeSpan diff = DateTime.Now.Subtract(mStartTime);
                double processRate = mCurrentFile / diff.TotalSeconds;
                double estimatedRemaining = (mTotalFiles - mCurrentFile) / processRate;

                status = string.Format("Processing file {0} of {1} (estimated {2}s remaining)", mCurrentFile + 1, mTotalFiles, (int)estimatedRemaining);

                DrawImage(mCurrentFile * (int)ImageSkip.Value);
            }

            statusLabel.Text = status;
        }

        private void keyButton_Click(object sender, EventArgs e)
        {
            ClipInfo clipInfo = mAllFrameInfo[mSelectedIndex];

            if (clipInfo.IsKeyFrame)
            {
                clipInfo.IsKeyFrame = false;
                for(int i=0; i<mKeyFrameInfo.Count; i++)
                {
                    ClipInfo searchClip = mKeyFrameInfo[i];
                    if (searchClip.Index == mSelectedIndex)
                    {
                        mKeyFrameInfo.RemoveAt(i);
                        UpdateClipInfo();
                        return;
                    }
                }
            }
            else
            {
                clipInfo.IsKeyFrame = true;
                clipInfo.Offset = new Point((int)StartXOffset.Value, (int)StartYOffset.Value);
                clipInfo.Zoom = (double)StartZoom.Value;
                for (int i = 0; i < mKeyFrameInfo.Count; i++)
                {
                    if (mKeyFrameInfo[i].Index > clipInfo.Index)
                    {
                        mKeyFrameInfo.Insert(i, clipInfo);
                        UpdateClipInfo();
                        return;
                    }
                }

                mKeyFrameInfo.Add(clipInfo);
                UpdateClipInfo();
                return;
            }
        }

        private void frameIndex_ValueChanged(object sender, EventArgs e)
        {
            DrawImage((int)frameIndex.Value);
        }

        private void frameSlider_Scroll(object sender, EventArgs e)
        {
            DrawImage(frameSlider.Value);
        }

        private void keyFramesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = 0;
            string indexString = ((string)keyFramesListBox.SelectedItem).Split(':')[0];
            int.TryParse(indexString, out index);
            DrawImage(index);
        }

        private void widthInput_ValueChanged(object sender, EventArgs e)
        {
            UpdateClipInfo();
            UpdateOutputStatus();
        }

        private void heightInput_ValueChanged(object sender, EventArgs e)
        {
            UpdateClipInfo();
            UpdateOutputStatus();
        }
    }

}
