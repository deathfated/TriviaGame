using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections.Generic;

namespace Deathfated.Trivia.Pack
{
    public class PackSelectView : BaseView
    {
        [SerializeField] private Button _closeButton;
        [SerializeField] private List<Button> _buttons;
        [SerializeField] private int _totalButtons;
        private int _index;

        private void Start()
        {
            _index = 1;
        }

        public void Init(UnityAction OnClose, UnityAction<int> OnPack)
        {
            _closeButton.onClick.RemoveAllListeners();
            _closeButton.onClick.AddListener(OnClose);

            foreach (Button b in _buttons)
            {
                b.onClick.RemoveAllListeners();
                b.onClick.AddListener(() => OnPack(_index));
                _index++;
                //brute
            }
        }
    }
}