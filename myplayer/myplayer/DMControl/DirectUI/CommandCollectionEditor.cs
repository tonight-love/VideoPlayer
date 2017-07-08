using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace DirectUI
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
            return new Type[] { typeof(DUILabel) };
        }

        protected override object CreateInstance(Type itemType)
        {
            if (itemType == typeof(DUILabel))
            {
                return new DUILabel();
            }
            return null;
        }
    }
}
