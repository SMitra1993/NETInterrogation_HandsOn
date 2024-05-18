using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Namespaces
{
    public class DictionaryClass
    {
        // Using the default constructor to create an empty SortedSet
        Dictionary<string, double> studentGrades = new Dictionary<string, double>();

        // Adding students and their grades using Add method
        public void AddToDictionary()
        {
            studentGrades.Add("John Doe", 85.5);
            studentGrades.Add("Jane Smith", 92.3);
            studentGrades.Add("Mike Johnson", 76.8);
        }

        // Displaying the count of students using the Count property
        public void TotalStudentCount()
        {
            Console.WriteLine($"Total students: {studentGrades.Count}");
        }

        // Checking if a student exists using the ContainsKey method
        public void CheckIfStudentExist()
        {
            bool exists = studentGrades.ContainsKey("Jane Smith");
            Console.WriteLine($"Jane Smith exists: {exists}");
        }

        // Getting the grade of a specific student using the indexer
        public void GetGradesOfStudent()
        {
            if (studentGrades.TryGetValue("John Doe", out double grade))
            {
                Console.WriteLine($"John Doe's grade: {grade}");
            }
        }

        // Updating a student's grade using the indexer
        public void UpdateGradeOfStudent()
        {
            studentGrades["Mike Johnson"] = 79.5;
            Console.WriteLine($"Mike Johnson's updated grade: {studentGrades["Mike Johnson"]}");
        }

        // Removing a student using the Remove method
        public void RemoveStudent()
        {
            studentGrades.Remove("Jane Smith");
            Console.WriteLine("Students after removal:");
            foreach (var student in studentGrades)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }
        }

        // Using the constructor that accepts an IDictionary to initialize the Dictionary
        public void InitializeDictionary()
        {
            Dictionary<string, double> initialGrades = new Dictionary<string, double>
            {
                { "Sam Brown", 88.2 },
                { "Emma Watson", 91.4 }
            };
            Dictionary<string, double> anotherDictionary = new Dictionary<string, double>(initialGrades);
            Console.WriteLine("Students in another Dictionary initialized from an existing collection:");
            foreach (var student in anotherDictionary)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }
        }

        // Using the Keys and Values properties
        public void GetKeysAndValues()
        {
            Console.WriteLine("Keys (student names):");
            foreach (var key in studentGrades.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("Values (grades):");
            foreach (var value in studentGrades.Values)
            {
                Console.WriteLine(value);
            }
        }

        // Clearing all students using the Clear method
        public void ClearStudent()
        {
            studentGrades.Clear();
            Console.WriteLine($"Total students after clearing: {studentGrades.Count}");
        }
    }
}
