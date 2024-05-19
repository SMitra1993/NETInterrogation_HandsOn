using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Namespaces
{
    public class Student
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

    public class ArrayClass
    {
        // Create an array of students using Array.CreateInstance
        Array students = Array.CreateInstance(typeof(Student), 5);

        // Add students to the array
        public void AddToArray()
        {
            students.SetValue(new Student("Alice", 85), 0);
            students.SetValue(new Student("Bob", 90), 1);
            students.SetValue(new Student("Charlie", 75), 2);
            students.SetValue(new Student("David", 95), 3);
            students.SetValue(new Student("Eve", 88), 4);
        }

        // Display initial list of students
        public void DisplayStudentList()
        {
            Console.WriteLine("Initial List of Students:");
            PrintArray(students);
        }

        // Sort students by grade using Array.Sort and a custom comparer
        public void SortArrayUsingCustomCoparaer()
        {
            Array.Sort(students, new StudentComparer());
            Console.WriteLine("\nSorted List of Students by Grade:");
            PrintArray(students);
        }

        // Search for a specific student using Array.BinarySearch
        public void SearchStudent()
        {
            int index = Array.BinarySearch(students, new Student("David", 95), new StudentComparer());
            Console.WriteLine($"\nBinary Search for David: Found at index {index}");
        }
        public void ResizeList()
        {
            //Student[] studentArray = new Student[students.Length];
            //students.CopyTo(studentArray, 0);
            //Array.Resize(ref studentArray, 5);
            //studentArray.SetValue(new Student("Frank", 80), 6);
            //Console.WriteLine("\nList of Students after Resize:");
            //PrintArray(studentArray);
            Student[] studentArray = new Student[students.Length];
            students.CopyTo(studentArray, 0);
            Array.Resize(ref studentArray, 6);
            studentArray[5] = new Student("Frank", 80);
            students = studentArray;  // Update the reference to the resized array
            Console.WriteLine("\nList of Students after Resize:");
            PrintArray(students);
        }

        // Copy the array to a new array using Array.Copy
        public void CloneStudentList()
        {
            Array studentsCopy = Array.CreateInstance(typeof(Student), students.Length);
            Array.Copy(students, studentsCopy, students.Length);
            Console.WriteLine("\nCopied List of Students:");
            PrintArray(studentsCopy);
        }

        public void ClearStudentList()
        {
            Array studentsCopy = Array.CreateInstance(typeof(Student), students.Length);
            Array.Copy(students, studentsCopy, students.Length);
            Array.Clear(studentsCopy, 0, studentsCopy.Length);
            Console.WriteLine("\nCleared Grades in Copied List of Students:");
            PrintArray(students);
        }

        static void PrintArray(Array array)
        {
            foreach (Student student in array)
            {
                Console.WriteLine(student);
            }
        }
    }
    class StudentComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Student s1 = x as Student;
            Student s2 = y as Student;
            return s1.Grade.CompareTo(s2.Grade);
        }
    }
}
