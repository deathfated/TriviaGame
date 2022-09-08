using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Deathfated.Trivia.Boot
{
    public class CurrencyController : BaseController<CurrencyController>
    {
        private CurrencyModel _model;
        private int _levelReward = 50;


        private void GetCoin(int coin)
        {
            _model.SetCoin(coin);
        }

        private void AddCoin(int amount)
        {
            if (amount >= 0)
            {
                _model.Coin += amount;
            }
            else
            {
                _model.Coin += _levelReward;
            }
        }

        private void SpendCoin(int amount)
        {
            _model.Coin -= amount;
        }
    }
}