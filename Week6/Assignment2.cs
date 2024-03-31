using System;

class Program
{
    static void Main()
    {
        string sentence = "The quick brown fox jumps over the lazy dog";

        while (true)
        {
            Console.Write("Enter a single character: ");
            string input = Console.ReadLine();

            // Check if the input is a single character
            if (input.Length == 1)
            {
                char character = input[0];

                // Search and print words containing the entered character
                string[] words = sentence.Split(' ');
                Console.WriteLine($"Words containing '{character}':");

                foreach (string word in words)
                {
                    if (word.Contains(character))
                    {
                        Console.WriteLine(word);
                    }
                }

                // Exit the loop after printing
                break;
            }
            else
            {
                Console.WriteLine("Please enter only one character. Try again.");
            }
        }
    }
}
