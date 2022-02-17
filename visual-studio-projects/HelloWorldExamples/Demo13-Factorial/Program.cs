using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo13_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int f5 = Factorial(5);
        }

        static int Factorial(int n)
        {
            int result = 1;

            while(n>1)
            {
                result = result * n;
                n = n - 1;
            }

            return result;
        }
    }
}
