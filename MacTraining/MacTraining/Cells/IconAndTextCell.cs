using Foundation;
using System;
using UIKit;

namespace MacTraining
{
    public partial class IconAndTextCell : UITableViewCell
    {
        public IconAndTextCell (IntPtr handle) : base (handle)
        {

        }

        public void Setup(string header, string subheader)
        {
            Header.Text = header;
			Subheader.Text = subheader;

            if (string.IsNullOrEmpty(subheader))
            {
                SubheaderHeight.Constant = 0;
                SubheaderTopMargin.Constant = 0;
            }
        }

        public UIImageView Icon => LeftIcon;
    }
}