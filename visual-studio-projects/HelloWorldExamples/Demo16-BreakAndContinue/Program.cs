using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo16_BreakAndContinue
{
    class Program
    {
        static void PrintRandoms(int n)
        {
            Random random = new Random();

            for (int i = 1; i <= n; i++)
            {
                int value = random.Next(50); //generate random between 0 and 49 (Excluding 50)

               if (value == 0)
                    break; //exit loop immediately


                if (value % 5 == 0)
                {
                    Console.WriteLine("\t\t\tSkipping {0}",value);
                    continue;
                }
                    

                Console.WriteLine("{0}\t{1}", i, value);
                
            }
        }



        static void Main(string[] args)
        {
            PrintRandoms(100);
          
        }
    }
}
