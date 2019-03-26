using System;
using UIKit;

namespace Xamarin.IOS.Extension
{
    public static class NavigationControllerExt
    {
        public static UIViewController ViewController;

        public static void OpenView(this UIViewController View, UIViewController ViewOpen, bool Animate = true)
        {
            View.PresentViewController(ViewOpen, Animate, null);
            ViewController = null;
        }

        public static void CloseView(this UIViewController View)
        {
            View.DismissViewController(true, null);
        }

        public static void CloseView(this UIViewController View, bool Animate)
        {
            View.DismissViewController(Animate, null);
        }

        public static void CloseAndOpenAnotherView(this UIViewController View, UIViewController ViewOpen)
        {
            View.DismissViewController(true, null);
            ViewController = ViewOpen;
        }

        public static void CloseAndOpenAnotherView(this UIViewController View, UIViewController ViewOpen, bool Animate)
        {
            View.DismissViewController(Animate, null);
            ViewController = ViewOpen;
        }
    }
}
