using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Namespaces
{
    public class SortedListClass
    {
        SortedList employeeList = new SortedList();

        // Adding employee records using the Add method
        public void AddToSortedList()
        {
            employeeList.Add(101, "John Doe");
            employeeList.Add(102, "Jane Smith");
            employeeList.Add(103, "Samuel Jackson");
            employeeList.Add(104, "Alice Johnson");
        }

        // Displaying all employees using the Keys and Values properties
        public void GetKeysValues()
        {
            Console.WriteLine("All employee IDs:");
            foreach (int key in employeeList.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("All employee names:");
            foreach (string value in employeeList.Values)
            {
                Console.WriteLine(value);
            }
        }

        // Cloning the hash table
        public void CloneSortedList()
        {
            SortedList copyEmployeeList = (SortedList)employeeList.Clone();
            foreach (var key in copyEmployeeList.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (var value in copyEmployeeList.Values)
            {
                Console.WriteLine(value);
            }
        }

        // Displaying the count of employee records using the Count property
        public void TotalEmployeeCount()
        {
            Console.WriteLine($"Total employees: {employeeList.Count}");
        }

        // Accessing an employee's name using the indexer
        public void AccessEmployeeName()
        {
            Console.WriteLine($"Employee with ID 101: {employeeList[101]}");
        }

        // Removing an employee record using the Remove method
        public void RemoveEmployee()
        {
            employeeList.Remove(104);
            Console.WriteLine($"Total employees after removal: {employeeList.Count}");
        }

        // Checking if a specific employee ID exists using the ContainsKey method
        public void CheckForExistingEmployeeUsingKey()
        {
            int specificEmployeeID = 102;
            Console.WriteLine($"Does employee ID {specificEmployeeID} exist? {employeeList.ContainsKey(specificEmployeeID)}");
        }

        // Checking if a specific employee name exists using the ContainsValue method
        public void CheckForExistingEmployeeUsingValue()
        {
            string specificEmployeeName = "Samuel Jackson";
            Console.WriteLine($"Does employee name '{specificEmployeeName}' exist? {employeeList.ContainsValue(specificEmployeeName)}");

        }

        // Accessing an employee's name by index using the GetByIndex method
        public void AccessEmployeeUsingGetByIndex()
        {
            int index = 0;
            Console.WriteLine($"Employee at index {index}: {employeeList.GetByIndex(index)}");
        }

        // Accessing an employee's ID by index using the GetKey method
        public void AccessEmployeeUsingGetKey()
        {
            int index = 0;
            Console.WriteLine($"Employee ID at index {index}: {employeeList.GetKey(index)}");
        }

        // Using the constructor that accepts an IDictionary to initialize the sorted list
        public void ConvertFromDictionaryToSortedList()
        {
            SortedList initialList = new SortedList
            {
                { 201, "Michael Brown" },
                { 202, "Jessica White" }
            };
            SortedList anotherList = new SortedList(initialList);
            Console.WriteLine("Employees in another sorted list initialized from an existing collection:");
            foreach (DictionaryEntry entry in anotherList)
            {
                Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
            }
        }

        // Using the constructor that accepts an initial capacity
        public void SetInitialCapacity()
        {
            SortedList capacityList = new SortedList(10);
            capacityList.Add(301, "Emily Davis");
            capacityList.Add(302, "David Wilson");
            Console.WriteLine($"Total employees in capacity list: {capacityList.Count}");
        }

        // Using the constructor that accepts an initial capacity and an IComparer
        public void SetInitialCapacityWithIComparer()
        {
            SortedList initialList = new SortedList
            {
                { 201, "Michael Brown" },
                { 202, "Jessica White" }
            };
            SortedList comparerList = new SortedList(initialList, Comparer.Default);
            comparerList.Add(401, "Laura Taylor");
            comparerList.Add(402, "James Anderson");
            Console.WriteLine($"Total employees in comparer list: {comparerList.Count}");
        }

        // Using the constructor that accepts an IDictionary and an IComparer
        public void SetInitialCapacityWithIDictionaryIComparer()
        {
            SortedList initialList = new SortedList
            {
                { 201, "Michael Brown" },
                { 202, "Jessica White" }
            };
            SortedList equalityComparerList = new SortedList(initialList, Comparer.Default);
            equalityComparerList.Add(203, "Chris Martin");
            Console.WriteLine("Employees in equality comparer list:");
            foreach (DictionaryEntry entry in equalityComparerList)
            {
                Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
            }
        }

        // Clearing all employee records using the Clear method
        public void ClearEmployeeList()
        {
            employeeList.Clear();
            Console.WriteLine($"Total employees after clearing: {employeeList.Count}");
        }
    }
}
