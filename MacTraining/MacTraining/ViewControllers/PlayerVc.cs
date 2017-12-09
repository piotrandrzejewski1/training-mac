using Foundation;
using System;
using UIKit;
using MacTraining.Shared;
using MacTraining.Helpers;
using GalaSoft.MvvmLight.Command;

namespace MacTraining.ViewControllers
{
    public partial class PlayerVc : UIViewController
    {
        public PlayerVc (IntPtr handle) : base (handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            NavigationController.NavigationBar.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
            NavigationController.NavigationBar.ShadowImage = new UIImage();
            NavigationController.NavigationBar.BackgroundColor = UIColor.Clear;
            NavigationController.NavigationItem.Title = "";
            NavigationController.SetNavigationBarHidden(false, false);

            base.ViewWillAppear(animated);
            SetStyles();
            SetLocale();

        }

        partial void SettingsButton_Clicked(UIButton sender)
        {
            AppDelegate.NavigationService.Navigate(PageNames.Settings);
        }

        void SetStyles()
        {
            View.BackgroundColor = ColorPalette.BaseGray;
            SettingsButton.StyleStandardButton();
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
        }

        void SetLocale()
        {
            SettingsButton.SetTitle("Set", UIControlState.Normal);
        }
    }
}