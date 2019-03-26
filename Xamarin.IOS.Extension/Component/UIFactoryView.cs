using System;
using UIKit;

namespace Xamarin.IOS.Extension.Component
{
    public static class UIFactoryView
    {
        public static T Create<T>(UIView ViewParent) where T : UIView, new()
        {
            var view = new T();
            ViewParent.Add(view);
            return view;
        }

        public static T Create<T>(UIViewController ViewParent) where T : UIView, new()
        {
            return UIFactoryView.Create<T>(ViewParent.View);
        }
    }
}
