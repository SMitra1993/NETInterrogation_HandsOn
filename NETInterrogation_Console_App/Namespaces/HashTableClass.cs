using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Namespaces
{
    public class HashTableClass
    {
        Hashtable employeeTable = new Hashtable();

        // Adding employee records using the Add method
        public void AddToHashTable()
        {
            employeeTable.Add(101, "John Doe");
            employeeTable.Add(102, "Jane Smith");
            employeeTable.Add(103, "Samuel Jackson");
            employeeTable.Add(104, "Alice Johnson");
        }

        // Displaying the keys and values of Hash Table
        public void GetKeysValues()
        {
            Console.WriteLine("All employee IDs:");
            foreach (int key in employeeTable.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("All employee names:");
            foreach (string value in employeeTable.Values)
            {
                Console.WriteLine(value);
            }
        }

        // Cloning the hash table
        public void CloneHashTable()
        {
            Hashtable copyEmployeeTable = (Hashtable)employeeTable.Clone();
            foreach (var key in copyEmployeeTable.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (var value in copyEmployeeTable.Values)
            {
                Console.WriteLine(value);
            }
        }

        // Displaying the count of employee records using the Count property
        public void TotalEmployeeCount()
        {
            Console.WriteLine($"Total employees: {employeeTable.Count}");
        }

        // Accessing an employee's name using the indexer
        public void AccessEmployeeName()
        {
            Console.WriteLine($"Employee with ID 101: {employeeTable[101]}");
        }

        // Removing an employee record using the Remove method
        public void RemoveEmployee()
        {
            employeeTable.Remove(104);
            Console.WriteLine($"Total employees after removal: {employeeTable.Count}");
        }

        // Checking if a specific employee ID exists using the ContainsKey method
        public void CheckForExistingEmployeeUsingKey()
        {
            int specificEmployeeID = 102;
            Console.WriteLine($"Does employee ID {specificEmployeeID} exist? {employeeTable.ContainsKey(specificEmployeeID)}");
        }

        // Checking if a specific employee ID exists using the ContainsKey method
        public void CheckForExistingEmployeeUsingValue()
        {
            string specificEmployeeName = "Samuel Jackson";
            Console.WriteLine($"Does employee name '{specificEmployeeName}' exist? {employeeTable.ContainsValue(specificEmployeeName)}");
        }

        // Copying the hashtable to an array of DictionaryEntry objects using the CopyTo method
        public void ConvertFromHashTableToDictionary()
        {
            DictionaryEntry[] employeeArray = new DictionaryEntry[employeeTable.Count];
            employeeTable.CopyTo(employeeArray, 0);
            Console.WriteLine("Employees copied to an array:");
            foreach (var entry in employeeArray)
            {
                Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
            }
        }

        // Initializes a new instance of the Hashtable class that contains elements copied from the specified collection.
        public void ConvertFromDictionaryToHashTable()
        {
            Hashtable initialTable = new Hashtable
            {
                { 201, "Michael Brown" },
                { 202, "Jessica White" }
            };
            Hashtable anotherTable = new Hashtable(initialTable);
            Console.WriteLine("Employees in another hashtable initialized from an existing collection:");
            foreach (DictionaryEntry entry in anotherTable)
            {
                Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
            }
        }

        // Clearing all employee records using the Clear method
        public void ClearEmployeeList()
        {
            employeeTable.Clear();
            Console.WriteLine($"Total employees after clearing: {employeeTable.Count}");
        }

        // Using the constructor that accepts an initial capacity
        public void SetInitialCapacity()
        {
            Hashtable capacityTable = new Hashtable(10);
            capacityTable.Add(301, "Emily Davis");
            capacityTable.Add(302, "David Wilson");
            Console.WriteLine($"Total employees in capacity table: {capacityTable.Count}");
        }

        // Using the constructor that accepts an initial capacity and a load factor
        public void SetInitialCapacityWithLoadFactor()
        {
            Hashtable loadFactorTable = new Hashtable(10, 0.5f);
            loadFactorTable.Add(401, "Laura Taylor");
            loadFactorTable.Add(402, "James Anderson");
            Console.WriteLine($"Total employees in load factor table: {loadFactorTable.Count}");
        }

        // Using the constructor that accepts an IDictionary and an IEqualityComparer
        public void SetInitialCapacityWithIEqualityComparer()
        {
            Hashtable initialTable = new Hashtable
            {
                { 201, "Michael Brown" },
                { 202, "Jessica White" }
            };
            Hashtable equalityComparerTable = new Hashtable(initialTable, StringComparer.OrdinalIgnoreCase);
            equalityComparerTable.Add("203", "Chris Martin");
            Console.WriteLine("Employees in equality comparer table:");
            foreach (DictionaryEntry entry in equalityComparerTable)
            {
                Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
            }
        }

    }
}
