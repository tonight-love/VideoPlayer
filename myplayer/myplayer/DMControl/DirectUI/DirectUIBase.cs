using DMSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DirectUI
{
    public partial class DirectUIBase : DMSkin.DUIMain
    {
        public DirectUIBase()
        {
            InitializeComponent();
        }

        private void DirectBase_Load(object sender, EventArgs e)
        {

        }
        [Editor(typeof(DirectUI.CommandCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public override DUIList DUIControls
        {
            get
            {
                if (_DUIControls == null)
                {
                    _DUIControls = new DUIList();
                }
                return _DUIControls;
            }
        }
    }
}
