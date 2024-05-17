using NETInterrogation_Console_App.Abstraction;
using NETInterrogation_Console_App.Constructors;
using NETInterrogation_Console_App.Encapsulation;
using NETInterrogation_Console_App.Inheritance;
using NETInterrogation_Console_App.Namespaces;
using NETInterrogation_Console_App.Shallow_Deep_Copy;
using NETInterrogation_Console_App.Static_Class;
using System.Drawing;

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
            //                Inheritance.Circle circle1 = new Inheritance.Circle("Circle", result);
            //                circle1.GetName();
            //                circle1.GetArea();
            //                circle1.GetCircumference();
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
            //                Inheritance.Rectangle rectangle1 = new Inheritance.Rectangle("Reactangle", result1, result2);
            //                rectangle1.GetName();
            //                rectangle1.GetArea();
            //                rectangle1.GetPerimeter();
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
            //                Inheritance.Rectangle rectangle2 = new Inheritance.Rectangle("Square", result3, result3);
            //                rectangle2.GetName();
            //                rectangle2.GetArea();
            //                rectangle2.GetPerimeter();
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

            #region Abstraction
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

            #region Constructors
            //Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            //Console.WriteLine("Default Constructor");
            //ConstructorTypes types = new ConstructorTypes();
            //Console.WriteLine($"Car: {types.Year} {types.Make} {types.Model}");
            //Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            //Console.WriteLine("Parameterized Constructor");
            //ConstructorTypes car = new ConstructorTypes("Toyota", "Camry", 2020);
            //Console.WriteLine($"Car: {car.Year} {car.Make} {car.Model}");
            //Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            //Console.WriteLine("Copied Constructor");
            //ConstructorTypes copiedCar = new ConstructorTypes(car);
            //Console.WriteLine($"Copied Car: {copiedCar.Year} {copiedCar.Make} {copiedCar.Model}");
            //Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            //Console.WriteLine("Private Constructor");
            //ConstructorTypes.GetInstance();
            //Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            //Console.WriteLine("Static Constructor");
            //Console.WriteLine($"Count: {ConstructorTypes.Count}");
            //Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            //Console.WriteLine("Constructor Overloading");
            //ConstructorTypes area1 = new ConstructorTypes(7,8);
            //Console.WriteLine($"Area 1: {area1.CalculateArea()}");
            //ConstructorTypes area2 = new ConstructorTypes(8);
            //Console.WriteLine($"Area 2: {area2.CalculateArea()}; Width: {area2.Width}; Height: {area2.Height}");
            //Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            #endregion

            #region Structure
            //Console.WriteLine("Adding non-static method to Struct");

            //Structure.Point1 point1 = new Structure.Point1(10, 7);

            //// Not recommended as Structs are considered immutable
            //// p1.x = 10;
            //// p1.y = 7;

            //Structure.Point1 point2 = new Structure.Point1(6, 8);

            //// Display the coordinates of the points
            //Console.WriteLine($"Point 1: ({point1.x}, {point1.y})");
            //Console.WriteLine($"Point 2: ({point2.x}, {point2.y})");

            //// Calculate and display the distance between the points
            //double distance1 = point1.DistanceTo(point2);
            //Console.WriteLine($"Distance between the points: {Math.Round(distance1, 2)}");


            /////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("///////////////////////////////////////////////////////////////////////////////");
            //Console.WriteLine("Adding static method to Struct");

            //Structure.Point2 point3 = new Structure.Point2 { x = 10, y = 7 };

            //Structure.Point2 point4 = new Structure.Point2 { x = 6, y = 8 };

            //// Display the coordinates of the points
            //Console.WriteLine($"Point 1: ({point3.x}, {point3.y})");
            //Console.WriteLine($"Point 2: ({point4.x}, {point4.y})");

            //// Calculate and display the distance between the points
            //double distance2 = Structure.Point2.DistanceTo(point3, point4);
            //Console.WriteLine($"Distance between the points: {Math.Round(distance2, 2)}");
            #endregion

            #region Stack
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("**************Stack**************");
            Console.WriteLine("*********************************");
            StackClass stack = new StackClass();
            stack.AddToStack();
            Console.WriteLine("*********************************");
            stack.TotalStackCount();
            Console.WriteLine("*********************************");
            stack.PeekIntoStack();
            Console.WriteLine("*********************************");
            stack.PopOutTask();
            Console.WriteLine("*********************************");
            stack.CheckForExistingTask();
            Console.WriteLine("*********************************");
            stack.ConvertFromStackToArray();
            Console.WriteLine("*********************************");
            stack.ConvertFromArrayToStack();
            Console.WriteLine("*********************************");
            stack.ClearStack();
            Console.WriteLine("*********************************");
            #endregion

            #region Queue
            Console.WriteLine("*********************************");
            Console.WriteLine("**************Queue**************");
            Console.WriteLine("*********************************");
            QueueClass queue = new QueueClass();
            queue.AddToQueue();
            Console.WriteLine("*********************************");
            queue.TotalQueueCount();
            Console.WriteLine("*********************************");
            queue.PeekIntoQueue();
            Console.WriteLine("*********************************");
            queue.PopOutCustomer();
            Console.WriteLine("*********************************");
            queue.CheckForExistingCustomer();
            Console.WriteLine("*********************************");
            queue.ConvertFromQueueToArray();
            Console.WriteLine("*********************************");
            queue.ConvertFromArrayToQueue();
            Console.WriteLine("*********************************");
            queue.ClearQueue();
            Console.WriteLine("*********************************");
            #endregion

            #region HashTable
            Console.WriteLine("*********************************");
            Console.WriteLine("************Hash Table***********");
            Console.WriteLine("*********************************");
            HashTableClass hashTable = new HashTableClass();
            hashTable.AddToHashTable();
            Console.WriteLine("*********************************");
            hashTable.GetKeysValues();
            Console.WriteLine("*********************************");
            hashTable.CloneHashTable();
            Console.WriteLine("*********************************");
            hashTable.TotalEmployeeCount();
            Console.WriteLine("*********************************");
            hashTable.AccessEmployeeName();
            Console.WriteLine("*********************************");
            hashTable.RemoveEmployee();
            Console.WriteLine("*********************************");
            hashTable.CheckForExistingEmployeeUsingKey();
            Console.WriteLine("*********************************");
            hashTable.CheckForExistingEmployeeUsingValue();
            Console.WriteLine("*********************************");
            hashTable.ConvertFromHashTableToDictionary();
            Console.WriteLine("*********************************");
            hashTable.ConvertFromDictionaryToHashTable();
            Console.WriteLine("*********************************");
            hashTable.ClearEmployeeList();
            Console.WriteLine("*********************************");
            hashTable.SetInitialCapacity();
            Console.WriteLine("*********************************");
            hashTable.SetInitialCapacityWithLoadFactor();
            Console.WriteLine("*********************************");
            hashTable.SetInitialCapacityWithIEqualityComparer();
            Console.WriteLine("*********************************");
            #endregion

            #region SortedList
            Console.WriteLine("*********************************");
            Console.WriteLine("**********Sorted List************");
            Console.WriteLine("*********************************");
            SortedListClass sortedList = new SortedListClass();
            sortedList.AddToSortedList();
            Console.WriteLine("*********************************");
            sortedList.GetKeysValues();
            Console.WriteLine("*********************************");
            sortedList.CloneSortedList();
            Console.WriteLine("*********************************");
            sortedList.TotalEmployeeCount();
            Console.WriteLine("*********************************");
            sortedList.AccessEmployeeName();
            Console.WriteLine("*********************************");
            sortedList.RemoveEmployee();
            Console.WriteLine("*********************************");
            sortedList.CheckForExistingEmployeeUsingKey();
            Console.WriteLine("*********************************");
            sortedList.CheckForExistingEmployeeUsingValue();
            Console.WriteLine("*********************************");
            sortedList.AccessEmployeeUsingGetByIndex();
            Console.WriteLine("*********************************");
            sortedList.AccessEmployeeUsingGetKey();
            Console.WriteLine("*********************************");
            sortedList.ConvertFromDictionaryToSortedList();
            Console.WriteLine("*********************************");
            sortedList.SetInitialCapacity();
            Console.WriteLine("*********************************");
            sortedList.SetInitialCapacityWithIComparer();
            Console.WriteLine("*********************************");
            sortedList.SetInitialCapacityWithIDictionaryIComparer();
            Console.WriteLine("*********************************");
            sortedList.ClearEmployeeList();
            Console.WriteLine("*********************************");
            #endregion
        }



    }
}