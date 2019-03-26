using System;
using CoreGraphics;
using UIKit;
using Xamarin.IOS.Extension.Component;

namespace Xamarin.IOS.Extension
{
    public class LoadingOverlay : UIView
    {
        private UIView ParentView;

        private UIActivityIndicatorView ActivityIndicator;

        public LoadingOverlay(UIViewController ParentView) : base(ParentView.View.Frame)
        {
            this.ParentView = ParentView.View;

            CarregarComponentes();
        }

        public LoadingOverlay(UIView ParentView) : base(ParentView.Frame)
        {
            this.ParentView = ParentView;

            CarregarComponentes();
        }

        public LoadingOverlay(UIView ParentView, CGRect Frame) : base(Frame)
        {
            this.ParentView = ParentView;

            CarregarComponentes();
        }

        private void CarregarComponentes()
        {
            // configurable bits
            BackgroundColor = UIColor.Black.ColorWithAlpha(0.8f);
            Alpha = 0;
            AutoresizingMask = UIViewAutoresizing.All;
            this.ClipsToBounds = true;

            if (ActivityIndicator == null)
            {
                ActivityIndicator = new UIActivityIndicatorViewExt(this);
                ActivityIndicator.SizeToFit();
                ActivityIndicator.CenterInParent();
                ActivityIndicator.StartAnimating();
            }

            ActivityIndicator.ActivityIndicatorViewStyle = UIActivityIndicatorViewStyle.White;
        }

        /// <summary>
        /// Show in the control and then add it from the super view
        /// </summary>
        public void Show()
        {
            if (this.Superview == null)
            {
                ParentView.Add(this);
            }

            //this.Hidden = false;
            Animate(0.75f, () => this.Alpha = 1);
        }

        /// <summary>
        /// Fades out the control and then removes it from the super view
        /// </summary>
        public void Hide()
        {
            InvokeOnMainThread(() =>
            {
                Animate(0.5, () => { Alpha = 0; }, () => { RemoveFromSuperview(); });
            });
        }
    }
}
