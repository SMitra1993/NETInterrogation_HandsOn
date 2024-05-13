using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Abstraction
{
    public class Circle : Shape
    {
        private double _radius;
        public Circle(double radius) 
        {
            _radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }
}
