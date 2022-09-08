using Agate.MVC.Base;
using System.Collections.Generic;

namespace Deathfated.Trivia.Pack
{
    public interface IPackStatusModel : IBaseModel
    {
        int Pack { get; }
        List<string> PackStatusList { get; }
    }
}