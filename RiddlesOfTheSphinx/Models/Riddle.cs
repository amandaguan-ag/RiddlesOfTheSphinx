using System;

namespace RiddlesOfTheSphinx.Models
{
    public class Riddle
    {
        private string riddle;
        private string answer;

        public Riddle()
        {
            riddle = "What is always in front of you but can't be seen?";
            answer = "The future";
        }

        public bool AnswerRiddle(string riddle, string answer)
        {
            if (riddle == this.riddle && answer == this.answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
