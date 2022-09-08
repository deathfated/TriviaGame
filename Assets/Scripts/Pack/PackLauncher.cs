using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Deathfated.Trivia.Boot;
using Deathfated.Trivia.Utility;
using UnityEngine;

namespace Deathfated.Trivia.Pack
{
    public class PackLauncher : SceneLauncher<PackLauncher, PackView>
    {
        public override string SceneName => Scenes.Pack;
        private PackSelectController _pack;

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
                new PackSelectController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _pack.SetView(_view.PackSelectView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}