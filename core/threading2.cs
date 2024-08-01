using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create a new thread that runs the Work method
        Thread thread = new Thread(new ThreadStart(Work));
        thread.Start(); // Start the thread

        // Main thread work
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Main thread: " + i);
            Thread.Sleep(100); // Pause for 100 milliseconds
        }

        // Wait for the new thread to finish
        thread.Join();
    }

    static void Work()
    {
        // Work method for the new thread
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Worker thread: " + i);
            Thread.Sleep(100); // Pause for 100 milliseconds
        }
    }
}
