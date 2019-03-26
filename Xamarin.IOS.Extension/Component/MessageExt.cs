using System;
using System.Collections.Generic;
using UIKit;

namespace Xamarin.IOS.Extension.Component
{
    public static class MessageExt
    {
        public static void Show(string Message, string Button = "Ok")
        {
            Show("Atenção", Message, Button);
        }

        public static void Show(string Title, string Message, string Button = "Ok")
        {
            new UIAlertView(Title, Message, null, Button, null).Show();
        }

        public static void ShowAlertMessageTimer(this UIViewController ViewController, string Title, string Message, double Delay = 6.0f)
        {
            ViewController.InvokeOnMainThread(() =>
            {
                UIAlertController AlertView = UIAlertController.Create(Title, Message, UIAlertControllerStyle.ActionSheet);

                ViewController.PresentViewController(AlertView, true, () =>
                {
                    ViewController.Invoke(() => { AlertView.DismissViewController(true, null); }, Delay);
                });
            });
        }

        public static void ShowAlertMessageTimerWithOk(this UIViewController ViewController, string Title, string Message, double Delay = 6.0f)
        {
            ViewController.InvokeOnMainThread(() =>
            {
                UIAlertController AlertView = UIAlertController.Create(Title, Message, UIAlertControllerStyle.ActionSheet);

                AlertView.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, (UIAlertAction obj) => { }));

                ViewController.PresentViewController(AlertView, true, () =>
                {
                    ViewController.Invoke(() => { AlertView.DismissViewController(true, null); }, Delay);
                });
            });
        }

        public static void ShowAlertMessage(this UIViewController ViewController, string Title, string Message, UIAlertAction AlertButton = null, List<UIAlertAction> ListAlertButton = null)
        {
            ViewController.InvokeOnMainThread(() =>
            {
                UIAlertController AlertView = UIAlertController.Create(Title, Message, UIAlertControllerStyle.ActionSheet);

                if (AlertButton == null)
                {
                    AlertView.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, (UIAlertAction obj) => { }));
                }
                else
                {
                    AlertView.AddAction(AlertButton);
                }

                if (ListAlertButton != null)
                {
                    foreach (var item in ListAlertButton)
                    {
                        AlertView.AddAction(item);
                    }
                }

                ViewController.PresentViewController(AlertView, true, null);
            });
        }
    }
}
