using Agate.MVC.Base;
using System.Collections.Generic;

namespace Deathfated.Trivia.Pack
{
    public class PackStatusModel : BaseModel, IPackStatusModel
    {
        public int Pack { get; protected set; }
        public List<string> PackStatusList { get; protected set; } = new List<string> { "Unlock", "Lock", "Lock", "Lock" };

        public void UnlockPack(int pack)
        {
            PackStatusList[pack] = "Unlock";
        }

        public void SetPack(int source)
        {
            Pack = source;
        }

        public void Reset()
        {
            for (int i = 0; i < PackStatusList.Count; i++)
            {
                if(i == 1)
                {
                    PackStatusList[i] = "Unlock";
                }
                PackStatusList[i] = "Lock";
            }
        }

        public bool CheckStatus(int level)
        {
            if(PackStatusList[level] == "Unlock")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}