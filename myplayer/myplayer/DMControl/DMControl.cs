using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace DMPlay
{
    [ToolboxItem(true)]
    public partial class DMControl : DMSkin.Controls.DMControl
    {
        public DMControl()
        {
            InitializeComponent();
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.Selectable |
                ControlStyles.DoubleBuffer |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.Opaque, false);
            base.BackColor = Color.Transparent;
            this.UpdateStyles();
            if (items==null)
            {
                items = new DMControlItemCollection(this);
            }
        }
        [Editor(typeof(CommandCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public override DMSkin.Controls.DMControl.DMControlItemCollection Items
        {
            get
            {
                if (items == null)
                    items = new DMControlItemCollection(this);
                return items;
            }
        }
        public event EventHandler ItemClick;

        public event EventHandler rightItemClick;

        protected override void DrawItem(Graphics g, DMSkin.Controls.DMControlItem _item, Rectangle rectItem)
        {
            if (Items!=null&&Items.Count <= 0)
            {
                return;
            }
            g.InterpolationMode = InterpolationMode.Bilinear;
            g.SmoothingMode = SmoothingMode.HighQuality;
           // g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            ///////////////////////设置样式
            int padding = 5;
            int left = 5;
            Color itemBgColor = Color.FromArgb(235, 235,235); //每一条默认的背景色
            Color mouseBackColor = Color.FromArgb(210,210,210);  //鼠标移入背景色
            Color lineColor = Color.FromArgb(230,230,230);
            Color itemForeColor = Color.FromArgb(120, 120, 120);
            Color playingColor = Color.FromArgb(32, 191, 99); //字体颜色
            Font font= new Font("微软雅黑", 10);
            /// 列表 
            if (_item is Item)
            {
                Item it = (Item)_item;
                if (m_mouseOnItem!=null&&m_mouseOnItem.Equals(it)&&it.MouseBackColor!=null)
                {
                    g.FillRectangle(new SolidBrush(mouseBackColor),new Rectangle(it.Bounds.Location,new Size(Width,it.Bounds.Height)));
                    if (it.OnLine)
                    {
                        g.DrawString(it.Text + "(" + it.Url + ")", font, new SolidBrush(playingColor), left, it.Bounds.Y + padding);
                    }
                    else
                    {
                        g.DrawString(it.Text, font, new SolidBrush(itemForeColor), left, it.Bounds.Y + padding);
                    }
                }
                else
                {
                    g.FillRectangle(new SolidBrush(itemBgColor), new Rectangle(it.Bounds.Location, new Size(Width, it.Bounds.Height)));
                    if (it.OnLine)
                    {
                        g.DrawString(it.Text + "(" + it.Url + ")", font, new SolidBrush(playingColor), left, it.Bounds.Y + padding);
                    }
                    else
                    {
                        g.DrawString(it.Text, font, new SolidBrush(itemForeColor), left, it.Bounds.Y + padding);
                    }
                }
                g.DrawLine(new Pen(lineColor), it.Bounds.X+2, it.Bounds.Y,Width, it.Bounds.Y);
                g.DrawLine(new Pen(lineColor), it.Bounds.X+2, it.Bounds.Y + it.Bounds.Height,Width, it.Bounds.Y + it.Bounds.Height);
            }

            else
            {
                base.DrawItem(g,_item,rectItem);
            }
        }
       
        protected override void OnMouseMove(MouseEventArgs e)
        {
            foreach (var item in Items)
            {
                //if (item is MvItem)
                //{
                //    MvItem it = (MvItem)item;
                //    it.MouseHover = false;
                //    if (it.Bounds.Contains(m_ptMousePos))
                //    {
                //        if (new Rectangle(it.Bounds.X +it.Bounds.Width-27, it.Bounds.Y + 132,25,25).Contains(m_ptMousePos))//播放按钮区域
                //        {
                //            it.MouseHover = true;
                //            it.IsPlayHover = true;
                //            this.Invalidate();
                //        }
                //        else
                //        {
                //            it.MouseHover = true;
                //            this.Invalidate();
                //        }
                //    }
                //}
                if (item is PluginItem)
                {
                    PluginItem it = (PluginItem)item;
                    if (it.Bounds.Contains(m_ptMousePos))
                    {
                        if (new Rectangle(it.Bounds.X + Width - 80, it.Bounds.Y + 30, 45, 28).Contains(m_ptMousePos))//播放按钮区域
                        {
                                it.MouseHover = true;
                                this.Invalidate();
                            }
                            else
                            {
                                it.MouseHover = false;
                                this.Invalidate();
                            }
                    }
                }
            }
            base.OnMouseMove(e);
        }
        protected override void OnDoubleClick(EventArgs e)
        {
            foreach (var item in Items)
            {
                if (item is Item)
                {
                    Item it = (Item)item;
                    if (it.Bounds.Contains(m_ptMousePos))
                    {
                        if (ItemClick != null)
                        {
                            ItemClick(it, e);
                        }
                        break;
                    }
                }
                if (item is PluginItem)
                {
                    PluginItem it = (PluginItem)item;
                    if (it.Bounds.Contains(m_ptMousePos))
                    {
                        if (ItemClick != null)
                        {
                            ItemClick(it, e);
                        }
                        break;
                    }
                }
            }
            base.OnDoubleClick(e);
        }

        protected override void OnClick(EventArgs e)
        {
            foreach (var item in Items)
            {
                if (item is Item)
                {
                    Item it = (Item)item;
                    if (it.Bounds.Contains(m_ptMousePos))
                    {
                        if (rightItemClick != null)
                        {
                            rightItemClick(it, e);
                        }
                        break;
                    }
                }
            }  
            base.OnClick(e);
        }
    }
}
