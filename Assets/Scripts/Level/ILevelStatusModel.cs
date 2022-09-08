using Agate.MVC.Base;
using System.Collections.Generic;

namespace Deathfated.Trivia.Level
{
    public interface ILevelStatusModel : IBaseModel
    {
        int Level { get; }
        List<string> LevelStatusList { get; }
    }
}