using DMSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace DirectUI
{
  public  class DUILabel:DUIControl
    {
        public override void Print(Graphics g)
        {
            //设置高质量插值法
            g.InterpolationMode = InterpolationMode.Bilinear;
            //设置高质量,低速度呈现平滑程度
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            g.FillRectangle(new SolidBrush(BackColor),Rectangle);
            g.DrawString(Text, Font, new SolidBrush(ForeColor), Location);
        }
        public DUILabel() 
        {
            MouseMove += new EventHandler(ButtonMouseMove);
            MouseLeave += new EventHandler(ButtonMouseLeave);
            MouseClick += new EventHandler(ButtonMouseClick);
        }
        
      /// <summary>
      ///  鼠标点击
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void ButtonMouseClick(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Test");
        }

        //鼠标离开
        private void ButtonMouseLeave(object sender, EventArgs e)
        {
            

        }
        /// <summary>
        /// 鼠标悬浮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMouseMove(object sender, EventArgs e)
        {
            
        }
        
    }
}
