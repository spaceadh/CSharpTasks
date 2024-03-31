using System;

class Program
{
    static void Main()
    {
        // Prompt the user for the first value
        Console.Write("Enter the first value: ");

        // Read the user's input and convert it to a double
        if (double.TryParse(Console.ReadLine(), out double firstValue))
        {
            // Prompt the user for the second value
            Console.Write("Enter the second value: ");

            // Read the user's input and convert it to a double
            if (double.TryParse(Console.ReadLine(), out double secondValue))
            {
                // Compare the two values and print the result
                if (firstValue > secondValue)
                {
                    Console.WriteLine($"{firstValue} is larger than {secondValue}.");
                }
                else if (firstValue < secondValue)
                {
                    Console.WriteLine($"{secondValue} is larger than {firstValue}.");
                }
                else
                {
                    Console.WriteLine("Both values are equal.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the second value. Please enter a valid number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for the first value. Please enter a valid number.");
        }
    }
}