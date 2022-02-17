using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_IsLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Input.ReadInt("Enter the Year:");

            if (year % 100 == 0)  //For century Years like 1800, 1900, 2000, 2100 ...
            {
                if (year % 400 == 0)
                    Console.WriteLine("{0} is a LeapYear", year);
                else
                    Console.WriteLine("{0} is NOT a leap year", year);
            }
            else  //For other years
            {
                if (year % 4 == 0)
                    Console.WriteLine("{0} is a Leap Year", year);
                else
                    Console.WriteLine("{0} is NOT A Leap year", year);
            }

        }
    }
}
