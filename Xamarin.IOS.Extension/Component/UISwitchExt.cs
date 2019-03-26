using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Xamarin.IOS.Extension.Component
{
    public class UISwitchExt : UIView
    {
        public UILabel Descricao;
        public UISwitch Switch;

        public UISwitchExt()
        {
            CarregarComponentes();
        }

        public UISwitchExt(UIView ViewParent)
        {
            ViewParent.Add(this);
            CarregarComponentes();
        }

        public UISwitchExt(UIViewController ViewParent)
        {
            ViewParent.Add(this);
            CarregarComponentes();
        }

        public UISwitchExt(NSCoder coder) : base(coder)
        {
            CarregarComponentes();
        }

        public UISwitchExt(CGRect frame) : base(frame)
        {
            CarregarComponentes();
        }

        private void CarregarComponentes()
        {
            if (Descricao == null)
            {
                Descricao = new UILabelExt(this);
                Descricao.Font = UIFont.SystemFontOfSize(13);
                Descricao.TextAlignment = UITextAlignment.Center;
            }

            if (Switch == null)
            {
                Switch = new UISwitch();
                this.Add(Switch);
            }

            PosicionarComponentes();
        }

        private void PosicionarComponentes()
        {
            if (Descricao == null)
            {
                CarregarComponentes();
            }

            Descricao.SizeToFit();
            Descricao.Height(Switch.Frame.Height);
            Descricao.AlignRight(Switch, 5);

            SizeToFit();
        }

        public override void SizeToFit()
        {
            this.AutomaticSize();
        }

        public String Text
        {
            get
            {
                return Descricao.Text;
            }
            set
            {
                if (Descricao == null)
                {
                    CarregarComponentes();
                }
                Descricao.Text = value;
                PosicionarComponentes();
            }
        }

        public Boolean On
        {
            get
            {
                return Switch.On;
            }
            set
            {
                if (Switch == null)
                {
                    CarregarComponentes();
                }
                Switch.On = value;
            }
        }
    }
}
