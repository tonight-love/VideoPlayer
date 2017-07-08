using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DMPlay
{
    public class PluginItem : DMSkin.Controls.DMControlItem
    {
        /// <summary>
        /// 插件名称
        /// </summary>
        public string Name { get; set; }

        public Icon Image { get; set; }

        /// <summary>
        /// 插件大小
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// 插件路径
        /// </summary>
        public string SavaPath { get; set; }

        /// <summary>
        /// 插件作者
        /// </summary>
        public string By { get; set; }

        public Font ByFont { get; set; }

        public string More { get; set; }

        public Color MouseBackColor { get; set; }

        public bool MouseHover { get; set; }

        public string VerSion { get; set; }

        public string DLLName { get; set; }
    }
}
