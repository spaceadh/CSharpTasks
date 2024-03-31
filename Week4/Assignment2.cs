using System;

class Program
{
    static void Main(string[] args)
    {
        bool validEntry = true; // Initialize the flag to true
        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Calculate for R");
            Console.WriteLine("2. Calculate for D");
            Console.WriteLine("3. Calculate for C");

            string choice = Console.ReadLine();

            if (choice == "1" || choice == "2" || choice == "3")
            {
                Console.Write("Enter the value: ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    double result;

                    if (choice == "1")
                    {
                        result = value *  2; // Replace this with your calculation for option  1
                        Console.WriteLine($"Result for R: {result}");
                    }
                    else if (choice == "2")
                    {
                        result = value +  5; // Replace this with your calculation for option  2
                        Console.WriteLine($"Result for D: {result}");
                    }
                    else if (choice == "3")
                    {
                        result = Math.Pow(value,  2); // Replace this with your calculation for option  3
                        Console.WriteLine($"Result for C: {result}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    validEntry = false; // Set validEntry to false if the input is not a valid number
                }
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter  1,  2, or  3.");
                validEntry = false; // Set validEntry to false if the choice is not valid
            }
        } while (validEntry); // The loop will continue as long as validEntry is true
    }
}
