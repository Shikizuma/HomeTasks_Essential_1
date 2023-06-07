using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks_Essential_1
{
    internal class Rectangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public double Area { get; }
        public double Perimeter { get; }

        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB; 
        }

        public double AreaCalculator()
        {       
            return SideA * SideB;
        }

        public double PerimeterCalculator()
        {
            return 2 * (SideA + SideB);
        }

    }
}
