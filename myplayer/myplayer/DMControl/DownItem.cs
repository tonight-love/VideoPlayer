using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DMPlay
{
    public class DownItem : DMSkin.Controls.DMControlItem
    {
        public string Text { get; set; }

        public string Size { get; set; }

        public string SavaPathName { get; set; }

        public string SavaPath { get; set; }

        public string FileType { get; set; }

        private double _Progress;

        public double Progress
        {
            get { return _Progress; }
            set
            {
                if (value >= 100)
                {
                    _Progress = 100;
                }
                else if (value <= 0)
                {
                    _Progress = 0;
                }
                else
                {
                    _Progress = value; 
                }
            }
        }

        private Color _ProgressColor = Color.FromArgb(193,223,255);

        public Color ProgressColor
        {
            get { return _ProgressColor; }
            set { 
                _ProgressColor = value; 
            }
        }

        
    }
}
