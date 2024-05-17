using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.Namespaces
{
    public class QueueClass
    {
        // Using the default constructor to create an empty queue
        Queue customerQueue = new Queue();

        // Adding customers using the Enqueue method
        public void AddToQueue()
        {
            customerQueue.Enqueue("Customer 1");
            customerQueue.Enqueue("Customer 2");
            customerQueue.Enqueue("Customer 3");
            customerQueue.Enqueue("Customer 4");
        }

        // Displaying the count of customers using the Count property
        public void TotalQueueCount()
        {
            Console.WriteLine($"Total customers in queue: {customerQueue.Count}");
        }

        // Using the Peek method to view the first customer without removing them
        public void PeekIntoQueue()
        {
            Console.WriteLine($"First customer in queue: {customerQueue.Peek()}");
        }

        // Serving customers using the Dequeue method
        public void PopOutCustomer()
        {
            Console.WriteLine($"Serving customer: {customerQueue.Dequeue()}");
            Console.WriteLine($"First customer after serving one: {customerQueue.Peek()}");
        }

        // Checking if a specific customer is in the queue using the Contains method
        public void CheckForExistingCustomer()
        {
            string specificCustomer = "Customer 3";
            Console.WriteLine($"Is '{specificCustomer}' in queue? {customerQueue.Contains(specificCustomer)}");
        }

        // Copying the queue to an array using the ToArray method
        public void ConvertFromQueueToArray()
        {
            object[] customerArray = customerQueue.ToArray();
            Console.WriteLine("Customers copied to an array:");
            foreach (var customer in customerArray)
            {
                Console.WriteLine(customer);
            }
        }

        // Initializes a new instance of the Queue class that contains elements copied from the specified collection.
        public void ConvertFromArrayToQueue()
        {
            object[] customerArray = customerQueue.ToArray();
            Queue anotherQueue = new Queue(customerArray);
            Console.WriteLine("Customers in another queue initialized from array:");
            foreach (var customer in anotherQueue)
            {
                Console.WriteLine(customer);
            }
        }

        // Clearing all customers using the Clear method
        public void ClearQueue()
        {
            customerQueue.Clear();
            Console.WriteLine($"Total customers after clearing: {customerQueue.Count}");
        }
    }
}
