using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Xamarin.IOS.Extension.Component
{
    public class UIScrollViewExt : UIScrollView
    {
        private CGRect FrameWhenKeyBoardIsHidden;
        public bool AdjustSuperViewWhenChangingKeyboard = true;

        public UIScrollViewExt()
        {
            KeyBoardChange();
        }

        public UIScrollViewExt(UIView ViewParent)
        {
            ViewParent.Add(this);
            KeyBoardChange();
        }

        public UIScrollViewExt(UIViewController ViewParent)
        {
            ViewParent.Add(this);
            KeyBoardChange();
        }


        public UIScrollViewExt(NSCoder coder) : base(coder)
        {
            KeyBoardChange();
        }

        public UIScrollViewExt(CGRect frame) : base(frame)
        {
            KeyBoardChange();
        }

        private bool IsKeyBoardVisible = false;

        public void KeyBoardChange()
        {
            if (AdjustSuperViewWhenChangingKeyboard)
            {
                UIKeyboard.Notifications.ObserveDidShow((sender, e) =>
                {
                    if (AdjustSuperViewWhenChangingKeyboard && IsKeyBoardVisible == false)
                    {
                        FrameWhenKeyBoardIsHidden = this.Frame;

                        this.Height(this.Frame.Height - e.FrameEnd.Height);

                        IsKeyBoardVisible = true;
                    }
                });

                UIKeyboard.Notifications.ObserveWillHide((sender, e) =>
                {
                    if (AdjustSuperViewWhenChangingKeyboard && IsKeyBoardVisible == true)
                    {
                        this.Frame = FrameWhenKeyBoardIsHidden;
                        IsKeyBoardVisible = false;
                    }
                });
            }
        }
    }
}
