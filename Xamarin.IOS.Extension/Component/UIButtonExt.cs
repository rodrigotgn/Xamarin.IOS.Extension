using System;
using Foundation;
using UIKit;

namespace Xamarin.IOS.Extension.Component
{
    public class UIButtonExt : UIButton
    {
        UIImageView ImageIconRight;
        UIImageView ImageIconLeft;
        UIImageView ImagemBackground;
        public UILabel lblTextPersonalizado;


        public UIButtonExt()
        {
        }

        public UIButtonExt(UIView ViewParent)
        {
            ViewParent.Add(this);
        }

        public UIButtonExt(UIViewController ViewParent)
        {
            ViewParent.Add(this);
        }

        public UIButtonExt(UIButtonType type) : base(type)
        {
        }

        public UIButtonExt(NSCoder coder) : base(coder)
        {
        }

        public UIButtonExt(NSObjectFlag t) : base(t)
        {
        }

        public UIButtonExt(IntPtr handler) : base(handler)
        {
        }

        public void AddImagemRight(UIImage imagem, nfloat width, nfloat height, nfloat marginRight)
        {
            RemoveImagemRight();

            if (imagem != null)
            {
                ImageIconRight = new UIImageView(imagem);
                Add(ImageIconRight);
                ImageIconRight.Height(width);
                ImageIconRight.Width(height);
                ImageIconRight.AlignParentRight(marginRight);
                ImageIconRight.CenterVertical();
            }
        }

        public void AddImagemRight(UIImage imagem)
        {
            AddImagemRight(imagem, 18, 18, 9);
        }

        public void AddImagemLeft(UIImage imagem, nfloat width, nfloat height, nfloat marginLeft)
        {
            RemoveImagemLeft();

            if (imagem != null)
            {
                ImageIconLeft = new UIImageView(imagem);
                Add(ImageIconLeft);
                ImageIconLeft.Height(width);
                ImageIconLeft.Width(height);
                ImageIconLeft.AlignParentLeft(marginLeft);
                ImageIconLeft.CenterVertical();
            }
        }

        public void AddImagemLeft(UIImage imagem)
        {
            AddImagemLeft(imagem, 18, 18, 9);
        }

        public void RemoveImagemLeft()
        {
            if (ImageIconLeft != null)
            {
                ImageIconLeft.RemoveFromSuperview();
            }
        }

        public void RemoveImagemRight()
        {
            if (ImageIconRight != null)
            {
                ImageIconRight.RemoveFromSuperview();
            }
        }

        public void AddImagemBackground(UIImage imagem)
        {
            RemoveImagemBackground();

            this.BackgroundColor = UIColor.Clear;

            ImagemBackground = new UIImageView(imagem);
            InsertSubview(ImagemBackground, 0);
            ImagemBackground.WidthPerc(100);
            ImagemBackground.HeightPerc(100);
        }

        public void RemoveImagemBackground()
        {
            if (ImagemBackground != null)
            {
                ImagemBackground.RemoveFromSuperview();
            }
        }

        public void SetTextPersonalizado(string text, UIFont Font, nfloat MarginLeft)
        {
            RemoveTextPersonalizado();

            lblTextPersonalizado = new UILabelExt(this);
            lblTextPersonalizado.Text = text;
            lblTextPersonalizado.Font = Font;
            lblTextPersonalizado.TextColor = UIColor.White;
            lblTextPersonalizado.SizeToFit();
            lblTextPersonalizado.SetMarginLeft(MarginLeft);
            lblTextPersonalizado.CenterVertical();
        }

        public void SetTextPersonalizado(string text)
        {
            SetTextPersonalizado(text, UIFont.FromName("Arial-BoldMT", 16), 16);
        }

        public void RemoveTextPersonalizado()
        {
            if (lblTextPersonalizado != null)
            {
                lblTextPersonalizado.RemoveFromSuperview();
            }
        }
    }

}
