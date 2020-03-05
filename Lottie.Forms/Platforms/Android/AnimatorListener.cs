using System;
using Android.Animation;

namespace Lottie.Forms.Droid
{
    public class AnimatorListener : AnimatorListenerAdapter
    {
        private Action _play;

        public AnimatorListener(Action play)
        {
            _play = play;
        }

        public override void OnAnimationEnd(Animator animation)
        {
            base.OnAnimationEnd(animation);
        }

        public override void OnAnimationCancel(Animator animation)
        {
            base.OnAnimationCancel(animation);
            _play?.Invoke();
        }
    }
}
