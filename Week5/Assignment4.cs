using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, int> valueOccurrences = new Dictionary<int, int>();
        Random random = new Random();

        for (int i = 0; i < 100; i++)
        {
            int value = random.Next(1, 11);

            // Check if the value exists in the dictionary
            if (valueOccurrences.ContainsKey(value))
            {
                // If yes, update the occurrence count
                valueOccurrences[value]++;
            }
            else
            {
                // If not, add the value to the dictionary with an initial occurrence count of 1
                valueOccurrences[value] = 1;
            }
        }

        // Print the occurrences
        Console.WriteLine("Occurrences of each value:");
        foreach (var pair in valueOccurrences)
        {
            Console.WriteLine($"Number : {pair.Key} was generated {pair.Value} times");
        }
    }
}