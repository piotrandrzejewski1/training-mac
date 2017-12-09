// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MacTraining
{
    [Register ("IconAndTextCell")]
    partial class IconAndTextCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Header { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView LeftIcon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Subheader { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint SubheaderHeight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint SubheaderTopMargin { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Header != null) {
                Header.Dispose ();
                Header = null;
            }

            if (LeftIcon != null) {
                LeftIcon.Dispose ();
                LeftIcon = null;
            }

            if (Subheader != null) {
                Subheader.Dispose ();
                Subheader = null;
            }

            if (SubheaderHeight != null) {
                SubheaderHeight.Dispose ();
                SubheaderHeight = null;
            }

            if (SubheaderTopMargin != null) {
                SubheaderTopMargin.Dispose ();
                SubheaderTopMargin = null;
            }
        }
    }
}