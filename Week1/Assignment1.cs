using System;

class Program
{
    static void Main()
    {
        // Declare variables
        string playerName = "Antti";
        int playerScore = 1000;
        int levelScore = 50;

        // Print information
        Console.WriteLine("Player Name: " + playerName);
        Console.WriteLine("Antti has sore before level: " + playerScore);
        //Console.WriteLine("Score Missing to Level: " + levelScore);

        // Optional: You can also calculate and print the required score for the next level
        int requiredScoreForNextLevel = playerScore + levelScore;
        Console.WriteLine("Antti has sore after level: " + requiredScoreForNextLevel);
    }
}
