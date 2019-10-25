using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading.Tasks;

namespace Image_Cropper
{
    public class ImageCropper
    {
        private bool mAbort = false;
        private string[] mFiles = null;
        private string mLabel = null;
        private List<ClipInfo> mClipInfos = null;
        private int mRealtimeMultiplier = 0;

        private int mSkipRate;
        private VideoSize mVideoSize = null;
        private int mStartX;
        private int mEndX;
        private int mStartY;
        private int mEndY;
        private double mStartZoom;
        private double mEndZoom;
        private string mDirectory;

        public ImageCropper(string[] files, string label, List<ClipInfo> clipInfos, int skipRate, int realtimeMultiplier, string directory)
        {
            mFiles = files;
            mLabel = label;
            mClipInfos = clipInfos;
            mSkipRate = skipRate;
            mDirectory = directory;
            mRealtimeMultiplier = realtimeMultiplier;
        }

        public ImageCropper(string[] files, int skipRate, VideoSize size, int startX, int endX, int startY, int endY, double startZoom, double endZoom, string directory)
        {
            mFiles = files;
            mSkipRate = skipRate;
            mVideoSize = size;
            mStartX = startX;
            mEndX = endX;
            mStartY = startY;
            mEndY = endY;
            mStartZoom = startZoom;
            mEndZoom = endZoom;
            mDirectory = directory;
        }

        public void Start()
        {
            if (mWorkerThread == null)
            {
                mAbort = false;
                mWorkerThread = new Thread(DoCropping);
                mWorkerThread.Start();
            }
        }

        public void AbortAnalysis()
        {
            if (mWorkerThread != null)
            {
                mAbort = true;
                mWorkerThread.Join();
                mWorkerThread = null;
            }
        }

        private Thread mWorkerThread = null;

        public EventHandler<CropperEventArgs> Event = null;

        private void DoCropping()
        {
            string directory = string.Format("{0}\\Cropped {1}x", mDirectory, mRealtimeMultiplier);
            int appender = 0;
            while(Directory.Exists(directory))
            {
                appender++;
                directory = string.Format("{0}\\Cropped {1}x_{2}", mDirectory, mRealtimeMultiplier, appender);
            }
            Directory.CreateDirectory(directory);

            int numInputs = mFiles.Length;
            int numOutputs = numInputs / mSkipRate;
            //Parallel.For(0, numOutputs, (i) => {
            for (int i = 0; i < numOutputs; i++)
            {
                ClipInfo clipInfo = null;
                if (mClipInfos != null)
                {
                    clipInfo = mClipInfos[i * mSkipRate];
                }

                if (Event != null)
                    Event(this, new CropperEventArgs(i, numOutputs, null));

                int xOffset = clipInfo != null ? clipInfo.Offset.X : (int)(mStartX + ((mEndX - mStartX) * i / (numOutputs - 1)));
                int yOffset = clipInfo != null ? clipInfo.Offset.Y : (int)(mStartY + ((mEndY - mStartY) * i / (numOutputs - 1)));
                double zoom = clipInfo != null ? clipInfo.Zoom : (double)(mStartZoom + ((mEndZoom - mStartZoom) * i / (numOutputs - 1)));
                if (clipInfo != null)
                {
                    mVideoSize = clipInfo.FrameSize;
                }

                //Get the output filename
                string outName = string.Format("{0}\\{1}_{2}x_{3:00000}.png", directory, mLabel, mRealtimeMultiplier, i);

                Console.WriteLine(string.Format("Processing frame {0}, ({1}, {2}), output {3}", i, xOffset, yOffset, outName));

                //Crop the image
                using (Bitmap bmpImage = new Bitmap(mFiles[i * mSkipRate]))
                {
                    using (Bitmap bmpCrop = bmpImage.Clone(new Rectangle(xOffset, yOffset, (int)(mVideoSize.Width * zoom), (int)(mVideoSize.Height * zoom)), bmpImage.PixelFormat))
                    {
                        using (Bitmap bm = new Bitmap(bmpCrop, mVideoSize.Width, mVideoSize.Height))
                        {
                            Graphics grap = Graphics.FromImage(bm);
                            grap.InterpolationMode = InterpolationMode.HighQualityBicubic;

                            //Save the image
                            bm.Save(outName);
                            grap.Dispose();

                            if (Event != null)
                                Event(this, new CropperEventArgs(i, numOutputs, bm));
                        }
                    }
                }
            }
            //});

            if (Event != null)
                Event(this, new CropperEventArgs(numOutputs, numOutputs, null));
        }
    }

    public class CropperEventArgs : EventArgs
    {
        public int CurrentIndex = 0;
        public int Total = 0;
        public Image LastImage = null;

        public CropperEventArgs(int current, int total, Image lastImage)
        {
            CurrentIndex = current;
            Total = total;
            LastImage = lastImage;
        }
    }
}
