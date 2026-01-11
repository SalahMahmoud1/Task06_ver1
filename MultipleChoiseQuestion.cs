using System;
using System.Collections.Generic;
using System.Text;

namespace Task06_ver1
{
    public class MultipleChoiseQuestion:Question
    {
        public MultipleChoiseQuestion(string Header, Que_Level QueLevel, int QuesDegree, List<string> choises, string correctAnswer):base(Header, QueLevel, QuesDegree)
        {
            Choises = choises;
            CorrectAnswer = correctAnswer;
        }

        public List<string> Choises { get; set; } = new List<string>();
        public string CorrectAnswer { get; set; }
        public override void Disply()
        {
            Console.WriteLine(Header + "\n Question Degree " + QuesDegree);
            for (int i = 0; i < Choises.Count; i++)
            {
                Console.WriteLine((i + 1) + "-" + Choises[i]);
            }
            Console.WriteLine("Enter Muliples Answers separated by Comma like that 1,2,3,......");
        }
        public override bool CheckAnswer(string AnswerToCheck)
        {
            int[] ar1 = new int[5];
            int[] ar2 = new int[5];
            var CAnswer = CorrectAnswer.Replace(" ", "").Split(",");
            var StdAnswer = AnswerToCheck.Replace(" ", "").Split(",");
            for (int i = 0; i < CAnswer.Length; i++)
            {

                ar1[Convert.ToInt32(CAnswer[i])] = 1;
            }
            for (int i = 0; i < StdAnswer.Length; i++)
            {

                ar2[Convert.ToInt32(StdAnswer[i])] = 1;
            }
            bool checkeq = false;
            for (int i = 0; i < 4; i++)
            {
                if (ar2[i] != ar1[i])
                {
                    checkeq = false;
                    break;
                }

                checkeq = true;
            }

            return checkeq;

        }
    }
}
