using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Namespaces
{
    public class ListClass
    {
        // Using the default constructor to create an empty List
        List<string> students = new List<string>();

        // Adding students using Add method
        public void AddToList()
        {
            students.Add("Student 1: John Doe");
            students.Add("Student 2: Jane Smith");
            students.Add("Student 3: Mike Johnson");
        }

        // Displaying the count of students using the Count property
        public void TotalStudentCount()
        {
            Console.WriteLine($"Total students: {students.Count}");
        }

        // Adding a student at a specific position using Insert method
        public void AddStudentAtSpecificPosition()
        {
            students.Insert(0, "Student 0: Alice Brown");
            Console.WriteLine("Students after inserting at the beginning:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        // Removing a specific student using the Remove method
        public void RemoveStudent()
        {
            students.Remove("Student 2: Jane Smith");
            Console.WriteLine("Students after removal:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        // Finding a student using the Find method
        public void FindStudent()
        {
            string foundStudent = students.Find(s => s.Contains("Mike Johnson"));
            if (foundStudent != null)
            {
                Console.WriteLine($"Found student: {foundStudent}");
            }
        }

        // Checking if a student exists using the Contains method
        public void CheckIfStudentExist()
        {
            bool exists = students.Contains("Student 1: John Doe");
            Console.WriteLine($"Student 1: John Doe exists: {exists}");
        }

        // Sorting students using the Sort method
        public void SortStudents()
        {
            students.Sort();
            Console.WriteLine("Students after sorting:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        // Removing a student at a specific position using RemoveAt method
        public void RemoveAtSpecificPosition()
        {
            students.RemoveAt(0);
            Console.WriteLine("Students after removing the first student:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        // Using the constructor that accepts an IEnumerable to initialize the List
        public void InitializeNewList()
        {
            List<string> initialStudents = new List<string> { "Initial Student 1: Sam", "Initial Student 2: Emma" };
            List<string> anotherList = new List<string>(initialStudents);
            Console.WriteLine("Students in another List initialized from an existing collection:");
            foreach (var student in anotherList)
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
