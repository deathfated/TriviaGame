using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Deathfated.Trivia.Boot
{
    public class SaveDataModel : BaseModel
    {
        public int Coin;
        public string[] UnlockedPack;
        public string[] CompletedPack;
        public string[] CompletedLevel;
    }
}