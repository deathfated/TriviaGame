using Agate.MVC.Base;
using UnityEngine;
using System.Collections;

namespace Deathfated.Trivia.Gameplay.Quiz
{
    public class QuizController : DataController<QuizController, QuizModel, IQuizModel>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            SetAnswerData();
        }

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
        }

        public void SetAnswerData()
        {
            Debug.Log(_model);
            _model.SetAnswerData();
        }
    }
}