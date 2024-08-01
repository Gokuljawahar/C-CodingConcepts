using System;
// Declare a delegate
public delegate void MyDelegate(string message);

public class Publisher
{
    // Declare an event
    public event MyDelegate MyEvent;

    public void RaiseEvent(string message)
    {
        // Raise the event
        if (MyEvent != null)
        {
            MyEvent(message);
        }
    }
}

public class Subscriber
{
    public void Subscribe(Publisher publisher)
    {
        // Subscribe to the event
        publisher.MyEvent += RespondToEvent;
    }

    public void RespondToEvent(string message)
    {
        System.Console.WriteLine("Received message: " + message);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        // The subscriber subscribes to the publisher's event
        subscriber.Subscribe(publisher);

        // The publisher raises the event
        publisher.RaiseEvent("Hello, World!");
    }
}
