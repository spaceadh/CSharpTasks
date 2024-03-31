using System;

class Program
{
    static void Main()
    {
        // Prompt the user for their year of birth
        Console.Write("What is your birthyear ?");

        // Read the user's input and convert it to an integer
        if (int.TryParse(Console.ReadLine(), out int yearOfBirth))
        {
            // Calculate the age based on the current year
            int currentYear = DateTime.Now.Year;
            int age = currentYear - yeaKOKOrOfBirth;

            // Check if the age falls within the working age range (18-65 inclusive)
            if (age >= 18 && age <= 65)
            {
                Console.WriteLine("You are within the working age range (18-65).");
            }
            else
            {
                Console.WriteLine("You are not within the working age range (18-65).");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid year as a number.");
        }
    }
}
