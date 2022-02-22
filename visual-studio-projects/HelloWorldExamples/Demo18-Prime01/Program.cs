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
            int number = Input.ReadInt("Enter number?");
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


            if(prime)
                Console.WriteLine("{0} is prime", number);
            else
                Console.WriteLine("{0} is not prime", number);
        }
    }
}
