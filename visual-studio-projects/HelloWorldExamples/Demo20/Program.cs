using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo20
{
    class Program
    {
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for(int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            //if you reach here. that mean number is prime
            return true;

        }

        static int CountPrimes(int min,int max)
        {
            int count = 0;
            for (int i = min; i < max; i++)
                if (IsPrime(i))
                    count++;

            return count;
        }

        static void Main(string[] args)
        {
            //int value = Input.ReadInt("Enter number?");

            //if(IsPrime(value))
            //    Console.WriteLine("{0} is prime",value);
            //else
            //    Console.WriteLine("{0} is NOT prime",value);

            int min = Input.ReadInt("Min?");
            int max = Input.ReadInt("Max?");
            int primes = CountPrimes(min, max);
            Console.WriteLine("Total Primes in range {0}-{1} is {2}",min,max,primes);



        }
    }
}
