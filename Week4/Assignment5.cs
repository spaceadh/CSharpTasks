using System;

class Program
{
    static void Main()
    {
        const string correctPassword = "Password"; // The correct password
        string userPassword;
        int attemptCount =  0; // Counter for the number of attempts

        do
        {
            Console.Write("Please enter password: ");
            userPassword = Console.ReadLine();

            if (userPassword == correctPassword)
            {
                Console.WriteLine("Access granted.");
                break; // Exit the loop if the password is correct
            }
            else
            {
                Console.WriteLine("Access denied.");
                attemptCount++; // Increment the attempt counter
            }
        } while (attemptCount <  3); // Continue the loop until  3 attempts have been made

        if (attemptCount >=  3)
        {
            Console.WriteLine("Program is shutting down due to multiple incorrect password attempts.");
        }
    }
}