using Agate.MVC.Base;
using System.Collections;
using Deathfated.Trivia.Boot;
using Deathfated.Trivia.Gameplay.Quiz;
using Deathfated.Trivia.Level;
using Deathfated.Trivia.Utility;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Deathfated.Trivia.Gameplay
{
    public class GameplayController : ObjectController<GameplayController, GameplayModel, IGameplayModel, GameplayView>
    {
        private QuizController _quizController;
        private LevelStatusController _levelStatus;
        private AnswersMessage _message = new AnswersMessage();
        private FinishLevel _finish = new FinishLevel();

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
        }

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();

        }

        public override void SetView(GameplayView view)
        {
            base.SetView(view);
            view.Init(Back, Choose1, Choose2, Choose3, Choose4);

            int LevelSelect = _levelStatus.Model.Level;
            SetLevel(LevelSelect);
            SetTrivia(_model.Level);
        }

        public void SetLevel(int level)
        {
            _model.SetLevel(level);
        }

        public void SetTrivia(int level)
        {
            string levelID = _quizController.Model.AnswerData.Trivia[level].LevelID;
            string packID = _quizController.Model.AnswerData.Trivia[level].PackID;
            string hint = _quizController.Model.AnswerData.Trivia[level].hint;
            string question = _quizController.Model.AnswerData.Trivia[level].question;
            string correctAnswer = _quizController.Model.AnswerData.Trivia[level].correctAnswer;
            string[] answers = _quizController.Model.AnswerData.Trivia[level].answer;

            _model.SetTrivia(levelID, packID, hint, question, correctAnswer, answers);
        }

        public void Choose1()
        {
            string playerAnswer = _model.AnswerA;
            string rightAnswer = _model.RightAnswer;
            AnswerCheck(playerAnswer, rightAnswer);
        }

        public void Choose2()
        {
            string playerAnswer = _model.AnswerB;
            string rightAnswer = _model.RightAnswer;
            AnswerCheck(playerAnswer, rightAnswer);
        }

        public void Choose3()
        {
            string playerAnswer = _model.AnswerC;
            string rightAnswer = _model.RightAnswer;
            AnswerCheck(playerAnswer, rightAnswer);
        }

        public void Choose4()
        {
            string playerAnswer = _model.AnswerD;
            string rightAnswer = _model.RightAnswer;
            AnswerCheck(playerAnswer, rightAnswer);
        }

        public void AnswerCheck(string playerAnswer, string correctAnswer)
        {
            if (playerAnswer == correctAnswer)
            {
                Debug.Log("Jawaban Benar.");
                _message.IsAnswerCorrect = true;
                Publish<AnswersMessage>(_message);

                _finish.LevelID = _model.Level;
                Publish<FinishLevel>(_finish);

                if (_model.PackComplete == true)
                {
                    BackToPack();
                }
                else
                {
                    _model.NextLevel();
                    _levelStatus.Unlock(_model.Level);
                    SetTrivia(_model.Level);
                }
            }
            else
            {
                Debug.Log("Jawaban Salah!!!");
                _message.IsAnswerCorrect = false;
                Publish<AnswersMessage>(_message);
                Back();
            }
        }

        public void Back()
        {
            SceneLoader.Instance.LoadScene(Scenes.Level);
        }

        public void BackToPack()
        {
            SceneLoader.Instance.LoadScene(Scenes.Pack);
        }
    }
}