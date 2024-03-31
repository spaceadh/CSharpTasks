using System;

class Program
{
    static void Main()
    {
        // Prompt the user for a character
        Console.Write("Enter a character: ");

        // Read the user's input and convert it to a char
        if (char.TryParse(Console.ReadLine(), out char userInput))
        {
            // Convert the character to lowercase for easier comparison
            char lowercasedChar = char.ToLower(userInput);

            // Check if the entered character is a vowel or a consonant
            if (IsVowel(lowercasedChar))
            {
                Console.WriteLine($"{userInput} is a vowel.");
            }
            else
            {
                Console.WriteLine($"{userInput} is a consonant.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid character.");
        }
    }

    // Function to check if a character is a vowel
    static bool IsVowel(char c)
    {
        return "aeiou".IndexOf(c) != -1;
    }
}