using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11_IsLeapYearFunction
{
    class Program
    {
        //static bool IsLeapYear(int year)
        //{
        //    return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);             
        //}

        static bool IsLeapYear(int year)
        {
            return (year % ( year%100==0 ? 400 : 4)) == 0;

        }

        static void PrintLeapYearInfo(int year)
        {
            if(IsLeapYear(year))
                Console.WriteLine("{0} is Leap Year", year);
            else
                Console.WriteLine("{0} is NOT Leap Year", year);
        }


        static void Main(string[] args)
        {
            PrintLeapYearInfo(1982);
            PrintLeapYearInfo(1984);
            PrintLeapYearInfo(1900);
            PrintLeapYearInfo(2000);

        }
    }
}
