using Agate.MVC.Base;

namespace Deathfated.Trivia.Level
{
    public interface ILevelModel : IBaseModel
    {
        int Level { get; }
        int LevelNumber { get; }
    }
}