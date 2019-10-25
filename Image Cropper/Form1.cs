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
     * Eventually, should be able to set multiple "checkpoints" for the crop
     * i.e. grow and pan right until frame 300, then start shrinking and pan up until end (would need 3 definition points)
     * 
     * ToDo:
     *      -Factor in zoom when cropping images
     *      -Limit inputs so that entire frames can be cropped
     *      -Option to load settings from a file instead of manually setting everything up
     */
    public partial class Form1 : Form
    {
        private string mDirectory = null;
        private string[] mFiles = null;
        private ImageCropper mCropper = null;

        public List<VideoSize> mVideoSizes = null;

        private int mProgress;

        public Form1()
        {
            InitializeComponent();

            progressBar.Visible = false;

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

                PrepareVideoSizes();
                DrawImage(true);
                DrawImage(false);

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

            foreach (VideoSize size in mVideoSizes)
                VideoSize.Items.Add(size.Displayable);

            VideoSize.SelectedIndex = mVideoSizes.Count - 1;
        }

        public void DrawImage(bool drawOnStartImage)
        {
            PictureBox pictureBox = EndImage;
            string filename = mFiles[mFiles.Length - 1];
            int xOffset = (int)EndXOffset.Value;
            int yOffset = (int)EndYOffset.Value;
            double zoom = (double)EndZoom.Value;
            VideoSize vidSize = mVideoSizes[VideoSize.SelectedIndex];

            if (drawOnStartImage)
            {
                pictureBox = StartImage;
                filename = mFiles[0];
                xOffset = (int)StartXOffset.Value;
                yOffset = (int)StartYOffset.Value;
                zoom = (double)StartZoom.Value;
            }

            Image inputImage = Image.FromFile(filename);
            double inputRatio = (double)inputImage.Width / inputImage.Height;
            int outputHeight = (int)(pictureBox.Size.Width / inputRatio);
            double imageZoom = (double)inputImage.Width / pictureBox.Size.Width;

            if (drawOnStartImage)
            {
                InputStatus.Text = string.Format("{0} input files at {1}x{2}", mFiles.Length, inputImage.Width, inputImage.Height);
            }

            Bitmap bm = new Bitmap(inputImage, pictureBox.Size.Width, outputHeight);
            Graphics grap = Graphics.FromImage(bm);
            grap.InterpolationMode = InterpolationMode.HighQualityBicubic;
            
            Rectangle rect = new Rectangle((int)(xOffset/imageZoom), (int)(yOffset/imageZoom), (int)(vidSize.Width * zoom/imageZoom), (int)(vidSize.Height * zoom/imageZoom));
            grap.DrawRectangle(Pens.Red, rect);

            pictureBox.Image = bm;
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

            OutputStatus.Text = string.Format("{0} frames ({1}x real-time)     {2} --> {3}", numOutputs, speedupFactor, originalDuration, outputDuration);
        }

        private void StartInput_ValueChanged(object sender, EventArgs e)
        {
            DrawImage(true);
        }

        private void EndInput_ValueChanged(object sender, EventArgs e)
        {
            DrawImage(false);
        }

        private void VideoSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawImage(true);
            DrawImage(false);
            UpdateOutputStatus();
        }

        private void Output_ValueChanged(object sender, EventArgs e)
        {
            UpdateOutputStatus();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Visible = true;

            mCropper = new ImageCropper(mFiles, (int)ImageSkip.Value, mVideoSizes[VideoSize.SelectedIndex],
                                        (int)StartXOffset.Value, (int)EndXOffset.Value,
                                        (int)StartYOffset.Value, (int)EndYOffset.Value,
                                        (double)StartZoom.Value, (double)EndZoom.Value,
                                        mDirectory);

            mCropper.Event += new EventHandler<CropperEventArgs>(OnCropperEvent);
            mCropper.Start();
        }

        private void OnCropperEvent(object sender, CropperEventArgs args)
        {
            if (args.CurrentIndex == args.Total)
                mProgress = -1;
            else
                mProgress = (int)((double)args.CurrentIndex / (args.Total - 1) * 100);

            UpdateProgress();
        }

        public void UpdateProgress()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(UpdateProgress));
                return;
            }
    
            if(mProgress < 0)
                progressBar.Visible = false;
            else
                progressBar.Value = mProgress;
        }
    }

}
