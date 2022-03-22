using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14_Params
{
    class Program
    {
        static double Add(params  int [] values)
        {
            int sum = 0;
            foreach(int value in values)
            {
                sum += value;
            }

            return sum;
        }

        int Multiply(params int [] values)
        {
            int result = 1;

            for(int i=0;i<values.Length;i++)
            {
                result *= values[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            double a = Add(4, 2, 1, 3);
            Console.WriteLine(a);

            Program p = new Program();
            int b = p.Multiply(1, 2, 3, 4, 5); //120

            Console.WriteLine(b);

        }
    }
}
