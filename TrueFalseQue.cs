using System;
using System.Collections.Generic;
using System.Text;

namespace Task06_ver1
{
    public class TrueFalseQue:Question
    {
        public TrueFalseQue(string Header, Que_Level QueLevel, int QuesDegree, bool correctAns):base(Header, QueLevel, QuesDegree)
        {
            CorrectAns = correctAns;
        }

        public bool CorrectAns {  get; set; }
        public override void Disply()
        {
            Console.WriteLine(Header + "  Ques Degree = " + QuesDegree);
            Console.WriteLine("1- True");
            Console.WriteLine("2- False");

        }
        public override bool CheckAnswer(string ChAnswer)
        {
            return (ChAnswer=="1" && CorrectAns)||(ChAnswer=="2" && !CorrectAns);
        }

    }
}
