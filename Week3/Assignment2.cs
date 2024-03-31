using System;

class Program
{
    static void Main()
    {
        // Get the width and height from the user (you can modify this part based on your needs)
        int width = GetInput("Enter the width: ");
        int height = GetInput("Enter the height: ");

        // Call the CalculateArea method and pass the width and height
        int area = CalculateArea(width, height);

        // Print the calculated area
        Console.WriteLine($"The area of the rectangle is: {area}");
    }

    // CalculateArea method takes two int parameters, "width" and "height"
    // and returns the area of a rectangle
    static int CalculateArea(int width, int height)
    {
        // Calculate the area using the provided width and height
        int area = width * height;

        // Return the calculated area
        return area;
    }

    // Helper method to get user input for integer values
    static int GetInput(string message)
    {
        Console.Write(message);
        string input = Console.ReadLine();

        // Try parsing the input to an integer, handle errors gracefully
        if (int.TryParse(input, out int result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Invalid input. Using default value 0.");
            return 0;
        }
    }
}
