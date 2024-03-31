using System;

class Program
{
    static void Main()
    {
        double height = GetInput("Enter the height of the cylinder: ");
        double radius = GetInput("Enter the radius of the cylinder: ");

        double volume = CalculateCylinderVolume(radius, height);

        Console.WriteLine($"The volume of the cylinder is: {volume}");

        Console.ReadLine();
    }

    static double GetInput(string message)
    {
        Console.Write(message);
        string input = Console.ReadLine();

        // Try parsing the input to a double, handle errors gracefully
        if (double.TryParse(input, out double result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Invalid input. Using default value 0.");
            return 0;
        }
    }

    static double CalculateCylinderVolume(double radius, double height)
    {
        // Calculate the volume of the cylinder using the formula
        double volume = Math.PI * Math.Pow(radius, 2) * height;
        return volume;
    }
}
