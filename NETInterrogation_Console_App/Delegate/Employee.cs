public delegate bool IsPromotable(Employee empl);

public class Employee 
{

    public int ID { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public int Experience { get; set; }

    List<Employee> empList = new List<Employee>();


    IsPromotable isPromotable = new IsPromotable(Promote);
    
    public static bool Promote(Employee emp)
    {
        if(emp.Experience >= 5) {
            return true;
        }
        else if(emp.Salary == 15000) {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Promote() {
        empList.Add(new Employee() { ID = 101, Name = "Souvik", Salary = 25000, Experience = 7 });
        empList.Add(new Employee() { ID = 101, Name = "Shreya", Salary = 15000, Experience = 3 });
        empList.Add(new Employee() { ID = 101, Name = "Shrestha", Salary = 10000, Experience = 2 });
        empList.Add(new Employee() { ID = 101, Name = "Suvendu", Salary = 50000, Experience = 9 });
        PromoteEmployee(empList, isPromotable);
    }

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote) 
    {
        foreach(Employee employee in employeeList)
        {
            if(IsEligibleToPromote(employee))
            {
                Console.WriteLine($"{employee.Name} promoted");
            }
        }
    }
}