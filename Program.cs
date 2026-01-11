using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;

namespace Task06_ver1
{
    public enum Que_Level
    {
        Easy,Medium,Hard
    }
    //static List<Question> l1 = new List<Question>();
    //public class All_Que
    //{
    //    public static List<Question> l3 = new List<Question>();
    //}
    internal class Program
    {
        static List<Question> l2 = new List<Question>();
        static void Main(string[] args)
        {
            //static List<Question> l1 = n\ ew List<Question>(); wrog
            while (true)
            {
                Console.WriteLine("      Examination System              ");
                Console.WriteLine("1- Doctor Mode");
                Console.WriteLine("2- Student Mode");
                Console.WriteLine("3- Exite");
                Console.WriteLine("Choose Option Mode :-");
                string SelctedMode = Console.ReadLine();
                switch (SelctedMode)
                {
                    case "1":
                        DoctorMode();
                        break;
                    case "2":
                        StudentMode();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Wrong Selectin Please choose Correct Selection from 1 to 3 ");
                        break;
                }
            }
            //==============================Doctor Mode=============================
            static void DoctorMode()
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
                            bool answer =Convert.ToBoolean(Console.ReadLine());
                            //TrueFalseQue t1 = new TrueFalseQue(header, level, degree, answer);
                            l2.Add(new TrueFalseQue(header,level, degree,answer));
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
                            ChoseOneQuestion ChoseOne = new ChoseOneQuestion (header,level,degree,choise,CorrectAnswer);
                            l2.Add (ChoseOne);
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
                            l2.Add(ChoseOne1);
                            break;
                    }

                }
            }
            static void StudentMode()
            {
                Console.WriteLine("Choose Exam Type 1- Practical\n 2- Final");
                string ExamType = Console.ReadLine();
                Console.WriteLine("Choose Exam level \n 1- Easy \n 2- Medium \n 3- Hard");
                Que_Level Level = (Que_Level)(Convert.ToInt32(Console.ReadLine())-1);
                var exam = new List<Question>();
                for (int i = 0;i<l2.Count;i++)
                {
                    if (l2[i].QueLevel==Level)
                    {
                        exam.Add(l2[i]);
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

                Console.WriteLine("\nYour Result = " + StdGetDegree + "  /   " +MaxExameDegree );
            }
        }
    }
}
