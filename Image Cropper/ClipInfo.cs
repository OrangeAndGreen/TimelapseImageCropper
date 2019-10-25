using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Image_Cropper
{
    public class ClipInfo
    {
        public int Index { get; set; }
        public bool IsKeyFrame { get; set; }

        public VideoSize FrameSize { get; set; }
        public Point Offset { get; set; }
        public double Zoom { get; set; }

        public Image SavedImage { get; set; }
    }
}
