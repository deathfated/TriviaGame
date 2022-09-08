using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine;

namespace Deathfated.Trivia.Boot
{
    public class SplashScreen : BaseSplash<SplashScreen>
    {
        protected override IMain GetMain()
        {
            return GameMain.Instance;
        }

        protected override ILoad GetLoader()
        {
            return SceneLoader.Instance;
        }

        protected override void StartSplash()
        {
            base.StartSplash();
        }

        protected override void FinishSplash()
        {
            base.FinishSplash();
        }

        protected override void StartTransition()
        {
            base.StartTransition();
        }

        protected override void FinishTransition()
        {
            base.FinishTransition();
        }
    }

}