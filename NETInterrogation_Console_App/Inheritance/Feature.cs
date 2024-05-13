using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Inheritance
{
    // Base Class
    public class Feature: IFeatureA, IFeatureB
    {
        // properties
        private string? name;

        public string Name
        {
            get { return name ?? "null"; } 
            set
            {
                name = value;
            } 
        }
        public Feature(string name) 
        {
            Name = name;
        }

        public virtual void GetName()
        {
            Console.WriteLine($"Name of Shape: {Name}");
        }

        public virtual void GetArea()
        {
            Console.WriteLine($"Area of {Name}:");
        }
        public virtual void GetPerimeter()
        {
            Console.WriteLine($"Perimeter of {Name}:");
        }
        public virtual void GetCircumference()
        {
            Console.WriteLine($"Circumference of {Name}:");
        }

    }
}
