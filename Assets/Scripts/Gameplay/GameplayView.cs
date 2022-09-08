using Agate.MVC.Base;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


namespace Deathfated.Trivia.Gameplay
{
    public class GameplayView : ObjectView<IGameplayModel>
    {
        [SerializeField]
        private Button _exitButton;

        [SerializeField]
        private Button _answer1Button;

        [SerializeField]
        private Button _answer2Button;

        [SerializeField]
        private Button _answer3Button;

        [SerializeField]
        private Button _answer4Button;

        [SerializeField]
        private TextMeshProUGUI _levelText;

        [SerializeField]
        private TextMeshProUGUI _questionText;

        public void Init(UnityAction back, UnityAction chooseA, UnityAction chooseB, UnityAction chooseC, UnityAction chooseD)
        {
            _exitButton.onClick.RemoveAllListeners();
            _exitButton.onClick.AddListener(back);
            _answer1Button.onClick.RemoveAllListeners();
            _answer1Button.onClick.AddListener(chooseA);
            _answer2Button.onClick.RemoveAllListeners();
            _answer2Button.onClick.AddListener(chooseB);
            _answer3Button.onClick.RemoveAllListeners();
            _answer3Button.onClick.AddListener(chooseC);
            _answer4Button.onClick.RemoveAllListeners();
            _answer4Button.onClick.AddListener(chooseD);
        }

        protected override void InitRenderModel(IGameplayModel model)
        {
            _levelText.text = model.QuestionNumber;
            _questionText.text = model.Question;
            _answer1Button.GetComponentInChildren<TextMeshProUGUI>().text = model.AnswerA;
            _answer2Button.GetComponentInChildren<TextMeshProUGUI>().text = model.AnswerB;
            _answer3Button.GetComponentInChildren<TextMeshProUGUI>().text = model.AnswerC;
            _answer4Button.GetComponentInChildren<TextMeshProUGUI>().text = model.AnswerD;
        }

        protected override void UpdateRenderModel(IGameplayModel model)
        {
            _levelText.text = model.QuestionNumber;
            _questionText.text = model.Question;
            _answer1Button.GetComponentInChildren<TextMeshProUGUI>().text = model.AnswerA;
            _answer2Button.GetComponentInChildren<TextMeshProUGUI>().text = model.AnswerB;
            _answer3Button.GetComponentInChildren<TextMeshProUGUI>().text = model.AnswerC;
            _answer4Button.GetComponentInChildren<TextMeshProUGUI>().text = model.AnswerD;
        }
    }
}