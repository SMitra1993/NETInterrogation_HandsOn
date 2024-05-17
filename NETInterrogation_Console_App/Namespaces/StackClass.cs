using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Namespaces
{
    public class StackClass
    {
        // Using the default constructor to create an empty stack
        Stack taskStack = new Stack();

        // Adding tasks using the Push method
        public void AddToStack()
        {
            taskStack.Push("Complete the project report");
            taskStack.Push("Email the project report to the manager");
            taskStack.Push("Prepare for the client meeting");
            taskStack.Push("Update the project plan");
        }

        // Displaying the count of tasks using the Count property
        public void TotalStackCount()
        {
            Console.WriteLine($"Total tasks: {taskStack.Count}");
        }

        // Using the Peek method to view the current task without removing it
        public void PeekIntoStack()
        {
            Console.WriteLine($"Current task: {taskStack.Peek()}");
        }

        // Completing tasks using the Pop method
        public void PopOutTask()
        {
            Console.WriteLine($"Completed task: {taskStack.Pop()}");
            Console.WriteLine($"Current task after completion: {taskStack.Peek()}");
        }

        // Checking if a specific task exists using the Contains method
        public void CheckForExistingTask()
        {
            string specificTask = "Prepare for the client meeting";
            Console.WriteLine($"Does the task '{specificTask}' exist? {taskStack.Contains(specificTask)}");
        }

        // Copying the stack to an array using the ToArray method
        public void ConvertFromStackToArray()
        {
            object[] taskArray = taskStack.ToArray();
            Console.WriteLine("Tasks copied to an array:");
            foreach (var task in taskArray)
            {
                Console.WriteLine(task);
            }
        }

        // Initializes a new instance of the Stack class that contains elements copied from the specified collection.
        public void ConvertFromArrayToStack()
        {
            object[] taskArray = taskStack.ToArray();
            Stack anotherStack = new Stack(taskArray);
            Console.WriteLine("Tasks in another stack initialized from array:");
            foreach (var task in anotherStack)
            {
                Console.WriteLine(task);
            }
        }

        // Clearing all tasks using the Clear method
        public void ClearStack()
        {
            taskStack.Clear();
            Console.WriteLine($"Total tasks after clearing: {taskStack.Count}");
        }
    }
}
