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

        public static SettingsCell Create(bool isChecked, string header)
        {
            var cell = (SettingsCell)Nib.Instantiate(null, null)[0];

            if (isChecked)
                cell.IconView.Image = UIImage.FromBundle("Icons/confirmationTickIcon");
            else
                cell.IconView.Image = UIImage.FromBundle("Icons/updateScreenIllustration");

            cell.HeaderLabel.Text = header;
            return cell;
        }
    }
}
