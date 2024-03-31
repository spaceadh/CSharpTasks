using System;

class Program
{
    static void Main()
    {
        string inputDate = "05/01/2008 8:30:52 AM";

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Date as DD/MM/YYYY");
            Console.WriteLine("2. Day alone");
            Console.WriteLine("3. Month alone");
            Console.WriteLine("4. Year alone");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayFormattedDate(inputDate);
                    break;
                case "2":
                    DisplayDayAlone(inputDate);
                    break;
                case "3":
                    DisplayMonthAlone(inputDate);
                    break;
                case "4":
                    DisplayYearAlone(inputDate);
                    break;
                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void DisplayFormattedDate(string inputDate)
    {
        string[] dateParts = inputDate.Split(' ')[0].Split('/');
        string formattedDate = $"{dateParts[1]}/{dateParts[0]}/{dateParts[2]}";
        Console.WriteLine($"Formatted Date: {formattedDate}");
    }

    static void DisplayDayAlone(string inputDate)
    {
        string day = inputDate.Substring(0, 2);
        Console.WriteLine($"Day Alone: {day}");
    }

    static void DisplayMonthAlone(string inputDate)
    {
        string month = inputDate.Substring(3, 2);
        Console.WriteLine($"Month Alone: {month}");
    }

    static void DisplayYearAlone(string inputDate)
    {
        string year = inputDate.Substring(6, 4);
        Console.WriteLine($"Year Alone: {year}");
    }
}