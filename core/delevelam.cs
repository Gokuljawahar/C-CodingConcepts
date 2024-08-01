using System;
public class EventPublisher
{
    public event Action<string> NotifyEvent;

    public void SendNotification(string message)
    {
        NotifyEvent?.Invoke(message);
    }
}

class Program
{
    static void Main()
    {
        EventPublisher publisher = new EventPublisher();

        // Using a lambda expression to subscribe to the event
        publisher.NotifyEvent += (message) => Console.WriteLine($"Notification 1: {message}");

        // Using a delegate method to subscribe to the event
        publisher.NotifyEvent += HandleNotification;

        publisher.SendNotification("Something interesting happened!");
    }

    static void HandleNotification(string message)
    {
        Console.WriteLine($"Notification 2: {message}");
    }
}