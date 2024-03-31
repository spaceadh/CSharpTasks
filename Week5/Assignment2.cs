using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> namesList = new List<string>();
        const int maxSize = 5;

        Console.WriteLine("Enter up to 5 names. Enter 'done' to finish.");

        while (namesList.Count < maxSize)
        {
            Console.Write($"Enter name #{namesList.Count + 1}: ");
            string input = Console.ReadLine();

            // Check if the user wants to finish entering names
            if (input.ToLower() == "done")
                break;

            // Check if the name is already in the list (case-insensitive)
            if (namesList.Any(name => name.Equals(input, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Name already exists in the list. Try again.");
            }
            else
            {
                namesList.Add(input);
                Console.WriteLine($"{input} has been added to the list.");
            }
        }

        // Sort the list alphabetically (case-insensitive)
        namesList.Sort(StringComparer.OrdinalIgnoreCase);

        // Print all the names in alphabetical order
        Console.WriteLine("\nNames in alphabetical order:");
        foreach (var name in namesList)
        {
            Console.WriteLine(name);
        }
    }
}