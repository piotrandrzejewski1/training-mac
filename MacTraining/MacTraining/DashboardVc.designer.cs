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
    [Register ("DashboardVc")]
    partial class DashboardVc
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView GreyView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ProductsListButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (GreyView != null) {
                GreyView.Dispose ();
                GreyView = null;
            }

            if (ProductsListButton != null) {
                ProductsListButton.Dispose ();
                ProductsListButton = null;
            }
        }
    }
}