using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Xamarin.IOS.Extension.Component
{
    public class UITextViewExt : UITextView
    {
        public UITextViewExt()
        {
            AddDoneButton();
        }

        public UITextViewExt(UIView ViewParent)
        {
            ViewParent.Add(this);
            AddDoneButton();
        }

        public UITextViewExt(UIViewController ViewParent)
        {
            ViewParent.Add(this);
            AddDoneButton();
        }


        public UITextViewExt(CGRect frame) : base(frame)
        {
            AddDoneButton();
        }

        public UITextViewExt(CGRect frame, NSTextContainer textContainer) : base(frame, textContainer)
        {
            AddDoneButton();
        }

        public UITextViewExt(NSCoder coder) : base(coder)
        {
            AddDoneButton();
        }

        public UITextViewExt(NSObjectFlag t) : base(t)
        {
            AddDoneButton();
        }

        public UITextViewExt(IntPtr handler) : base(handler)
        {
            AddDoneButton();
        }

        public void AddDoneButton()
        {
            var keyboardToolbar = new UIToolbar();
            keyboardToolbar.SizeToFit();

            UIBarButtonItem flexBarButton = new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace, null);
            UIBarButtonItem doneBarButton = new UIBarButtonItem(UIBarButtonSystemItem.Done, (sender, e) => { this.EndEditing(true); });

            keyboardToolbar.SetItems(new[] { flexBarButton, doneBarButton }, true);

            this.InputAccessoryView = keyboardToolbar;
        }
    }
}
