using System;
using Foundation;
using UIKit;

namespace Xamarin.IOS.Extension
{
    public static class Device
    {
        public static bool IsPortrait()
        {
            return UIDevice.CurrentDevice.Orientation == UIDeviceOrientation.Portrait || UIDevice.CurrentDevice.Orientation == UIDeviceOrientation.PortraitUpsideDown;
        }

        public static bool IsLandscape()
        {
            return !IsPortrait();
        }

        public static bool IsIPad()
        {
            return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad;
        }

        public static bool IsIPhone()
        {
            return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone;
        }

        public static nfloat ValueForIPhoneAndIPad(nfloat ValueIPhone, nfloat ValueIPad)
        {
            if (IsIPhone())
            {
                return ValueIPhone;
            }
            else
            {
                return ValueIPad;
            }
        }

        public static double VersionAppDouble()
        {
            var version = NSBundle.MainBundle.InfoDictionary[new NSString("CFBundleShortVersionString")].ToString();

            return double.Parse(version);
        }

        public static string VersionApp()
        {
            var version = NSBundle.MainBundle.InfoDictionary[new NSString("CFBundleShortVersionString")].ToString();

            return version;
        }

        public static int TopBarra
        {
            get
            {
                if (UIApplication.SharedApplication.StatusBarHidden)
                {
                    return 0;
                }
                else
                {
                    return 20;
                }
            }
        }
    }
}
