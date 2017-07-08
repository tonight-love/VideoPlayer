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
using DMSkin.Controls;

namespace myplayer
{
    public partial class SettingForm : DMSkin.Main
    {
        public SettingForm()
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
            //文字抗锯齿
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.FillRectangle(sb, -1, -1, Width + 30, 30);
            this.dmTextBox1.Focus();
            this.dmTextBox1.SelectionLength = 0;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void SettingForm_Load(object sender, EventArgs e)
        {
            this.dmTextBox1.Text = Settings.Default.picDir;
        }


        private void lb_choose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.dmTextBox1.Text = dialog.SelectedPath;
                Settings.Default.picDir = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// 按钮或标签停留效果
        /// </summary>
        private void btns_MouseEnter(object sender, EventArgs e)
        {
            DMLabel label = (DMLabel)sender;
            label.DM_Color = Color.LightPink;
        }

        /// <summary>
        /// 按钮或标签停留后移开的效果
        /// </summary>
        private void btns_MouseLeave(object sender, EventArgs e)
        {
            DMLabel label = (DMLabel)sender;
            label.DM_Color = Color.White;
        }
    
    }
}
