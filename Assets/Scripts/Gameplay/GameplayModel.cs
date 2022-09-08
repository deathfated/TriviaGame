using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;

namespace Deathfated.Trivia.Gameplay
{
    public class GameplayModel : BaseModel, IGameplayModel
    {
        public int Level { get; protected set; }
        public string QuestionNumber { get; protected set; }
        public string PackNumber { get; protected set; }
        public string HintString { get; protected set; }
        public string Question { get; protected set; }
        public string RightAnswer { get; protected set; }
        public static List<string> AnswersList { get; protected set; }
        public string AnswerA { get; protected set; }
        public string AnswerB { get; protected set; }
        public string AnswerC { get; protected set; }
        public string AnswerD { get; protected set; }

        public bool PackComplete = false;

        public string RandomAnswer()
        {
            int number = Random.Range(0, AnswersList.Count);
            string result = AnswersList[number];
            AnswersList.RemoveAt(number);
            return result;
        }

        public void SetTrivia(string levelID,string packID, string hint, string questionSource, string rightAnswerSource, string[] answersSource)
        {
            PackComplete = false;
            QuestionNumber = levelID;
            PackNumber = packID;
            HintString = hint;
            Question = questionSource;
            RightAnswer = rightAnswerSource;
            AnswersList = new List<string>(answersSource);
            AnswerA = RandomAnswer();
            AnswerB = RandomAnswer();
            AnswerC = RandomAnswer();
            AnswerD = RandomAnswer();
            SetDataAsDirty();
        }

        public void SetLevel(int source)
        {
            Level = source;
            SetDataAsDirty();
        }

        public void NextLevel()
        {
            if (Level == 5)
            {
                Level = 0;
                PackComplete = true;
            }
            else
            {
                Level++;
                Debug.Log(Level);
            }
            SetDataAsDirty();
        }

        public void Reset()
        {
            Level = 0;
            Question = null;
            RightAnswer = null;
            AnswersList = null;
            SetDataAsDirty();
        }
    }
}