using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Xamarin.IOS.Extension.Component
{
    public class UILabelExt : UILabel
    {
        public UILabelExt()
        {
        }

        public UILabelExt(UIView ViewParent)
        {
            ViewParent.Add(this);
        }

        public UILabelExt(UIViewController ViewParent)
        {
            ViewParent.Add(this);
        }


        public UILabelExt(NSCoder coder) : base(coder)
        {
        }

        public UILabelExt(CGRect frame) : base(frame)
        {
        }
    }
}
