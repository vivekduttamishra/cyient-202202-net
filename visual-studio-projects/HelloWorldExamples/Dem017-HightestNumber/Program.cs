using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dem017_HightestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Input.ReadInt("How many numbers? ");
            int max = 0;
            for(int i=1;i<=n;i++)
            {
                int number = Input.ReadInt("Enter Number #" + i + ":");

                //we must assume first entered number as the highest
                if (i == 1)
                    max = number;


                if (number > max) //if new number is bigger than my assumed max
                    max = number; //change the assumption.
            }

            Console.WriteLine("Highest Number was {0}",max);
        }
    }
}
