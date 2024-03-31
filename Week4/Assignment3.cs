using System;

class Program
{
    static void Main()
    {
        Random rand = new Random(); // Initialize the Random class
        double sum =  0; // Initialize the sum variable

        for (int i =  0; i <  100000; i++) // Loop  100,000 times
        {
            int value = rand.Next(0,  101); // Generate a random number between  0 and  100 (101 is excluded)
            sum += value; // Add the random number to the sum
        }

        double average = sum /  100000; // Calculate the average
        Console.WriteLine("The average of the  100,000 random numbers is: " + average); // Print the average
    }
}
