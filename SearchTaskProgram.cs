using static System.Net.Mime.MediaTypeNames;

namespace SearchTaskVer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese insert circle radius");
            Circle c1 = new Circle(Convert.ToDouble(Console.ReadLine()), "circile");
            c1.ShowDetails();
            Test T1 = new Test();
            T1.TestPrivatProtected_InternalProtected();
        }
    }
}
