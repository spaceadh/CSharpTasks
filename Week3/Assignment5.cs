using System;

class Program
{
    static void Main()
    {
        // Declare variables
        double height = GetInput("Enter the height of the cylinder: ");
        double radius = GetRadiusInput();

        // Calculate volume based on user's choice
        double volume = 0;
        char choice = GetUserChoice();
        switch (choice)
        {
            case 'R':
                volume = CalculateCylinderVolumeByRadius(radius, height);
                break;
            case 'D':
                double diameter = 2 * radius;
                volume = CalculateCylinderVolumeByRadius(diameter / 2, height);
                break;
            case 'C':
                double circumference = 2 * Math.PI * radius;
                volume = CalculateCylinderVolumeByRadius(circumference / (2 * Math.PI), height);
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                Environment.Exit(0);
                break;
        }

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

    static double GetRadiusInput()
    {
        char radiusChoice = GetUserChoice();
        double radius = 0;

        switch (radiusChoice)
        {
            case 'R':
                radius = GetInput("Enter the radius of the cylinder: ");
                break;
            case 'D':
                radius = GetInput("Enter the diameter of the cylinder: ") / 2;
                break;
            case 'C':
                radius = GetInput("Enter the circumference of the cylinder: ") / (2 * Math.PI);
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                Environment.Exit(0);
                break;
        }

        return radius;
    }

    static char GetUserChoice()
    {
        Console.Write("Choose how to provide the radius (R), diameter (D), or circumference (C): ");
        return char.ToUpper(Console.ReadKey().KeyChar);
    }

    static double CalculateCylinderVolumeByRadius(double radius, double height)
    {
        // Calculate the volume of the cylinder using the provided formula
        return Math.PI * Math.Pow(radius, 2) * height;
    }
}
