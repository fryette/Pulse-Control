using CoreAnimation;
using Foundation;
using System;
using UIKit;
using Xamarin.iOS.PulseControl;

namespace Pulsing.Sample
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Warning.Layer.BorderColor = UIColor.White.CGColor;
            Warning.Layer.BorderWidth = 5;
            Warning.Layer.AddAnimation(new CABasicAnimation
            {
                KeyPath = "transform.scale",
                Duration = 0.75,
                From = NSNumber.FromFloat(0.9f),
                To = NSNumber.FromFloat(1),
                TimingFunction = CAMediaTimingFunction.FromName(CAMediaTimingFunction.EaseInEaseOut),
                AutoReverses = true,
                RepeatCount = float.PositiveInfinity
            }, null);

            const float radius = 80;
            RootView.Layer.InsertSublayer(new PulseCALayer(radius, RootView.Center) { BackgroundColor = UIColor.Red.CGColor }, 0);
            RootView.Layer.InsertSublayer(new PulseCALayer(radius, RootView.Center, delay: 0.2f) { BackgroundColor = UIColor.Red.CGColor }, 1);
            RootView.Layer.InsertSublayer(new PulseCALayer(radius, RootView.Center, delay: 0.4f) { BackgroundColor = UIColor.Red.CGColor }, 1);
        }
    }
}