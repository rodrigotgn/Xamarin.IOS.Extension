using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Xamarin.IOS.Extension.Component
{
    public class UIActivityIndicatorViewExt : UIActivityIndicatorView
    {
        public UIActivityIndicatorViewExt()
        {
        }

        public UIActivityIndicatorViewExt(UIView ViewParent)
        {
            ViewParent.Add(this);
        }

        public UIActivityIndicatorViewExt(UIViewController ViewParent)
        {
            ViewParent.Add(this);
        }

        public UIActivityIndicatorViewExt(NSCoder coder) : base(coder)
        {
        }

        public UIActivityIndicatorViewExt(CGRect frame) : base(frame)
        {
        }

        public UIActivityIndicatorViewExt(UIActivityIndicatorViewStyle style) : base(style)
        {
        }

        protected UIActivityIndicatorViewExt(NSObjectFlag t) : base(t)
        {
        }

        protected internal UIActivityIndicatorViewExt(IntPtr handle) : base(handle)
        {
        }
    }
}
