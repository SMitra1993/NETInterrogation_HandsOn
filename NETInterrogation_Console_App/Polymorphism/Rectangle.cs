using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Polymorphism
{
    public class Rectangle: Shape
    {
        private double length;
        private double width;
        private string name;

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }

        //    set
        //    {
        //        name = value;
        //    }
        //}


        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
            Name = "Square";
        }

        public override string Name 
        { 
            get { return name; }
            set { name = value; }
        }

        public override double Area()
        {
            return length * width;
        }
        public override double Area(string name)
        {
            Console.WriteLine(name);
            return length * width;
        }
    }
}
