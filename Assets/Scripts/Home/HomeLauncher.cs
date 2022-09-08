using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using UnityEngine;
using Deathfated.Trivia.Boot;
using Deathfated.Trivia.Utility;

namespace Deathfated.Trivia.Home
{
    public class HomeLauncher : SceneLauncher<HomeLauncher, HomeView>
    {
        private MenuController _menu;
        public override string SceneName => Scenes.Home;

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
                new MenuController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _menu.SetView(_view.MenuView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}