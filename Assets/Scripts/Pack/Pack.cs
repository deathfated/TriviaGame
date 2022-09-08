using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Deathfated.Trivia.Pack
{
    public class Pack : MonoBehaviour
    {
        [SerializeField] private List<Button> _Buttons;
        [SerializeField] private Button _closeButton;

        private void Start()
        {
            Button btn = _closeButton.GetComponent<Button>();
            btn.onClick.AddListener(OnClickClose);
        }

        void OnClickClose()
        {
            SceneManager.LoadScene("Home");
        }
    }
}