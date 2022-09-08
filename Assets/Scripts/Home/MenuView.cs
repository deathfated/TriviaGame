using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Deathfated.Trivia.Home
{
    public class MenuView : BaseView
    {
        [SerializeField] private Button _startButton;

        public void Init(UnityAction OnStart)
        {
            _startButton.onClick.RemoveAllListeners();
            _startButton.onClick.AddListener(OnStart);
        }
    }
}