using Agate.MVC.Base;

namespace Deathfated.Trivia.Pack
{
    public class PackSelectModel : BaseModel, IPackSelectModel
    {
        public int Pack { get; set; }
        public int PackNumber { get; set; }

        public int GetPack()
        {
            return Pack;
        }

        public void SetPack(int source)
        {
            PackNumber = source;
            Pack = PackNumber - 1;
        }
    }
}