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

namespace MacTraining.ViewControllers
{
    [Register ("PlayerVc")]
    partial class PlayerVc
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SettingsButton { get; set; }

        [Action ("SettingsButton_Clicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SettingsButton_Clicked (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (SettingsButton != null) {
                SettingsButton.Dispose ();
                SettingsButton = null;
            }
        }
    }
}