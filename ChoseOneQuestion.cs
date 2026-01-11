using System;
using System.Collections.Generic;
using System.Text;

namespace Task06_ver1
{
    public class ChoseOneQuestion:Question
    {
        public ChoseOneQuestion(string Header, Que_Level QueLevel, int QuesDegree, List<string> choises, int correctAnswer):base(Header, QueLevel, QuesDegree) 
        {
            Choises = choises;
            CorrectAnswer = correctAnswer;
        }

        public List<string> Choises { get; set; }=new List<string>();
        public int CorrectAnswer { get; set; }
        public override void Disply()
        {
            Console.WriteLine(Header + "\n Question Degree " + QuesDegree);
            for (int i = 0; i < Choises.Count; i++)
            {
                Console.WriteLine((i+1) + "-" + Choises[i]);
            }

        }
        public override bool CheckAnswer(string AnswerToCheck)
        {
            if (Convert.ToInt32( AnswerToCheck) == CorrectAnswer)
            {
                return true;
            }
            return false;
        }  
    }
}
