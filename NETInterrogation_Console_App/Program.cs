using NETInterrogation_Console_App.Abstraction;
using NETInterrogation_Console_App.Encapsulation;
using NETInterrogation_Console_App.Inheritance;
using NETInterrogation_Console_App.Shallow_Deep_Copy;
using NETInterrogation_Console_App.Static_Class;

namespace NETInterrogation_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Uncomment each region to run the program
             * **/
            Console.WriteLine("Uncomment each region to run the program");
            #region Inheritance
            //Console.WriteLine("Enter the type of shape you want to calculate:");
            //string Name = Console.ReadLine();

            //if (!String.IsNullOrEmpty(Name))
            //{
            //    switch (Name)
            //    {
            //        case "Circle":
            //            Console.WriteLine($"Enter the radius of the {Name}:");
            //            string Radius = Console.ReadLine();
            //            if (double.TryParse(Radius, out double result))
            //            {
            //                Inheritance.Circle circle = new Inheritance.Circle("Circle", result);
            //                circle.GetName();
            //                circle.GetArea();
            //                circle.GetCircumference();
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid input");
            //            }
            //            return;
            //        case "Rectangle":
            //            Console.WriteLine($"Enter the length of the {Name}:");
            //            string Length = Console.ReadLine();
            //            Console.WriteLine($"Enter the width of the {Name}:");
            //            string Width = Console.ReadLine();
            //            if (double.TryParse(Length, out double result1) && double.TryParse(Width, out double result2))
            //            {
            //                Inheritance.Rectangle rectangle = new Inheritance.Rectangle("Reactangle", result1, result2);
            //                rectangle.GetName();
            //                rectangle.GetArea();
            //                rectangle.GetPerimeter();
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid input");
            //            }
            //            return;
            //        case "Square":
            //            Console.WriteLine($"Enter the length of the {Name}:");
            //            string Length1 = Console.ReadLine();
            //            if (double.TryParse(Length1, out double result3))
            //            {
            //                Inheritance.Rectangle rectangle = new Inheritance.Rectangle("Square", result3, result3);
            //                rectangle.GetName();
            //                rectangle.GetArea();
            //                rectangle.GetPerimeter();
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid input");
            //            }
            //            return;
            //        default:
            //            Console.WriteLine("Invalid shape");
            //            break;
            //    }
            //}
            #endregion

            #region Encapsulation
            //Console.WriteLine("Welcome to the Bank!");
            //Console.WriteLine("Enter your account number:");
            //string AccountNumber = Console.ReadLine();
            //Console.WriteLine("Enter your initial balance:");
            //string balance = Console.ReadLine();
            //string choice = "";
            //while (choice.ToLower() != "exit")
            //{
            //    if (!String.IsNullOrEmpty(AccountNumber) && double.TryParse(balance, out double balncedAmount))
            //    {
            //        Console.WriteLine("\nChoose an option:");
            //        Console.WriteLine("1. Deposit");
            //        Console.WriteLine("2. Withdraw");
            //        Console.WriteLine("3. Display Balance");
            //        Console.WriteLine("Type 'exit' to Exit");

            //        Console.Write("Enter your choice: ");
            //        choice = Console.ReadLine();

            //        BankAccount account = new BankAccount(AccountNumber, balncedAmount);

            //        switch (choice)
            //        {
            //            case "Deposit":
            //                Console.WriteLine($"Please deposit here for account {account.AccountNumber}:");
            //                string deposit = Console.ReadLine();
            //                if (double.TryParse(deposit, out double depositedAmount))
            //                {
            //                    account.Deposit(depositedAmount);
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid choice! Please try again.");
            //                }
            //                break;
            //            case "Withdraw":
            //                Console.WriteLine($"Please withdraw here for account {account.AccountNumber}:");
            //                string withdraw = Console.ReadLine();
            //                if (double.TryParse(withdraw, out double withdrawalAmount))
            //                {
            //                    account.Withdraw(withdrawalAmount);
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid choice! Please try again.");
            //                }
            //                break;
            //            case "Display Balance":
            //                account.CheckBalance();
            //                break;
            //            case "exit":
            //                Console.WriteLine("Exiting...See you next time!");
            //                break;
            //            default:
            //                Console.WriteLine("Invalid choice! Please try again.");
            //                break;
            //        }

            //    }
            //}
            #endregion

            #region Encapsulation
            //Shape circle = new Abstraction.Circle(5);
            //Shape rectangle = new Abstraction.Rectangle(5, 7);

            //Console.WriteLine($"Circle - Area: ${circle.CalculateArea()}, Circumference: {circle.CalculatePerimeter()} ");
            //Console.WriteLine($"Rectangle - Area: ${rectangle.CalculateArea()}, Perimeter: {rectangle.CalculatePerimeter()} ");
            #endregion

            #region Polymorphism
            //Polymorphism.Shape[] shapes = new Polymorphism.Shape[2];

            //shapes[0] = new Polymorphism.Rectangle(5, 7);
            //shapes[1] = new Polymorphism.Circle(5);

            //foreach (Polymorphism.Shape shape in shapes)
            //{
            //    Console.WriteLine($"Area: {shape.Area()}");
            //    Console.WriteLine($"Area: {shape.Area(shape.Name)}");
            //}
            #endregion

            #region Static Class
            //Console.WriteLine("Area Calculator");

            //Console.WriteLine("Circle:");
            //Console.Write("Enter radius: ");
            //double radius = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Area of circle with radius {radius} = {Geometry.CalculateCircleArea(radius)}");

            //Console.WriteLine("Rectangle:");
            //Console.Write("Enter length: ");
            //double length = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter width: ");
            //double width = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Area of rectangle with length {length} and width {width} = {Geometry.CalculateRectangleArea(length, width)}");

            //Console.WriteLine("Triangle:");
            //Console.Write("Enter base length: ");
            //double baseLength = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter height: ");
            //double height = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Area of triangle with base length {baseLength} and height {height} = {Geometry.CalculateTriangleArea(baseLength, height)}");
            #endregion

            #region Shallow-Deep Copy
            //// Create a person
            //Person originalPerson = new Person("Souvik", 30);
            //// Shallow copy
            //Person shallowCopy = originalPerson.ShallowCopy();

            //// Deep copy
            //Person deepCopy = originalPerson.DeepCopy();

            //// Modify originalPerson
            //deepCopy.Name = "Shreya";
            //deepCopy.Age = 25;

            //// Output
            //Console.WriteLine("Original Person:");
            //Console.WriteLine($"Name: {originalPerson.Name}, Age: {originalPerson.Age}");

            //Console.WriteLine("Shallow Copy:");
            //Console.WriteLine($"Name: {shallowCopy.Name}, Age: {shallowCopy.Age}");

            //Console.WriteLine("Deep Copy:");
            //Console.WriteLine($"Name: {deepCopy.Name}, Age: {deepCopy.Age}");
            #endregion

            #region Delegate
            //Employee emp = new Employee();

            //// Simple Delegate
            //emp.Promote();
            //Console.WriteLine("//////////////////////////////////////////////////////////////");
            //// Multicasting Delegate
            //emp.InvokeOperation();
            //Console.WriteLine("//////////////////////////////////////////////////////////////");
            //// Predicate Delegate
            //emp.VerifyCharacters();
            //Console.WriteLine("//////////////////////////////////////////////////////////////");
            //// Func Delegate
            //emp.CalculateArea();
            //Console.WriteLine("//////////////////////////////////////////////////////////////");
            //// Action Delegate
            //emp.Operation();
            #endregion
        }


    }
}