using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Namespaces
{
    public class JaggedArrayClass
    {
        // Initialize a jagged array
        int[][] classSchedules = new int[3][]; // 3 courses

        // Initialize each course with different number of classes
        public void AddCourses()
        {
            classSchedules[0] = new int[] { 2, 3, 1 }; // Course 1: 3 days with 2, 3, and 1 classes
            classSchedules[1] = new int[] { 4, 1 };    // Course 2: 2 days with 4 and 1 classes
            classSchedules[2] = new int[] { 1, 2, 3, 4 }; // Course 3: 4 days with 1, 2, 3, and 4 classes
        }

        // Modify class schedules
        public void ModifyClassSchedules()
        {
            classSchedules[0][2] = 2;
        }

        public void DisplaySchedules()
        {
            Console.WriteLine("Class Schedules:");
            for (int i = 0; i < classSchedules.Length; i++)
            {
                Console.Write($"Course {i + 1}: ");
                for (int j = 0; j < classSchedules[i].Length; j++)
                {
                    Console.Write(classSchedules[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void TotalClassesPerCourse()
        {
            Console.WriteLine("\nTotal Classes for Each Course:");
            for (int i = 0; i < classSchedules.Length; i++)
            {
                int totalClasses = 0;
                for (int j = 0; j < classSchedules[i].Length; j++)
                {
                    totalClasses += classSchedules[i][j];
                }
                Console.WriteLine($"Course {i + 1}: {totalClasses} classes");
            }
        }

        public void SearchSchedule()
        {
            int targetClasses = 3;
            Console.WriteLine($"\nCourses with a day having {targetClasses} classes:");
            for (int i = 0; i < classSchedules.Length; i++)
            {
                for (int j = 0; j < classSchedules[i].Length; j++)
                {
                    if (classSchedules[i][j] == targetClasses)
                    {
                        Console.WriteLine($"Course {i + 1} has {targetClasses} classes on day {j + 1}");
                    }
                }
            }
        }

        public void ModifySchedule()
        {
            Console.WriteLine("\nModifying a specific schedule...");
            classSchedules[1][1] = 2; // Change the second day's classes of course 2 to 2

            Console.WriteLine("Updated Class Schedules:");
            for (int i = 0; i < classSchedules.Length; i++)
            {
                Console.Write($"Course {i + 1}: ");
                for (int j = 0; j < classSchedules[i].Length; j++)
                {
                    Console.Write(classSchedules[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
