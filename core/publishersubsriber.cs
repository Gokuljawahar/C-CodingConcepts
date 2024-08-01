using System;

// Declare a delegate
public delegate void Notify(string message);

public class Publisher
{
    // Event based on the delegate
    public event Notify NotifyEvent;

    public void DoSomething()
    {
        Console.WriteLine("Publisher is doing something.");
        // Some processing logic here...

        // When process is completed, call method pointed by delegate
        OnNotifyEvent("Publisher has completed doing something.");
    }

    protected virtual void OnNotifyEvent(string message)
    {
        NotifyEvent?.Invoke(message);
    }
}

public class Subscriber
{
    public void Subscribe(Publisher pub)
    {
        pub.NotifyEvent += OnNotifyEvent; // Register event
    }

    // Event handler
    public void OnNotifyEvent(string message)
    {
        Console.WriteLine("Subscriber received this message: " + message);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Publisher pub = new Publisher();
        Subscriber sub = new Subscriber();

        sub.Subscribe(pub); // Subscriber subscribes to publisher

        pub.DoSomething(); // Publisher does something and notifies subscriber
    }
}
