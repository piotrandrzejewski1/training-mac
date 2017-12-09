using System;
using System.Drawing;
using UIKit;

namespace MacTraining.Helpers
{
    public static class Stylization
    {
        public static void StyleStandardButton(this UIButton button)
        {
            button.ClipsToBounds = true;
			button.Layer.CornerRadius = 7;

            button.Layer.BorderColor = ColorPalette.DarkerGray.CGColor;
            button.Layer.BorderWidth = 4f;

            button.Layer.ShadowColor = UIColor.FromWhiteAlpha(0f, 0.5f).CGColor;
            button.Layer.ShadowRadius = 4;
            button.Layer.ShadowOpacity = 0.8f;

            button.SetBackgroundImage(ImageFromColor(ColorPalette.BaseGray), UIControlState.Normal);
            button.SetBackgroundImage(ImageFromColor(ColorPalette.DarkGray), UIControlState.Highlighted);

            button.SetTitleColor(ColorPalette.GrayText, UIControlState.Normal);
            button.SetTitleColor(ColorPalette.BaseGray, UIControlState.Highlighted);

            button.TitleLabel.Font = UIFont.SystemFontOfSize(13, UIFontWeight.Regular);

            button.ImageEdgeInsets = new UIEdgeInsets(0, 0, 0, 5);
        }

        public static UIImage ImageFromColor(UIColor color, RectangleF rect = default(RectangleF))
        {
            if (rect.Equals(default(RectangleF)))
                rect = new RectangleF(0, 0, 1, 1);

            UIGraphics.BeginImageContext(rect.Size);

            var ctx = UIGraphics.GetCurrentContext();
            ctx.SetFillColor(color.CGColor);
            ctx.FillRect(rect);

            var img = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();

            return img;
        }
    }

    public static class ColorPalette
    {
        public static UIColor Accent = UIColor.FromRGB((nfloat)(50.0 / 255.0), (nfloat)(214.0 / 255.0), (nfloat)(255.0 / 256.0));

        public static UIColor GrayMinorButton = UIColor.FromRGB((nfloat)(216.0 / 255.0), (nfloat)(216.0 / 255.0), (nfloat)(216.0 / 256.0));
        public static UIColor GrayMinorButtonPressed = UIColor.FromRGB((nfloat)(160.0 / 255.0), (nfloat)(160.0 / 255.0), (nfloat)(160.0 / 256.0));

        public static UIColor ViewBackground = UIColor.FromRGB((nfloat)(255.0 / 255.0), (nfloat)(255.0 / 255.0), (nfloat)(255.0 / 255.0));
        public static UIColor ErrorRed = UIColor.FromRGB((nfloat)(212.0 / 255.0), (nfloat)(32.0 / 255.0), (nfloat)(39.0 / 256.0));
        public static UIColor PositiveGreen = UIColor.FromRGB((nfloat)(46.0 / 255.0), (nfloat)(204.0 / 255.0), (nfloat)(113.0 / 256.0));

        public static UIColor White = UIColor.White;
        public static UIColor WhiteText = UIColor.FromWhiteAlpha(1f, 0.95f);
        public static UIColor BlackText = UIColor.FromWhiteAlpha(0f, 0.95f);
        public static UIColor GrayText = UIColor.FromWhiteAlpha(0.85f, 1);
        public static UIColor BaseGray = UIColor.FromWhiteAlpha(0.6f, 1);
        public static UIColor DarkGray = UIColor.FromWhiteAlpha(0.3f, 1);
        public static UIColor DarkerGray = UIColor.FromWhiteAlpha(0.18f, 1);

        public static UIColor Separator = UIColor.FromWhiteAlpha(0.93f, 1f);
        //public static UIColor GrayBackground = UIColor.FromWhiteAlpha(0.965f, 1f);
        public static UIColor GrayBackground = UIColor.FromWhiteAlpha(0.905f, 1f);
        public static UIColor HorizontalStatusGray = UIColor.FromWhiteAlpha(0.847f, 1f);

        public static UIColor Darker(this UIColor color, float multipler = 0.5f)
        {
            nfloat r;
            nfloat g;
            nfloat b;
            nfloat a;

            color.GetRGBA(out r, out g, out b, out a);
            return UIColor.FromRGBA(r * multipler, g * multipler, b * multipler, a);
        }
    }
}
