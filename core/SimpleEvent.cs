using System;
public class Publisher
{
    public delegate void NotifyEventHandler(string message);
    public event NotifyEventHandler NotifyEvent;

    public void SendNotification(string message)
    {
        NotifyEvent?.Invoke(message);
    }
}

class Program
{
    static void Main()
    {
        Publisher publisher = new Publisher();
        publisher.NotifyEvent += HandleNotification;
        publisher.SendNotification("Something happened!");
    }

    static void HandleNotification(string message)
    {
        Console.WriteLine($"Received notification: {message}");
    }
}