using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;

namespace Task06_ver1
{
    public enum Que_Level
    {
        Easy,Medium,Hard
    }
    //static List<Question> l1 = new List<Question>();
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
                        Doctor.DoctorMode();
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
            
            
        }
    }
}
