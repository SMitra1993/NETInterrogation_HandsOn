using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Constructors
{
    public class ConstructorTypes
    {
        #region Default Constructor
        public string Make;
        public string Model;
        public int Year;
        public ConstructorTypes()
        {
            Make = "Ford";
            Model = "Ford Mustang";
            Year = 1964;
        }
        #endregion

        #region Private Constructor
        private static ConstructorTypes instance;
        private ConstructorTypes(string name)
        {
            Console.WriteLine($"Private instance created with: {name}");
        }

        public static ConstructorTypes GetInstance()
        {
            if (instance == null)
            {
                instance = new ConstructorTypes("Souvik");
            }
            return instance;
        }
        #endregion

        #region Parameterized Constructor
        public ConstructorTypes(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        #endregion

        #region Copy Constructor
        public ConstructorTypes(ConstructorTypes other)
        {
            Make = other.Make;
            Model = other.Model;
            Year = other.Year;
        }
        #endregion

        #region Static Constructor
        public static int Count;
        static ConstructorTypes()
        {
            Count = 100;
            Console.WriteLine("***Static constructor invoked.***");
        }
        #endregion
    }
}
