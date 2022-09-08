using UnityEngine;

namespace Deathfated.Trivia.Gameplay.Quiz
{
    [System.Serializable]
    public class Trivia
    {
        public string LevelID;
        public string PackID;
        public string hint;
        public string question;
        public string[] answer;
        public string correctAnswer;
    }
}
