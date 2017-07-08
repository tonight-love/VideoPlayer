using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace DMPlay
{
    public class CommandCollectionEditor : CollectionEditor
    {
        public CommandCollectionEditor(Type type)
            : base(type)
        { }
        protected override bool CanSelectMultipleInstances()
        {
            return true;
        }
        protected override Type[] CreateNewItemTypes()
        {
            return new Type[] { typeof(Item),typeof(DownItem),typeof(PluginItem)
            };
        }

        protected override object CreateInstance(Type itemType)
        {
            if (itemType == typeof(Item))
            {
                return (DMSkin.Controls.DMControlItem)(new Item());
            }

            if (itemType == typeof(DownItem))
            {
                return (DMSkin.Controls.DMControlItem)(new DownItem());
            }
            if (itemType == typeof(PluginItem))
            {
                return (DMSkin.Controls.DMControlItem)(new PluginItem());
            }
            return null;
        }
    }
}
