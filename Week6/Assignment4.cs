using System;
using System.Text;

class Program
{
    static void Main()
    {
        string input = "Welcome to week 6 of this C# course";
        string result = ProcessString(input);
        Console.WriteLine(result);
    }

    static string ProcessString(string input)
    {
        StringBuilder resultBuilder = new StringBuilder();

        // Find the index of the first digit in the input string
        int indexOfFirstDigit = -1;
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                indexOfFirstDigit = i;
                break;
            }
        }

        // If a digit is found, cut the string at that index and convert to uppercase
        if (indexOfFirstDigit != -1)
        {
            string cutString = input.Substring(0, indexOfFirstDigit).Trim();
            resultBuilder.Append(cutString.ToUpper());
        }
        else
        {
            // If no digit is found, convert the entire string to uppercase
            resultBuilder.Append(input.ToUpper());
        }

        return resultBuilder.ToString();
    }
}