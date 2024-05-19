using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Namespaces
{
    public class ArrayListClass
    {
        class Student
        {
            public string Name { get; set; }
            public int Grade { get; set; }

            public Student(string name, int grade)
            {
                Name = name;
                Grade = grade;
            }

            public override string ToString()
            {
                return $"{Name}: {Grade}";
            }
        }

        ArrayList students = new ArrayList(); // Default constructor
        ArrayList initialStudents = new ArrayList
        {
            new Student("Alice", 85),
            new Student("Bob", 90)
        }; // Constructor with initial collection

        ArrayList capacityStudents = new ArrayList(10); // Constructor with initial capacity

        // Add students
        public void AddStudent()
        {
            students.Add(new Student("Charlie", 75));
            students.Add(new Student("David", 95));
        }

        // Insert students
        public void InsertStudent()
        {
            students.Insert(1, new Student("Eve", 88)); // Insert at index 1
        }

        // Display students
        public void DisplayList()
        {
            Console.WriteLine("Initial List of Students:");
            PrintArrayList(students);
        }

        // Access and modify elements
        public void ModifyStudent()
        {
            Student firstStudent = (Student)students[0];
            Console.WriteLine($"\nFirst student: {firstStudent}");
            students[0] = new Student("Frank", 80); // Modify element

            Console.WriteLine("\nList of Students after modification:");
            PrintArrayList(students);
        }

        // Remove students
        public void RemoveStudent()
        {
            students.RemoveAt(1); // Remove by index
            students.Remove(new Student("David", 95)); // Remove by object

            Console.WriteLine("\nList of Students after removal:");
            PrintArrayList(students);
        }

        // Search for students
        public void SearchForStudent()
        {
            bool containsEve = students.Contains(new Student("Eve", 88));
            Console.WriteLine($"\nContains Eve: {containsEve}");

            int indexOfCharlie = students.IndexOf(new Student("Charlie", 75));
            Console.WriteLine($"\nIndex of Charlie: {indexOfCharlie}");
        }

        // Sort the list
        public void SortStudentList()
        {
            students.Sort(new StudentComparer());

            Console.WriteLine("\nSorted List of Students by Grade:");
            PrintArrayList(students);
        }

        // Iterate over the list
        public void IterateOverList()
        {
            Console.WriteLine("\nIterating over the List of Students:");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        static void PrintArrayList(ArrayList list)
        {
            foreach (Student student in list)
            {
                if (student != null)
                {
                    Console.WriteLine(student);
                }
                else
                {
                    Console.WriteLine("null");
                }
            }
        }

        class StudentComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                Student s1 = x as Student;
                Student s2 = y as Student;
                if (s1 == null || s2 == null)
                {
                    throw new ArgumentException("Both arguments must be of type Student.");
                }
                return s1.Grade.CompareTo(s2.Grade);
            }
        }
    }
}
