using System;
using Foundation;
using UIKit;

namespace Xamarin.IOS.Extension.Component
{
    public class UICheckedButtonExt : UIButton
    {
        private bool _Checked = false;

        public Boolean Checked
        {
            get
            {
                return _Checked;
            }
            set
            {
                _Checked = value;
            }

        }

        public String ValueIdentification { get; set; } = "";

        public UICheckedButtonExt()
        {
            TouchUpInside += OnCheckedChange;
        }

        public UICheckedButtonExt(UIView ViewParent)
        {
            ViewParent.Add(this);
            TouchUpInside += OnCheckedChange;
        }

        public UICheckedButtonExt(UIViewController ViewParent)
        {
            ViewParent.Add(this);
            TouchUpInside += OnCheckedChange;
        }

        public UICheckedButtonExt(UIButtonType type) : base(type)
        {
            TouchUpInside += OnCheckedChange;
        }

        public UICheckedButtonExt(NSCoder coder) : base(coder)
        {
            TouchUpInside += OnCheckedChange;
        }

        public UICheckedButtonExt(NSObjectFlag t) : base(t)
        {
            TouchUpInside += OnCheckedChange;
        }

        public UICheckedButtonExt(IntPtr handler) : base(handler)
        {
            TouchUpInside += OnCheckedChange;
        }

        private void OnCheckedChange(object sender, EventArgs e)
        {
            _Checked = !_Checked;

            if (CheckedChange != null)
            {
                CheckedChange.Invoke(this, e);
            }
        }

        public event EventHandler CheckedChange;
    }
}
