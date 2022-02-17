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

            //We can write two set of if statements one after the other.

            int test=4;  //default or common value

            //change 4 to 400 only if year is  a century year
            if (year % 100 == 0)
            {
                test = 400 ;
            }                
            //else
                //it will remain 4

	        //Second if  actually divides the year and prints the result
            if(year%test==0)
                Console.WriteLine("{0} is a Leap year",year);
            else
                Console.WriteLine("{0} is NOT a Leap year",year);


        }
    }
}
