using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DMPlay
{
    public class Item : DMSkin.Controls.DMControlItem
    {
        public Image Image { get; set; }
        public bool OnLine { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }
        public Color MouseBackColor { get; set; }

    }
}
