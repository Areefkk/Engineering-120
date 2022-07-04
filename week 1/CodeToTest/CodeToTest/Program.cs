using System;

namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        int timeOfDay = 21;
        string greet = Greeting(timeOfDay);
        Console.WriteLine(greet);
    }

    public static string Greeting(int timeOfDay)
    {
        string greeting;
        
        if (timeOfDay >= 5 && timeOfDay <= 12)
        {
            greeting = "Good morning!";
        }
        else if (timeOfDay >= 12 && timeOfDay <= 18)
        {
            greeting = "Good afternoon!";
        }
        else
        {
            greeting = "Good evening!";
        }
        return greeting;
    }

    public static string AvailableClassifications(int ageOfViewer)
    {
        string result;
        if (ageOfViewer <= 0 || ageOfViewer >= 100)
        {
            throw new ArgumentOutOfRangeException("Invalid age entered");
        }
        else if (ageOfViewer > 0 && ageOfViewer < 4)
        {
            result = "No films available";
        }
        else if (ageOfViewer >= 4 && ageOfViewer < 12)
        {
            result = "U, PG  films are available.";
        }
        else if (ageOfViewer >= 12 && ageOfViewer < 15)
        {
            result = "U, PG, 12 & 12A films are available.";
        }
        else if (ageOfViewer >= 15 && ageOfViewer < 18)
        {
            result = "U, PG, 12, 12A & 15 films are available.";
        }
        else
        {
            result = "All films are available.";
        }
        return result;
    }
}