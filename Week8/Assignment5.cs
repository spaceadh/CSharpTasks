using System;

// Define an EventArgs class for the event
public class MessageEventArgs : EventArgs
{
    public string Message { get; }

    public MessageEventArgs(string message)
    {
        Message = message;
    }
}

// Influencer class
public class Influencer
{
    // Define the event using EventHandler delegate with custom EventArgs
    public event EventHandler<MessageEventArgs> MessageReceived;

    // Method to trigger the event
    public void TriggerMessage()
    {
        // Check if there are subscribers to the event
        if (MessageReceived != null)
        {
            // Raise the event by invoking it and passing the message
            MessageReceived(this, new MessageEventArgs("New message from the influencer!"));
        }
    }
}

// Subscriber class
public class Subscriber
{
    public string Name { get; }

    // Constructor with an optional influencer parameter
    public Subscriber(string name, Influencer influencer = null)
    {
        Name = name;
        
        // If influencer is provided, subscribe to its event
        if (influencer != null)
        {
            influencer.MessageReceived += Influencer_MessageReceived;
        }
    }

    // Event handler for receiving messages from the influencer
    private void Influencer_MessageReceived(object sender, MessageEventArgs e)
    {
        Console.WriteLine($"{Name} received message: {e.Message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Influencer influencer = new Influencer();
        Subscriber subJeff = new Subscriber("Jeff", influencer);
        Subscriber subAlan = new Subscriber("Alan"); // Alan doesn't subscribe to any influencer
        Subscriber subTim = new Subscriber("Tim", influencer);

        Console.ReadLine();

        // Trigger message from the influencer
        influencer.TriggerMessage();

        Console.ReadLine();
    }
}