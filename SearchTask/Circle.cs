using System;
using System.Collections.Generic;
using System.Text;

namespace SearchTaskVer1
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double r, string shname) : base(shname)
        {
            radius = r;
            Area = Math.PI * radius * radius; //  internal protected
            ShapeName = "Circle (Updated)";   //  private protected
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Circle radius: {radius}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Name: {ShapeName}");
        }
    }
}
