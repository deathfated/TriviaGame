using Agate.MVC.Base;
using Agate.MVC.Core;
using Deathfated.Trivia.Gameplay.Quiz;
using Deathfated.Trivia.Level;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Deathfated.Trivia.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return null;
            
            /*return new IConnector[]
            {
                new sfxConnector()
            }*/
        }

        protected override IController[] GetDependencies()
        {
            return new IController[]
            {
                new QuizController(),
                new LevelStatusController()

            };
        }


        protected override IEnumerator StartInit()
        {
            yield return null;
        }
    }
}