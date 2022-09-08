using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using Deathfated.Trivia.Boot;
using Deathfated.Trivia.Utility;

namespace Deathfated.Trivia.Gameplay
{
    public class GameLauncher : SceneLauncher<GameLauncher, GameView>
    {
        public override string SceneName => Scenes.Gameplay;
        private GameplayController _gameplay;
        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {

            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
             {
                new GameplayController(),
             };
        }

        protected override IEnumerator InitSceneObject()
        {
            _gameplay.SetView(_view.GameplayView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}