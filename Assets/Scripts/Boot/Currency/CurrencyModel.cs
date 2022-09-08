using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Deathfated.Trivia.Boot
{
    public class CurrencyModel : BaseModel
    {
        public int Coin;

        public void SetCoin(int source)
        {
            Coin = source;
            SetDataAsDirty();
        }
    }
}