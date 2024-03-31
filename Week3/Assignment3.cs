using System;

class Program
{
    static void Main(string[] args)
    {
        int value = RequestValue();
        bool isEven = IsEven(value);
        PrintResult(isEven, value);

        value = RequestValue();
        isEven = IsEven(value);
        PrintResult(isEven, value);

        value = RequestValue();
        isEven = IsEven(value);
        PrintResult(isEven, value);

        Console.ReadLine();
    }

    static int RequestValue()
    {
        Console.Write("Enter a value: ");
        return int.Parse(Console.ReadLine());
    }

    static bool IsEven(int value)
    {
        return value % 2 == 0;
    }

    static void PrintResult(bool isEven, int value)
    {
        if (isEven)
        {
            Console.WriteLine($"{value} is even");
        }
        else
        {
            Console.WriteLine($"{value} is odd");
        }
    }
}
