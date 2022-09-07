using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Deathfated.Trivia.Home
{
    public class Home : MonoBehaviour
    {
        [SerializeField] private Button _playButton;

        private void Start()
        {
            Button btn = _playButton.GetComponent<Button>();
            btn.onClick.AddListener(OnClickPlay);
        }

        void OnClickPlay()
        {
            SceneManager.LoadScene("GameplayScene");
        }
    }
}