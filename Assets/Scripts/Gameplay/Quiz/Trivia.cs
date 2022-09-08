using UnityEngine;

namespace Deathfated.Trivia.Gameplay.Quiz
{
    [System.Serializable]
    public class Trivia
    {
        public string number;
        public string question;
        public Sprite hint;
        public string[] answer;
        public string correctAnswer;
    }
}
