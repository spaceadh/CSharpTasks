using System;

class Program
{
    static void Main()
    {
        string input = "The quick brown fox";
        PrintCharactersInReverse(input);
    }

    static void PrintCharactersInReverse(string input)
    {
        for (int i = input.Length - 1; i >= 0; i--)
        {
            // Check if the character is not a space or the first character
            if (input[i] != ' ' || i == 0)
            {
                Console.Write(input[i] + " ");
            }
        }

        Console.WriteLine();
    }
}