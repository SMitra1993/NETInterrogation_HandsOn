using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NETInterrogation_Console_App.Inheritance
{
    public class Rectangle: Feature
    {
        public double Length {  get; set; }
        public double Width { get; set; }

        public Rectangle(string name, double length, double width): base(name)
        {
            Length = length;
            Width = width;
        }

        public override void GetName()
        {
            if (Length == Width)
            {
                Name = "Square";
            }
            base.GetName();
        }

        public override void GetArea()
        {
            base.GetArea();
            Console.WriteLine($"Area: {Length * Width}");
        }

        public override void GetPerimeter()
        {
            base.GetPerimeter();
            Console.WriteLine($"Perimeter: {2 * (Length + Width)}");
        }
    }
}
