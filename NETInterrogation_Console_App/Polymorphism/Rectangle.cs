using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Polymorphism
{
    public class Rectangle: Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area()
        {
            return length * width;
        }
    }
}
