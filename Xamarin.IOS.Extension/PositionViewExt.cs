using System;
using CoreGraphics;
using UIKit;

namespace Xamarin.IOS.Extension
{
    public static class PositionViewExt
    {
        public static void Width(this UIView view, nfloat Width)
        {
            var frame = view.Frame;

            frame.Width = Width;

            view.Frame = frame;
        }

        public static void Height(this UIView view, nfloat Width)
        {
            var frame = view.Frame;

            frame.Height = Width;

            view.Frame = frame;
        }

        public static void WidthPerc(this UIView view, nfloat Width)
        {
            var frame = view.Frame;

            if (view.Superview != null)
            {
                frame.Width = view.Superview.Frame.Width * (Width / 100);
            }
            view.Frame = frame;
        }

        public static void HeightPerc(this UIView view, nfloat Height)
        {
            var frame = view.Frame;
            if (view.Superview != null)
            {
                frame.Height = view.Superview.Frame.Height * (Height / 100);
            }
            view.Frame = frame;
        }

        public static void HeightPercWithMarginTopAndBottom(this UIView view, nfloat Height, nfloat Margin)
        {
            view.HeightPercWithMarginTopAndBottom(Height, Margin, Margin);
        }

        public static void HeightPercWithMarginTopAndBottom(this UIView view, nfloat Height, nfloat MarginTop, nfloat MarginBottom)
        {
            var frame = view.Frame;

            if (view.Superview != null)
            {
                frame.Height = (view.Superview.Frame.Height * (Height / 100)) - (MarginTop + MarginBottom);

                frame.Y = MarginTop;
            }

            view.Frame = frame;
        }

        public static void WidthPercWithMarginLeftAndRight(this UIView view, nfloat Width, nfloat MarginLeft, nfloat MarginRight)
        {
            var frame = view.Frame;

            if (view.Superview != null)
            {
                frame.Width = (view.Superview.Frame.Width * (Width / 100)) - (MarginLeft + MarginRight);

                frame.X = MarginLeft;
            }

            view.Frame = frame;
        }

        public static void WidthPercWithMarginLeftAndRight(this UIView view, nfloat Width, nfloat Margin)
        {
            view.WidthPercWithMarginLeftAndRight(Width, Margin, Margin);
        }

        public static void SetMarginLeft(this UIView view, nfloat MarginLeft)
        {
            var frame = view.Frame;

            frame.X = MarginLeft;

            view.Frame = frame;
        }

        public static void SetMarginLeftPerc(this UIView view, nfloat MarginLeft)
        {
            var frame = view.Frame;

            frame.X = frame.Width * (MarginLeft / 100);

            view.Frame = frame;
        }

        public static void SetMarginRight(this UIView view, nfloat MarginRight)
        {
            var frame = view.Frame;

            frame.X = frame.X - MarginRight;
            if (view.Superview != null)
            {
                frame.X = view.Superview.Frame.Width - (frame.Width + MarginRight);
            }

            view.Frame = frame;
        }

        public static void SetMarginRightPerc(this UIView view, nfloat MarginRight)
        {
            if (view.Superview != null)
            {
                view.SetMarginRight(view.Superview.Frame.Width * (MarginRight / 100));
            }
        }

        public static void SetMarginTop(this UIView view, nfloat MarginTop)
        {
            var frame = view.Frame;

            frame.Y = MarginTop;

            view.Frame = frame;
        }


        public static void SetMarginTopPerc(this UIView view, nfloat MarginTop)
        {
            var frame = view.Frame;

            frame.Y = (frame.Height * (MarginTop / 100));

            view.Frame = frame;
        }

        public static void SetMarginBottom(this UIView view, nfloat MarginBottom)
        {
            var frame = view.Frame;

            frame.Y = frame.Y - MarginBottom;

            view.Frame = frame;
        }

        public static void SetMarginBottomPerc(this UIView view, nfloat MarginBottom)
        {
            var frame = view.Frame;

            frame.Y = frame.Y - (frame.Height * (MarginBottom / 100));

            view.Frame = frame;
        }

        public static void CenterHorizontal(this UIView view)
        {
            if (view.Superview != null)
            {
                nfloat MarginLeft = (view.Superview.Frame.Width - view.Frame.Width) / 2;

                view.SetMarginLeft(MarginLeft);
            }
        }

        public static void CenterVertical(this UIView view)
        {
            if (view.Superview != null)
            {
                nfloat MarginTop = (view.Superview.Frame.Height - view.Frame.Height) / 2;

                view.SetMarginTop(MarginTop);
            }
        }

        public static void CenterInParent(this UIView view)
        {
            if (view.Superview != null)
            {
                CenterHorizontal(view);
                CenterVertical(view);
            }
        }

        public static void AlignParentTop(this UIView view)
        {
            AlignParentTop(view, 0);
        }

        public static void AlignParentTop(this UIView view, nfloat Margin)
        {
            var frame = view.Frame;

            frame.Y = Margin;

            view.Frame = frame;
        }

        public static void AlignParentBottom(this UIView view)
        {
            AlignParentBottom(view, 0);
        }

        public static void AlignParentBottom(this UIView view, nfloat Margin)
        {
            var frame = view.Frame;

            frame.Y = view.Superview.Frame.Height - (frame.Height + Margin);

            view.Frame = frame;
        }

        public static void AlignParentLeft(this UIView view)
        {
            AlignParentLeft(view, 0);
        }

        public static void AlignParentLeft(this UIView view, nfloat Margin)
        {
            var frame = view.Frame;

            frame.X = Margin;

            view.Frame = frame;
        }

        public static void AlignParentRight(this UIView view)
        {
            AlignParentRight(view, 0);
        }

        public static void AlignParentRight(this UIView view, nfloat Margin)
        {
            var frame = view.Frame;

            frame.X = view.Superview.Frame.Width - (frame.Width + Margin);

            view.Frame = frame;
        }



        public static void AlignBelow(this UIView view, UIView otherView)
        {
            AlignBelow(view, otherView, 0);
        }

        public static void AlignBelow(this UIView view, UIView otherView, nfloat Margin)
        {
            var frame = view.Frame;

            frame.Y = otherView.Frame.Bottom + Margin;

            view.Frame = frame;
        }

        public static void AlignAbove(this UIView view, UIView otherView)
        {
            AlignAbove(view, otherView, 0);
        }

        public static void AlignAbove(this UIView view, UIView otherView, nfloat Margin)
        {
            var frame = view.Frame;

            frame.Y = otherView.Frame.Top - (view.Frame.Height + Margin);

            view.Frame = frame;
        }

        public static void AlignRight(this UIView view, UIView otherView)
        {
            AlignRight(view, otherView, 0);
        }

        public static void AlignRight(this UIView view, UIView otherView, nfloat Margin)
        {
            var frame = view.Frame;

            frame.X = otherView.Frame.Right + Margin;

            view.Frame = frame;
        }

        public static void AlignLeft(this UIView view, UIView otherView)
        {
            AlignLeft(view, otherView, 0);
        }

        public static void AlignLeft(this UIView view, UIView otherView, nfloat Margin)
        {
            var frame = view.Frame;

            frame.X = otherView.Frame.Left - (view.Frame.Width + Margin);

            view.Frame = frame;
        }

        private static CGSize GetAutomaticSize(this UIView view)
        {
            nfloat width = 0;
            nfloat height = 0;

            foreach (var itemView in view.Subviews)
            {
                if (itemView.Frame.Right > width)
                {
                    width = itemView.Frame.Right;
                }
                if (itemView.Frame.Bottom > height)
                {
                    height = itemView.Frame.Bottom;
                }
            }

            return new CGSize(width, height);
        }

        public static void AutomaticSizeHeight(this UIView view)
        {
            view.AutomaticSizeHeight(0);
        }

        public static void AutomaticSizeHeight(this UIView view, nfloat Margin)
        {
            var size = GetAutomaticSize(view);

            var frame = view.Frame;
            frame.Height = size.Height + Margin;
            view.Frame = frame;
        }

        public static void AutomaticSizeWidth(this UIView view)
        {
            var size = GetAutomaticSize(view);

            var frame = view.Frame;
            frame.Width = size.Width;
            view.Frame = frame;
        }

        public static void AutomaticSize(this UIView view)
        {
            var size = GetAutomaticSize(view);

            var frame = view.Frame;

            frame.Width = size.Width;
            frame.Height = size.Height;

            view.Frame = frame;
        }

        public static void AutomaticContentSize(this UIScrollView view)
        {
            AutomaticContentSize(view, 0);
        }

        public static void AutomaticContentSize(this UIScrollView view, nfloat MarginBottom)
        {
            var size = GetAutomaticSize(view);

            view.ContentSize = new CGSize(size.Width, size.Height + MarginBottom);
        }

        public static UIImage ScaleWithHeight(this UIImage image, nfloat Height)
        {
            var width = Height / image.Size.Height * image.Size.Width;
            return image.Scale(new CGSize(width, Height));
        }

        public static UIImage ScaleWithWidth(this UIImage image, nfloat Width)
        {
            var height = Width / image.Size.Width * image.Size.Height;
            return image.Scale(new CGSize(Width, height));
        }
    }
}
