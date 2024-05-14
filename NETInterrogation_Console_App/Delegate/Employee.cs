public delegate bool IsPromotable(Employee empl);
public delegate void SimpleOperation(int value);
public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public int Experience { get; set; }

    #region Simple Delegate
    List<Employee> empList = new List<Employee>();

    IsPromotable isPromotable = new IsPromotable(Promote);

    public static bool Promote(Employee emp)
    {
        if (emp.Experience >= 5)
        {
            return true;
        }
        else if (emp.Salary == 15000)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Promote()
    {
        Console.WriteLine("Simple Delegate");
        empList.Add(new Employee() { ID = 101, Name = "Souvik", Salary = 25000, Experience = 7 });
        empList.Add(new Employee() { ID = 101, Name = "Shreya", Salary = 15000, Experience = 3 });
        empList.Add(new Employee() { ID = 101, Name = "Shrestha", Salary = 10000, Experience = 2 });
        empList.Add(new Employee() { ID = 101, Name = "Suvendu", Salary = 50000, Experience = 9 });
        PromoteEmployee(empList, isPromotable);
    }

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach (Employee employee in employeeList)
        {
            if (IsEligibleToPromote(employee))
            {
                Console.WriteLine($"{employee.Name} promoted");
            }
        }
    }
    #endregion

    #region Multicasting Delegate
    public static void DoubleValue(int value)
    {
        Console.WriteLine($"Double of {value}: {value * 2}");
    }

    public static void TripleValue(int value)
    {
        Console.WriteLine($"Triple of {value}: {value * 3}");
    }

    SimpleOperation operations = null;

    public void InvokeOperation()
    {
        Console.WriteLine("Multicasting Delegate");
        operations += DoubleValue;
        operations += TripleValue;

        operations(5);
    }
    #endregion

    #region Prediate Delegate
    // Return a boolean value
    List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Emily", "Frank", "Grace" };

    Predicate<string> hasMoreThan5Characters = (string name) => name.Length > 5;

    public static void PrintList(List<string> list)
    {
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }

    public void VerifyCharacters()
    {
        Console.WriteLine("Predicate Delegate");
        List<string> filteredNames = names.FindAll(hasMoreThan5Characters);
        Console.WriteLine("\nNames with more than 5 characters:");
        PrintList(filteredNames);
    }
    #endregion

    #region Func Delegate
    // Last type parameter is return type
    Func<double, double> calculateArea = radius => Math.PI * Math.Pow(radius, 2);
    double radius = 5;
    public void CalculateArea()
    {
        Console.WriteLine("Func Delegate");
        double area = calculateArea(radius);
        Console.WriteLine($"Area of circle with radius {radius} = {area:F2}");
    }
    #endregion

    #region Action Delegate
    // No Returns
    Action<int, int> ArithmaticOperation = (a, b) => Console.WriteLine($"Sum: {a + b}; Difference: {a - b}; Product: {a * b}; Divide: {a / b}");

    public void Operation()
    {
        Console.WriteLine("Action Delegate");
        ArithmaticOperation(10, 3);
    }
    #endregion
}