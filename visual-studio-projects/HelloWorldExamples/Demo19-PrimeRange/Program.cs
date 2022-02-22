using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo18_Prime01
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = Input.ReadInt("Min?");
            int max = Input.ReadInt("Max?");

            int primes = 0;

            for(int number=min;number<max;number++)
            {
                bool prime = true; //let us assume it is prime

                if (number > 1)
                {
                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {

                            prime = false; //ok! my assumption was wrong
                            break;
                        }
                    }
                }
                else
                    prime = false; //for number <=1

                if (prime)
                    primes++;                

            }


            Console.WriteLine("There are {0} primes in range {1}-{2}",primes,min,max);
            
        }
    }
}
