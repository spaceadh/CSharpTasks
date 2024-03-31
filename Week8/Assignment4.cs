using System;

class Program
{
    delegate float AreaDelegate(); // 1. Declare the delegate

    static void Main(string[] args)
    {
        Shape rectangle = new Rectangle(5, 10);
        Shape circle = new Circle(5);
        Console.WriteLine("Do you want area for\na : Rectangle\nb : Circle");
        string input = Console.ReadLine();
        if (!input.Equals("a") && !input.Equals("b")) 
        {
            Console.WriteLine("Wrong input");
            return;
        }
        bool isRect = input.Equals("a");

        AreaDelegate areaDelegate; // 2. Instantiate the delegate

        if (isRect)
        {
            areaDelegate = rectangle.GetArea; // 3. Populate the delegate with the right method based on input
        }
        else
        {
            areaDelegate = circle.GetArea; // 3. Populate the delegate with the right method based on input
        }

        float area = areaDelegate.Invoke();
        Console.WriteLine($"Area: {area}");
        Console.ReadLine();
    }
}

public abstract class Shape 
{
    public abstract float GetArea();
}

public class Rectangle : Shape
{
    private int m_width;
    private int m_height;
    public Rectangle(int width, int height) 
    {
        m_width = width;
        m_height = height;
    }
    public override float GetArea() => m_width * m_height;
}

public class Circle : Shape
{
    private int m_diameter;
    public Circle(int diameter)
    {
        m_diameter = diameter;
    }
    public override float GetArea() => m_diameter * (float)Math.PI;
}