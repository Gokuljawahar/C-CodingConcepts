// using System;
// using System.Threading.Tasks;

// class Program
// {
//     static async Task   Main(string[] args)
//     {
//         // Start a task that runs the DoWork method
//         Task task = DoWork();

//         // Main thread work
//         for (int i = 0; i < 10; i++)
//         {
//             Console.WriteLine($"Main thread: {i}");
//             await Task.Delay(100); // Pause for 100 milliseconds
//         }

//         // Wait for the task to complete
//         await task;
//     }

//     static async Task DoWork()
//     {
//         // Simulate some asynchronous work
//         for (int i = 0; i < 10; i++)
//         {
//             Console.WriteLine($"Worker thread: {i}");
//             await Task.Delay(100); // Pause for 100 milliseconds
//         }
//     }
// }

using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args) // Corrected signature
    {
        // Start a task that runs the DoWork method
        Task task = DoWork();

        // Main thread work
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Main thread: {i}");
            await Task.Delay(100); // Pause for 100 milliseconds
        }

        // Wait for the task to complete
        await task;
    }

    static async Task DoWork()
    {
        // Simulate some asynchronous work
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Worker thread: {i}");
            await Task.Delay(100); // Pause for 100 milliseconds
        }
    }
}
