using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

public class AnalyticController : BaseController<AnalyticController>
{
    private void TrackFinishLevel(string levelID)
    {
        Debug.Log("ANALYTIC - Player finished level " + levelID);
    }

    private void TrackUnlockPack(string packID)
    {
        Debug.Log("ANALYTIC - Player unlocked pack " + packID);
    }
}
