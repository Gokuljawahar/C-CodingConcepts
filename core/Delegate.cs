using System;

// Declare a delegate
public delegate void Notify(string message);

public class ProcessBusinessLogic
{
    // Event based on the delegate
    public event Notify ProcessCompleted;

    public void StartProcess()
    {
        Console.WriteLine("Process Started!");
        // Some processing logic here...

        // When process is completed, call method pointed by delegate
        OnProcessCompleted("Process Completed!");
    }

    protected virtual void OnProcessCompleted(string message)
    {
        ProcessCompleted?.Invoke(message);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ProcessBusinessLogic bl = new ProcessBusinessLogic();
        bl.ProcessCompleted += bl_ProcessCompleted; // Register event

        bl.StartProcess();
    }

    // Event handler
    public static void bl_ProcessCompleted(string message)
    {
        Console.WriteLine(message);
    }
}
