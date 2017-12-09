using Foundation;
using System;
using UIKit;
using MacTraining.Helpers;
using GalaSoft.MvvmLight.Command;

namespace MacTraining.ViewControllers
{
    public partial class MainVc : UITabBarController
    {
        public MainVc (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            AppDelegate.NavigationService.SetNavigationController(NavigationController);
            TabBar.BackgroundImage = Stylization.ImageFromColor(ColorPalette.BaseGray);
        }
    }
}