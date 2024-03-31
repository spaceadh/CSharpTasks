using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence one word at a time. Type 'done' when finished:");

        // Initialize an empty string to store the concatenated sentence
        string concatenatedSentence = "";

        // Continue taking input until the user enters 'done'
        while (true)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            // Check if the user wants to finish entering words
            if (word.ToLower() == "done")
            {
                break;
            }

            // Concatenate the word with the existing sentence
            concatenatedSentence += word + " ";
        }

        // Trim any extra space at the end and print the final sentence
        concatenatedSentence = concatenatedSentence.Trim();
        Console.WriteLine("Concatenated Sentence: " + concatenatedSentence);
    }
}
