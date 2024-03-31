using System;

class Program
{
    static void Main()
    {
        // Declare variables
        float x = 10.5f;
        float y = 20.0f;

        // Print original vector
        Console.WriteLine("Original Vector: ({0}, {1})", x, y);

        float xMulitplier = 0.5f;
        float yMultiplier = 0.5f;

        Console.WriteLine("Multiplier: ({0}, {1})", xMulitplier, yMultiplier);

        // Reduce the vector by half
        x *= xMulitplier;
        y *= yMultiplier;

        // Print the reduced vector
        Console.WriteLine("Divided x : ({0}, {1})", x, y);
    }
}
