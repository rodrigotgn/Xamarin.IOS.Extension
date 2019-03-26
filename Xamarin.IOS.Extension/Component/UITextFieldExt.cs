using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Xamarin.IOS.Extension.Component
{
    public class UITextFieldExt : UITextField
    {
        public UITextFieldExt()
        {
            AddDoneButton();
        }

        public UITextFieldExt(UIView ViewParent)
        {
            ViewParent.Add(this);
            AddDoneButton();
        }

        public UITextFieldExt(UIViewController ViewParent)
        {
            ViewParent.Add(this);
            AddDoneButton();
        }


        public UITextFieldExt(CGRect frame) : base(frame)
        {
            AddDoneButton();
        }

        public UITextFieldExt(NSCoder coder) : base(coder)
        {
            AddDoneButton();
        }

        public UITextFieldExt(NSObjectFlag t) : base(t)
        {
            AddDoneButton();
        }

        public UITextFieldExt(IntPtr handler) : base(handler)
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
