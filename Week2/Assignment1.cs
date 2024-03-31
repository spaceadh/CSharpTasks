using System;

class Program
{
    static void Main()
    {
        // Prompt the user for their age
        Console.Write("What is your age: ");

        // Read the user's input and convert it to an integer
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            // Check if the user is an adult (age 18 or older)
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not yet an adult.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age as a number.");
        }
    }
}