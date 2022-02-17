using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14_SumNumbers
{
    class Program
    {
        static int Sum(int max)
        {
            int value = 1;   //this is a helper to count up
            int sum = 0;    //this is the value we need to return

            while(value<=max)
            {
                sum += value; // add current value to the sum
                value++; //increase value by 1
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int max = Input.ReadInt("Sum upto ? ");
            int total = Sum(max);

            Console.WriteLine("sum of 0 - {0} is {1}",max,total);
            
        }
    }
}
