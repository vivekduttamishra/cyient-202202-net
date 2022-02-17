using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo15_FibnociiSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintFibnocciSeriesUpto(1500);
            PrintFibnocciSeries(100);
        }

        static void PrintFibnocciSeries(int terms)
        {
            ulong previous1 = 1;
            ulong previous2 = 1;
            Console.Write("{0}\t{1}\t", previous1, previous2);

            int count = 2; //total terms printed so far

            while(count<terms)
            {
                ulong number = previous1 + previous2;
                Console.Write("{0}\t",number);
                previous2 = previous1;
                previous1 = number;

                count++; //we have printed one more term now.
            }
            Console.WriteLine();

        }

        static void PrintFibnocciSeriesUpto(int max)
        {
            int previous1 = 1;
            int previous2 = 1;
            Console.Write("{0}\t{1}\t",previous1,previous2);

            int number = previous1 + previous2; //next number is sum of two previous numbers

            while(number<max)
            {
                Console.Write("{0}\t",number);
                //now this current previous1 becomes previous 2
                previous2 = previous1;
                //current number becomes previous1
                previous1 = number;
                //next number becomes previous1+previous2
                number = previous1 + previous2;
            }
            Console.WriteLine(); //printing empty line.
        }
    }
}
