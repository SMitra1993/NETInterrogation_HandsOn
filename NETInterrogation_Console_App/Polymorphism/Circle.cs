using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Polymorphism
{
    public class Circle : Shape
    {
        private double radius;
        private string name;

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Circle(double radius)
        {
            this.radius = radius;
            Name = "Circle";
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        public override double Area(string name)
        {
            Console.WriteLine(name);
            return Math.PI * radius * radius;
        }
    }
}
