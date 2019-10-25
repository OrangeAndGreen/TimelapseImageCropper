using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Image_Cropper
{
    public class VideoSize
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Label { get; set; }

        public VideoSize(int width, int height, string label)
        {
            Width = width;
            Height = height;
            Label = label;
        }

        public string Displayable
        {
            get
            {
                return string.Format("{0}x{1} ({2})", Width, Height, Label);
            }
        }
    }
}
