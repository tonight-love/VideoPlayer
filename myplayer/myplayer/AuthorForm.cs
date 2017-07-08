using myplayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myplayer
{
    public partial class AuthorForm : DMSkin.Main
    {
        public AuthorForm()
        {
            InitializeComponent();
        }
        SolidBrush sb = new SolidBrush(Color.LightCoral);
        protected override void OnPaint(PaintEventArgs e)
        {
            //设置高质量插值法
            e.Graphics.InterpolationMode = InterpolationMode.Bilinear;
            //设置高质量,低速度呈现平滑程度
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.FillRectangle(sb, -1, -1, Width + 30, 30);

        }
        private void AuthorForm_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
