using Agate.MVC.Base;
using UnityEngine;

namespace Deathfated.Trivia.Gameplay.Quiz
{
    public class QuizModel : BaseModel, IQuizModel
    {
        public AnswerData AnswerData { get; private set; }
        public void SetAnswerData()
        {
            TextAsset DataTrivia = Resources.Load("Trivia") as TextAsset;
            AnswerData _source = JsonUtility.FromJson<AnswerData>(DataTrivia.text);
            AnswerData = _source;
        }
    }
}