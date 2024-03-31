using System;

class Program
{
    static void Main()
    {
        // Create a string variable for the person's first name
        string firstName = "Alvin";

        // Add a last name to the variable "name" using different methods
        string lastName = "Kipleting";

        // Method 3: Using String interpolation
        string fullName = $"{firstName} {lastName}";

        // Print the person's name before and after adding the last name
        Console.WriteLine("Person's Name Before Adding Last Name: " + firstName);
        Console.WriteLine("Person's Name After Adding Last Name: " + fullName);
        
    }
}
