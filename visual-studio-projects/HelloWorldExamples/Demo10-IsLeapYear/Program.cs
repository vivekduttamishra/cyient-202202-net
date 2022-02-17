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

           if(year%400==0 || (year%4==0 && year%100!=0))

                Console.WriteLine("{0} is a Leap year",year);
            else
                Console.WriteLine("{0} is NOT a Leap year",year);


        }
    }
}
