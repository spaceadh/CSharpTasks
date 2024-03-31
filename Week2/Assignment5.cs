using System;

class Program
{
    static void Main()
    {
        // Prompt the user for the temperature in Fahrenheit
        Console.Write("Enter the temperature in Fahrenheit: ");

        // Read the user's input and convert it to a double
        if (double.TryParse(Console.ReadLine(), out double fahrenheitTemperature))
        {
            // Convert Fahrenheit to Celsius
            double celsiusTemperature = (fahrenheitTemperature - 32) * 5 / 9;

            // Print the temperature in Celsius
            Console.WriteLine($"Temperature in Celsius: {celsiusTemperature:F2}°C");

            // Check if the temperature is below freezing
            if (celsiusTemperature < 0)
            {
                Console.WriteLine("The temperature is below freezing.");
            }
            else
            {
                Console.WriteLine("Not freezing.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid temperature as a number.");
        }
    }
}