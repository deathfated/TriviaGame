using Agate.MVC.Base;

namespace Deathfated.Trivia.Boot
{
    public class SceneLoader : BaseLoader<SceneLoader>
    {
        protected override string SplashScene { get { return "Splash"; } }
    }
}