using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Namespaces
{
    public class LinkedListClass
    {
        // Using the default constructor to create an empty LinkedList
        LinkedList<string> tasks = new LinkedList<string>();

        // Adding employee IDs using the Add method
        public void AddToLinkedList()
        {
            tasks.AddLast("Task 1: Buy groceries");
            tasks.AddLast("Task 2: Clean the house");
            tasks.AddLast("Task 3: Complete the report");
        }

        // Displaying the count of tasks using the Count property
        public void TotalTaskCount()
        {
            Console.WriteLine($"Total tasks: {tasks.Count}");
        }

        // Adding a task to the beginning using AddFirst method
        public void AddTaskUsingAddFirst()
        {
            tasks.AddFirst("Task 0: Wake up early");
            Console.WriteLine("Tasks after adding at the beginning:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        // Removing a specific task using the Remove method
        public void RemoveTask()
        {
            tasks.Remove("Task 2: Clean the house");
            Console.WriteLine("Tasks after removal:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        // Finding a task using the Find method
        public void FindTask()
        {
            LinkedListNode<string> foundNode = tasks.Find("Task 3: Complete the report");
            if (foundNode != null)
            {
                Console.WriteLine($"Found task: {foundNode.Value}");
            }
        }

        // Adding a task after a specific node using AddAfter method
        public void AddTasksUsingAddAfter()
        {
            LinkedListNode<string> foundNode = tasks.Find("Task 3: Complete the report");
            tasks.AddAfter(foundNode, "Task 4: Call a friend");
            Console.WriteLine("Tasks after adding after a specific task:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        // Removing the first task using RemoveFirst method
        public void RemoveFirstTask()
        {
            tasks.RemoveFirst();
            Console.WriteLine("Tasks after removing the first task:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        // Removing the last task using RemoveLast method
        public void RemoveLastTask()
        {
            tasks.RemoveLast();
            Console.WriteLine("Tasks after removing the last task:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        // Using the constructor that accepts an IEnumerable to initialize the LinkedList
        public void InitializeLinkedList()
        {
            List<string> initialTasks = new List<string> { "Initial Task 1", "Initial Task 2" };
            LinkedList<string> anotherList = new LinkedList<string>(initialTasks);
            Console.WriteLine("Tasks in another LinkedList initialized from an existing collection:");
            foreach (var task in anotherList)
            {
                Console.WriteLine(task);
            }
        }

        // Clearing all employee records using the Clear method
        public void ClearTask()
        {
            tasks.Clear();
            Console.WriteLine($"Total tasks after clearing: {tasks.Count}");
        }
    }
}
