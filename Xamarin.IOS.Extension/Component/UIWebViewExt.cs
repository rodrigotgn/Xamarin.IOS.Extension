using CoreGraphics;
using Foundation;
using UIKit;

namespace Xamarin.IOS.Extension.Component
{
    public class UIWebViewExt : UIWebView
    {
        public UIWebViewExt()
        {

        }

        public UIWebViewExt(UIView ViewParent)
        {
            ViewParent.Add(this);
            CarregarComponentes();
        }

        public UIWebViewExt(UIViewController ViewParent)
        {
            ViewParent.Add(this);
            CarregarComponentes();
        }

        public UIWebViewExt(NSCoder coder) : base(coder)
        {
            CarregarComponentes();
        }

        public UIWebViewExt(CGRect frame) : base(frame)
        {
            CarregarComponentes();
        }

        private void CarregarComponentes()
        {

        }
    }
}
