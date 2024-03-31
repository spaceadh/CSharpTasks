using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> nameAgeDictionary = new Dictionary<string, int>();

        Console.WriteLine("Enter names and ages for 5 individuals:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter name #{i + 1}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter age for {name}: ");
            int age;

            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.WriteLine("Invalid age. Please enter a valid positive integer.");
                Console.Write($"Enter age for {name}: ");
            }

            // Add the name and age to the dictionary
            nameAgeDictionary[name] = age;
        }

        Console.WriteLine("\nNames and ages of those under 25:");
        foreach (var pair in nameAgeDictionary)
        {
            if (pair.Value < 25)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} years old");
            }
        }
    }
}