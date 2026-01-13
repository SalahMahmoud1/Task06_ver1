using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace SearchTaskVer1
{
    
    class Shape
    {

        // internal protected: accessible in derived classes or same Project
        internal protected double Area;

        // private protected: accessible only in derived classes
        private protected string ShapeName;

        public Shape(string name)
        {
            ShapeName = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Shape: {ShapeName}, Area: {Area}");
        }

    }
}
