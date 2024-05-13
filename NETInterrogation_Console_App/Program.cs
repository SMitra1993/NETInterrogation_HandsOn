using NETInterrogation_Console_App.Encapsulation;
using NETInterrogation_Console_App.Inheritance;

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

            //if (Name != null)
            //{
            //    switch (Name)
            //    {
            //        case "Circle":
            //            Console.WriteLine($"Enter the radius of the {Name}:");
            //            string Radius = Console.ReadLine();
            //            if (double.TryParse(Radius, out double result))
            //            {
            //                Circle circle = new Circle("Circle", result);
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
            //                Rectangle rectangle = new Rectangle("Reactangle", result1, result2);
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
            //                Rectangle rectangle = new Rectangle("Square", result3, result3);
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
            //    if (AccountNumber != null && double.TryParse(balance, out double balncedAmount))
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
        }
    }
}