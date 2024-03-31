using System;

class Program
{
    static void Main()
    {
        // Create variables for the person's name and order
        string firstName = "Jere";
        string lastName = "Lamberg";
        int order = 22; // Example ordinal number

        // Create a string with the complete name including the correct ordinal number ending
        string completeName = $"{firstName} {lastName} the {GetOrdinal(order)}";

        // Print the complete string
        Console.WriteLine("Complete Name: " + completeName);
    }

    // Function to get the correct ordinal representation of a number
    static string GetOrdinal(int number)
    {
        if (number < 0)
        {
            // Negative numbers do not have ordinal representation
            return number.ToString();
        }

        int lastTwoDigits = number % 100;

        if (lastTwoDigits >= 11 && lastTwoDigits <= 13)
        {
            return number + "th";
        }

        switch (number % 10)
        {
            case 1:
                return number + "st";
            case 2:
                return number + "nd";
            case 3:
                return number + "rd";
            default:
                return number + "th";
        }
    }
}