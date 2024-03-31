using System;

class Program
{
    static void Main()
    {
        // Get the player's name, you can modify this part based on your needs.
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();

        // Call the GreetPlayer method and pass the playerName
        GreetPlayer(playerName);
    }

    // GreetPlayer method takes a string parameter called "name"
    static void GreetPlayer(string name)
    {
        // Create a greeting message using the provided name
        string greetingMessage = $"Welcome {name}";

        // Print the greeting message
        Console.WriteLine(greetingMessage);
    }
}
