using Foundation;
using System;
using UIKit;
using MacTraining.Shared;

namespace MacTraining.ViewControllers
{
    public partial class PlayerVc : UIViewController
    {
        public PlayerVc (IntPtr handle) : base (handle)
        {
        }

        partial void SettingsButtonClicked(UIButton sender)
        {
            AppDelegate.NavigationService.Navigate(PageNames.Settings);
        }
    }
}