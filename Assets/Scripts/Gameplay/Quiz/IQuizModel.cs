using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Deathfated.Trivia.Gameplay.Quiz
{
    public interface IQuizModel : IBaseModel
    {
        public AnswerData AnswerData { get; }
    }
}