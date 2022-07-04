using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeToTest;

public class film
{
    public static string AvailableClassifications(int ageOfViewer)
    {
        string result;
        if (ageOfViewer <= 0 || ageOfViewer >= 100)
        {
            throw new ArgumentOutOfRangeException("Invalid age entered");
        }
        else if (ageOfViewer > 0 && ageOfViewer < 4 )
        {
            result = "No films available";
        }
        else if (ageOfViewer > 4 && ageOfViewer < 12)
        {
            result = "U, PG  films are available.";
        }
        else if (ageOfViewer > 12 && ageOfViewer < 15)
        {
            result = "U, PG & 12 & 12A films are available.";
        }
        else if (ageOfViewer > 15 && ageOfViewer < 18)
        {
            result = "U, PG, 12 & 12A & 15 films are available.";
        }
        else
        {
            result = "All films are available.";
        }
        return result;
    }
}