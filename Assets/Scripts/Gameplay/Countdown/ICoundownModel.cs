using Agate.MVC.Base;

public interface ICoundownModel : IBaseModel
{
    float TimeLeft { get; }
    float TimeTotal { get; }
    float CountDown { get; }
    float CountTotal { get; }
    bool IsRunning { get; }
    bool IsFinished { get; }
    bool IsCountDown { get; }
    string GetTimeLeftAsString();
    void StartTimer();
    void ResumeTimer();
    void PauseTimer();
    void Reset();
}
