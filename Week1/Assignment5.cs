using System;

class Program
{
    static void Main()
    {
        // Create variables for the person's name and order
        string firstName = "Jere";
        string lastName = "Lamberg";
        int order = 4; // Example ordinal number

        // Create a string with the complete name including the ordinal number
        string completeName = $"{firstName} {lastName} the {GetOrdinal(order)}";

        // Print the complete string
        Console.WriteLine("Complete Name: " + completeName);
    }

    // Function to get the ordinal representation of a number (e.g., 1st, 2nd, 3rd)
    static string GetOrdinal(int number)
    {
        if (number % 100 >= 11 && number % 100 <= 13)
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
