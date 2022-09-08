using System;
using UnityEngine;
using TMPro;
using Agate.MVC.Base;

namespace Deathfated.Trivia.Gameplay
{
    public class CountdownView : ObjectView<ICoundownModel>
    {
        private Action _onTimerUpdateEvent;
        [SerializeField] private TMP_Text _timerText;

        public void SetCallback(Action onTimerUpdateEvent)
        {
            _onTimerUpdateEvent = onTimerUpdateEvent;
        }

        public void Update()
        {
            _onTimerUpdateEvent?.Invoke();
        }

        protected override void InitRenderModel(ICoundownModel model)
        {
            _timerText.text = model.GetTimeLeftAsString();
        }

        protected override void UpdateRenderModel(ICoundownModel model)
        {
            if (model.IsCountDown) ShowCountDown();
            else if (model.IsRunning)
            {
                _timerText.gameObject.SetActive(true);
            }

            if (model.IsFinished)
            {
                _timerText.gameObject.SetActive(false);
            }

            _timerText.text = model.GetTimeLeftAsString();
        }

        public void ShowCountDown()
        {
            _timerText.gameObject.SetActive(false);
        }
    }
}