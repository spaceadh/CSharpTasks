using System;

class Program
{
    static void Main()
    {
        while (true) // Start of an infinite loop
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Calculate for R");
            Console.WriteLine("2. Calculate for D");
            Console.WriteLine("3. Calculate for C");

            string choice = Console.ReadLine(); // Read user's choice

            if (choice == "1" || choice == "2" || choice == "3") // Validate choice
            {
                Console.Write("Enter the value: ");
                if (double.TryParse(Console.ReadLine(), out double value)) // Validate and read value
                {
                    double result;

                    switch (choice) // Perform calculation based on choice
                    {
                        case "1":
                            result = value *  2; // Calculation for R
                            Console.WriteLine($"Result for R: {result}");
                            break;
                        case "2":
                            result = value +  5; // Calculation for D
                            Console.WriteLine($"Result for D: {result}");
                            break;
                        case "3":
                            result = Math.Pow(value,  2); // Calculation for C
                            Console.WriteLine($"Result for C: {result}");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Exiting loop.");
                    break; // Exit loop if value is not a valid number
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Exiting loop.");
                break; // Exit loop if choice is not valid
            }
        }
    }
}