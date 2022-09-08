using Agate.MVC.Base;
using System.Collections.Generic;


namespace Deathfated.Trivia.Gameplay
{
    public interface IGameplayModel : IBaseModel
    {
        int Level { get; }
        string QuestionNumber { get; }
        string Question { get; }
        string RightAnswer { get; }
        string AnswerA { get; }
        string AnswerB { get; }
        string AnswerC { get; }
        string AnswerD { get; }
        static List<string> AnswersList { get; }
    }
}