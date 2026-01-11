using System;
using System.Collections.Generic;
using System.Text;

namespace Task06_ver1
{
    public abstract class Question
    {
        public string Header { get; set; }
        public Que_Level QueLevel { get; set; }
        public int QuesDegree { get; set; }
        protected Question(string header, Que_Level queLevel, int quesDegree)
        {
            Header = header;
            QueLevel = queLevel;
            QuesDegree = quesDegree;
        }
        public abstract void Disply();
        public abstract bool CheckAnswer(string AnswerToCheck);
    }
}
