using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] array = new int[10];

        // Fill the array with random numbers
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next();
        }

        // Sort the array
        Array.Sort(array);

        // Print the sorted array
        Console.WriteLine("Sorted Array:");
        foreach (var number in array)
        {
            Console.WriteLine(number);
        }
    }
}