using Agate.MVC.Base;

namespace Deathfated.Trivia.Pack
{
    public interface IPackSelectModel : IBaseModel
    {
        int Pack { get; }
        int PackNumber { get; } 
    }
}