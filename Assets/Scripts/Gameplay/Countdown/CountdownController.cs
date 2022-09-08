using Agate.MVC.Base;
using UnityEngine;

namespace Deathfated.Trivia.Gameplay
{
    public class CountdownController : ObjectController<CountdownController, CountdownModel, ICoundownModel, CountdownView>
    {
            private bool _isAlreadyPublishCountDown;
            private bool _isAlreadyPublishTimerFinished = true;

            public override void SetView(CountdownView view)
            {
                view.SetCallback(OnTimerUpdate);
                base.SetView(view);
            }

            public void OnStartGame()
            {
                Debug.Log("Timer Start");
                _model.StartTimer();
                _view.ShowCountDown();
                _isAlreadyPublishTimerFinished = false;
            }

            public void OnGameResume()
            {
                Debug.Log("Timer Resume");
                _model.ResumeTimer();
            }

            public void OnGamePause()
            {
                Debug.Log("Timer Pause");
                _model.PauseTimer();
            }

            private void OnTimerUpdate()
            {
                _model.OnTimerRunning(Time.deltaTime);
                CheckTimer();
            }

            private void CheckTimer()
            {
                if (_model.CountDown <= 0 && !_isAlreadyPublishCountDown)
                {
                    _isAlreadyPublishCountDown = true;
                    Debug.Log("Count Down Finish");
                    //Publish(new TimerCountDownMessage(_model.CountDown, _model.TimeLeft, TimerEventType.OnCountdownFinish));
                }
                else if (_model.IsFinished && !_isAlreadyPublishTimerFinished)
                {
                    _isAlreadyPublishTimerFinished = true;
                    Debug.Log("Timer Finish");
                    //Publish(new TimerCountDownMessage(_model.CountDown, _model.TimeLeft, TimerEventType.OnTimerFinish));
                }
            }

            public void HideView()
            {
                _view.gameObject.SetActive(false);
                _isAlreadyPublishCountDown = true;
                _isAlreadyPublishTimerFinished = true;
            }
        }
}