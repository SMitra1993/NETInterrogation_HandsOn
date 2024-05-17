using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Namespaces
{
    public class HashSetClass
    {
        // Using the default constructor to create an empty HashSet
        HashSet<int> employeeIDs = new HashSet<int>();

        // Adding employee IDs using the Add method
        public void AddToHashSet()
        {
            employeeIDs.Add(101);
            employeeIDs.Add(102);
            employeeIDs.Add(103);
            employeeIDs.Add(104);
        }

        // Displaying the count of employee IDs using the Count property
        public void TotalEmployeeCount()
        {
            Console.WriteLine($"Total employee IDs: {employeeIDs.Count}");
        }

        // Removing an employee ID using the Remove method
        public void RemoveEmployee()
        {
            employeeIDs.Remove(104);
            Console.WriteLine($"Total employee IDs after removal: {employeeIDs.Count}");
        }

        // Checking if a specific employee ID exists using the Contains method
        public void AccessEmployeeName()
        {
            int specificEmployeeID = 102;
            Console.WriteLine($"Does employee ID {specificEmployeeID} exist? {employeeIDs.Contains(specificEmployeeID)}");
        }

        // Displaying all employee IDs using the GetEnumerator method
        public void DisplayEmployeesUsingGetEnumerator()
        {
            Console.WriteLine("All employee IDs:");
            foreach (int id in employeeIDs)
            {
                Console.WriteLine(id);
            }
        }

        // Using the constructor that accepts an IEnumerable to initialize the HashSet
        public void InitializeHashSetUsingIEnumerable()
        {
            List<int> initialIDs = new List<int> { 201, 202 };
            HashSet<int> anotherSet = new HashSet<int>(initialIDs);
            Console.WriteLine("Employee IDs in another HashSet initialized from an existing collection:");
            foreach (int id in anotherSet)
            {
                Console.WriteLine(id);
            }
        }

        // Using the constructor that accepts an IEqualityComparer
        public void InitializeHashSetUsingIEqualityComparer()
        {
            HashSet<int> comparerSet = new HashSet<int>(EqualityComparer<int>.Default);
            comparerSet.Add(301);
            comparerSet.Add(302);
            Console.WriteLine($"Total employee IDs in comparer set: {comparerSet.Count}");
        }

        // Using the constructor that accepts an IEnumerable and an IEqualityComparer
        public void InitializeHashSetUsingIEqualityComparerIEnumerable()
        {
            List<int> initialIDs = new List<int> { 201, 202 };
            HashSet<int> equalityComparerSet = new HashSet<int>(initialIDs, EqualityComparer<int>.Default);
            equalityComparerSet.Add(203);
            Console.WriteLine("Employee IDs in equality comparer set:");
            foreach (int id in equalityComparerSet)
            {
                Console.WriteLine(id);
            }
        }

        // Using the UnionWith method to add multiple employee IDs
        public void AddEmployeesUsingUnionWith()
        {
            int[] newIDs = { 301, 302, 303 };
            employeeIDs.UnionWith(newIDs);
            Console.WriteLine("Employee IDs after UnionWith:");
            foreach (int id in employeeIDs)
            {
                Console.WriteLine(id);
            }
        }
    }
}
