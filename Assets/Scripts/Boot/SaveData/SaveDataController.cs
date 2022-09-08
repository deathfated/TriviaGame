using UnityEngine;
using Agate.MVC.Base;

namespace Deathfated.Trivia.Boot
{
    [System.Serializable]
    public class SaveDataController : BaseController<SaveDataController>
    {
        private SaveDataModel saveDataModel;
        private const string _prefsKey = "_Trivia_";
        
        private void Save()
        {
            string json = JsonUtility.ToJson(this);
            PlayerPrefs.SetString(_prefsKey, json);
        }

        private void Load()
        {
            if (PlayerPrefs.HasKey(_prefsKey))
            {
                string json = PlayerPrefs.GetString(_prefsKey);
                JsonUtility.FromJsonOverwrite(json, this);
            }
            else
            {
                Save();
            }
        }

        private void SetSaveData(int coin, string[] unlockedPack, string[] completedPack, string[] completedLevel)
        {
            saveDataModel.Coin = coin;
            saveDataModel.UnlockedPack = unlockedPack;
            saveDataModel.CompletedPack = completedPack;
            saveDataModel.CompletedLevel = completedLevel;
            Save();
        }
    }
}