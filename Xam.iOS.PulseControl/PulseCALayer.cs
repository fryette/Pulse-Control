using CoreAnimation;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Xamarin.iOS.PulseControl
{
    public class PulseCALayer : CALayer
    {
        public PulseCALayer(float radius,
            CGPoint position,
            float animationDuration = 1.5f,
            float delay = 0.01f,
            float nextPulseAfter = 0f,
            float initialPulseScale = 0,
            float numberOfPulses = float.PositiveInfinity)
        {
            ContentsScale = UIScreen.MainScreen.Scale;
            Opacity = 0;
            Position = position;
            Bounds = new CGRect(0, 0, radius * 2, radius * 2);
            CornerRadius = radius;

            var animationGroup = new CAAnimationGroup
            {
                Duration = animationDuration + nextPulseAfter,
                BeginTime = delay,
                RepeatCount = numberOfPulses,
                TimingFunction = CAMediaTimingFunction.FromName(CAMediaTimingFunction.Default),
                Animations = new CAAnimation[]
                {
                    CreateScaleAnimation(animationDuration, initialPulseScale),
                    CreateOpacityAnimation(animationDuration)
                }
            };

            AddAnimation(animationGroup, "pulse");
        }

        private static CAKeyFrameAnimation CreateOpacityAnimation(float animationDuration)
        {
            return new CAKeyFrameAnimation
            {
                KeyPath = "opacity",
                Duration = animationDuration,
                Values = new NSObject[]
                {
                    NSNumber.FromFloat(0.2f), NSNumber.FromFloat(0.4f), NSNumber.FromFloat(0.8f), NSNumber.FromFloat(0)
                },
                KeyTimes = new[]
                    {NSNumber.FromFloat(0), NSNumber.FromFloat(0.2f), NSNumber.FromFloat(0.4f), NSNumber.FromFloat(1)}
            };
        }

        private static CABasicAnimation CreateScaleAnimation(float animationDuration, float initialPulseScale)
        {
            return new CABasicAnimation
            {
                KeyPath = "transform.scale.xy",
                From = NSNumber.FromFloat(initialPulseScale),
                To = NSNumber.FromFloat(1),
                Duration = animationDuration,
            };
        }
    }
}
