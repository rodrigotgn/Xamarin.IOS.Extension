using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Xamarin.IOS.Extension.Component
{
    public class UIViewExt : UIView
    {
        public UIViewExt()
        {
        }

        public UIViewExt(UIView ViewParent)
        {
            ViewParent.Add(this);
        }

        public UIViewExt(UIViewController ViewParent)
        {
            ViewParent.Add(this);
        }

        public UIViewExt(CGRect frame) : base(frame)
        {
        }

        public UIViewExt(NSCoder coder) : base(coder)
        {
        }

        public UIViewExt(NSObjectFlag t) : base(t)
        {
        }

        public UIViewExt(IntPtr handler) : base(handler)
        {
        }
    }
}
