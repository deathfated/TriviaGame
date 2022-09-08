using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine;
using Deathfated.Trivia.Utility;
using Deathfated.Trivia.Boot;

namespace Deathfated.Trivia.Level
{
    public class LevelSLauncher : SceneLauncher<LevelSLauncher, LevelSView>
    {
        public override string SceneName => Scenes.Level;
        private LevelController _level;

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
              new LevelController()
          };
        }

        protected override IEnumerator InitSceneObject()
        {
            _level.SetView(_view.LevelView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;

        }
    }
}