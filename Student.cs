using System;
using System.Collections.Generic;
using System.Text;

namespace Task06_ver1
{
    public class Student
    {
        public static void StudentMode()
        {
            Console.WriteLine("Choose Exam Type 1- Practical\n 2- Final");
            string ExamType = Console.ReadLine();
            Console.WriteLine("Choose Exam level \n 1- Easy \n 2- Medium \n 3- Hard");
            Que_Level Level = (Que_Level)(Convert.ToInt32(Console.ReadLine()) - 1);
            var exam = new List<Question>();
            for (int i = 0; i < All_Que_List.Exame.Count; i++)
            {
                if (All_Que_List.Exame[i].QueLevel == Level)
                {
                    exam.Add(All_Que_List.Exame[i]);
                }
            }
            int MaxExameDegree = 0;
            int StdGetDegree = 0;
            int j = 0;
            while (j < exam.Count)
            {
                MaxExameDegree += exam[j].QuesDegree; // all que final Degree
                exam[j].Disply();
                Console.WriteLine("Insert your Answer :\n");
                string StdAnswer = Console.ReadLine();
                if (exam[j].CheckAnswer(StdAnswer))
                {
                    StdGetDegree += exam[j].QuesDegree;
                }
                if (ExamType == "1")
                    j += 2;
                else
                    j++;
            }

            Console.WriteLine("\nYour Result = " + StdGetDegree + "  /   " + MaxExameDegree);
        }
    }
}
