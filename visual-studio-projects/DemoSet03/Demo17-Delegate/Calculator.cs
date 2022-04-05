using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo17_Delegate
{
    class Calculator
    {
        public  void PrintResult(int number1, MathFunction fn, int number2)
        {
            int result = fn(number1, number2);

            Console.WriteLine($"{number1} {fn.Method.Name} {number2} = {result}");
        }
    }
}
