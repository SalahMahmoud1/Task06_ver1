using System;
using System.Collections.Generic;
using System.Text;

namespace Task06_ver1
{
    public class Doctor
    {
        //==============================Doctor Mode=============================
        public static void DoctorMode()
        {
            Console.WriteLine("please inter number of question");
            int NoOfQue = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < NoOfQue; i++)
            {
                Console.WriteLine("\n Select Question Type:");
                Console.WriteLine("1- True/False");
                Console.WriteLine("2- Choose One");
                Console.WriteLine("3- Multiple Choice");
                string QueType = Console.ReadLine();

                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine();
                Console.Write("Enter Marks: ");
                int degree = Convert.ToInt32((Console.ReadLine()));
                Console.WriteLine("Select Level:\n 1. Easy  \n 2. Medium  \n 3. Hard");
                Que_Level level = (Que_Level)(Convert.ToInt32(Console.ReadLine()) - 1);
                switch (QueType)
                {
                    case "1":
                        Console.WriteLine("Pls enter correct answer (true/false):- ");
                        bool answer = Convert.ToBoolean(Console.ReadLine());
                        //TrueFalseQue t1 = new TrueFalseQue(header, level, degree, answer);
                        All_Que_List.Exame.Add(new TrueFalseQue(header, level, degree, answer));
                        //l2.Add(t1);
                        //t1.Disply(); test
                        break;
                    case "2":
                        int CorrectAnswer = 0;
                        List<string> choise = new List<string>();
                        for (int j = 0; j < 4; j++)
                        {
                            Console.WriteLine("Enter Choise " + (j + 1) + ":");
                            choise.Add(Console.ReadLine());
                        }
                        Console.WriteLine("Enter Correct answer from 1 to 4 :  ");
                        CorrectAnswer = Convert.ToInt32(Console.ReadLine());
                        ChoseOneQuestion ChoseOne = new ChoseOneQuestion(header, level, degree, choise, CorrectAnswer);
                        All_Que_List.Exame.Add(ChoseOne);
                        break;
                    case "3":
                        string CorrectAnswer1 = "";
                        List<string> choise1 = new List<string>();
                        for (int j = 0; j < 4; j++)
                        {
                            Console.WriteLine("Enter Choise " + (j + 1) + ":");
                            choise1.Add(Console.ReadLine());
                        }
                        Console.WriteLine("Enter Correct answers with separate comma between choise  like that(1,2,3,4 ) :");
                        CorrectAnswer1 = Console.ReadLine();
                        MultipleChoiseQuestion ChoseOne1 = new MultipleChoiseQuestion(header, level, degree, choise1, CorrectAnswer1);
                        All_Que_List.Exame.Add(ChoseOne1);
                        break;
                }

            }
        }
    }
}
