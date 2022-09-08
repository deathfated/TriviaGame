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
        }

        protected override IController[] GetDependencies()
        {
            return new IController[]
            {
                new QuizController(),
                new LevelStatusController(),
                new CurrencyController(),
                new AnalyticController()

            };
        }


        protected override IEnumerator StartInit()
        {
            yield return null;
        }
    }
}