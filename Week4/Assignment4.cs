using System;

class Program
{
    static void Main()
    {
        Random rand = new Random(); // Initialize the Random class
        double sum =  0; // Initialize the sum variable
        int count0to25 =  0; // Initialize counter for values between  0 and  25
        int count25to50 =  0; // Initialize counter for values between  25 and  50
        int count50to75 =  0; // Initialize counter for values between  50 and  75
        int count75to100 =  0; // Initialize counter for values between  75 and  100

        for (int i =  0; i <  100000; i++) // Loop  100,000 times
        {
            int value = rand.Next(0,  101); // Generate a random number between  0 and  100 (101 is excluded)
            sum += value; // Add the random number to the sum

            // Check which range the value falls into and increment the corresponding counter
            if (value >=  0 && value <=  25)
            {
                count0to25++;
            }
            else if (value >  25 && value <=  50)
            {
                count25to50++;
            }
            else if (value >  50 && value <=  75)
            {
                count50to75++;
            }
            else if (value >  75 && value <=  100)
            {
                count75to100++;
            }
        }

        double average = sum /  100000; // Calculate the average
        Console.WriteLine("The average of the  100,000 random numbers is: " + average); // Print the average

        // Calculate and print the percentage of values in each range
        double percent0to25 = (double)count0to25 /  100000 *  100;
        double percent25to50 = (double)count25to50 /  100000 *  100;
        double percent50to75 = (double)count50to75 /  100000 *  100;
        double percent75to100 = (double)count75to100 /  100000 *  100;

        Console.WriteLine($"Percentage of values between  0-25: {percent0to25}%");
        Console.WriteLine($"Percentage of values between  25-50: {percent25to50}%");
        Console.WriteLine($"Percentage of values between  50-75: {percent50to75}%");
        Console.WriteLine($"Percentage of values between  75-100: {percent75to100}%");
    }
}