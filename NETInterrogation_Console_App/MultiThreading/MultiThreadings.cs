using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETInterrogation_Console_App.MultiThreading
{
    public static class MultiThreadings
    {
        // Method to print numbers
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Number: {i}");
                Thread.Sleep(1000); // Simulate some work
            }
        }

        // Method to print letters
        public static void PrintLetters()
        {
            for (char c = 'A'; c <= 'E'; c++)
            {
                Console.WriteLine($"Letter: {c}");
                Thread.Sleep(1000); // Simulate some work
            }
        }

        #region Multitasking
        public static async void ReadFile()
        {
            string[] urls = {
                @"C:\Users\msouv\Code\Handson\NETInterrogation_Console_App\NETInterrogation_Console_App\MultiThreading\FileA.txt",
                @"C:\Users\msouv\Code\Handson\NETInterrogation_Console_App\NETInterrogation_Console_App\MultiThreading\FileB.txt",
                @"C:\Users\msouv\Code\Handson\NETInterrogation_Console_App\NETInterrogation_Console_App\MultiThreading\FileC.txt"
            };
            await Task.WhenAll(ReadFileAsync(urls));
            Console.WriteLine("All files read successfully!");
        }

        public static async Task ReadFileAsync(string[] urls)
        {
            foreach (string url in urls)
            {
                using (StreamReader reader = new StreamReader(url))
                {
                    string text = await reader.ReadToEndAsync();
                    Console.WriteLine(text);
                }
            }
        }
        #endregion

        #region Foreground Thread
        public static void ForegroundTrigger()
        {
            // Create a new thread that will execute the method Worker
            Thread thread = new Thread(Worker);
            thread.Start();

            // Main thread continues execution
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main thread executing...");
                Thread.Sleep(1000);
            }
        }

        public static void Worker()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Worker thread executing...");
                Thread.Sleep(1000);
            }
        }
        #endregion

        #region Background Thread
        public static void BackgroundTrigger()
        {
            // Create a new thread that will execute the method Worker
            Thread thread = new Thread(Worker);
            thread.IsBackground = true;
            thread.Start();

            // Main thread continues execution
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main thread executing...");
                Thread.Sleep(1000);
            }
        }
        #endregion
    }
}
