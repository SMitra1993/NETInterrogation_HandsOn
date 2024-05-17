using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Namespaces
{
    public class SortedSetClass
    {
        // Using the default constructor to create an empty SortedSet
        SortedSet<string> students = new SortedSet<string>();

        // Adding students using Add method
        public void AddToList()
        {
            students.Add("John Doe");
            students.Add("Jane Smith");
            students.Add("Mike Johnson");
        }

        // Displaying the count of students using the Count property
        public void TotalStudentCount()
        {
            Console.WriteLine($"Total students: {students.Count}");
        }

        // Adding a student that already exists to see if duplicates are allowed
        public void AddStudent()
        {
            bool added = students.Add("John Doe");
            Console.WriteLine($"Added duplicate student: {added}");
        }

        // Checking if a student exists using the Contains method
        public void CheckIfStudentExist()
        {
            bool exists = students.Contains("Jane Smith");
            Console.WriteLine($"Jane Smith exists: {exists}");
        }

        // Removing a specific student using the Remove method
        public void RemoveStudent()
        {
            students.Remove("Jane Smith");
            Console.WriteLine("Students after removal:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        // Using the constructor that accepts an IEnumerable to initialize the SortedSet
        public void InitializeSortedSet()
        {
            List<string> initialStudents = new List<string> { "Sam Brown", "Emma Watson" };
            SortedSet<string> anotherSet = new SortedSet<string>(initialStudents);
            Console.WriteLine("Students in another SortedSet initialized from an existing collection:");
            foreach (var student in anotherSet)
            {
                Console.WriteLine(student);
            }
        }

        // UnionWith method to combine two sets
        public void CombineStudentSets()
        {
            List<string> initialStudents = new List<string> { "Sam Brown", "Emma Watson" };
            SortedSet<string> anotherSet = new SortedSet<string>(initialStudents);
            students.UnionWith(anotherSet);
            Console.WriteLine("Students after UnionWith operation:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        // IntersectWith method to find common elements
        public void FindCommonElementsFromMultipleSets()
        {
            List<string> initialStudents = new List<string> { "Sam Brown", "Emma Watson" };
            SortedSet<string> commonStudents = new SortedSet<string>(initialStudents);
            commonStudents.IntersectWith(students);
            Console.WriteLine("Common students after IntersectWith operation:");
            foreach (var student in commonStudents)
            {
                Console.WriteLine(student);
            }
        }

        // Clearing all students using the Clear method
        public void ClearStudent()
        {
            students.Clear();
            Console.WriteLine($"Total students after clearing: {students.Count}");
        }
    }
}
