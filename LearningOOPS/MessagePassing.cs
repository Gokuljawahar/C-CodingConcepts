using System;

// Define a class 'Receiver' that will receive messages
public class Receiver
{
    // Method that simulates processing a message
    public void ReceiveMessage(string message)
    {
        Console.WriteLine("Message received: " + message);
    }
}

// Define a class 'Sender' that will send messages
public class Sender
{
    // Method that sends a message to the Receiver
    public void SendMessage(Receiver receiver, string message)
    {
        receiver.ReceiveMessage(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Sender and Receiver
        Sender sender = new Sender();
        Receiver receiver = new Receiver();

        // Sender sends a message to the Receiver
        sender.SendMessage(receiver, "Hello, World!");
    }
}
