using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbersList = new List<int>();
        const int numberOfNumbers = 10;

        Console.WriteLine($"Enter {numberOfNumbers} numbers:");

        // Ask the player for 10 numbers
        for (int i = 0; i < numberOfNumbers; i++)
        {
            Console.Write($"Enter number #{i + 1}: ");
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write($"Enter number #{i + 1}: ");
            }

            numbersList.Add(number);
        }

        // Calculate the sum of even numbers
        int sumOfEvenNumbers = 0;
        foreach (var number in numbersList)
        {
            if (number % 2 == 0)
            {
                sumOfEvenNumbers += number;
            }
        }

        // Print the result
        Console.WriteLine($"Sum of even numbers: {sumOfEvenNumbers}");
    }
}