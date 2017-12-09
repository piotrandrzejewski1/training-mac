using System;

using Foundation;
using UIKit;

namespace MacTraining.Cells
{
    public partial class SettingsCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("SettingsCell");
        public static readonly UINib Nib;

        static SettingsCell()
        {
            Nib = UINib.FromName("SettingsCell", NSBundle.MainBundle);
        }

        protected SettingsCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
