using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_oop_4
{
    internal class circle : Icircle
    {
        public double Radius { get; set; }

        public double Area => 3.14 * Radius * Radius;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with radius {Radius}:");
            Console.WriteLine($"Area: {Area}");
        }
    }
}
