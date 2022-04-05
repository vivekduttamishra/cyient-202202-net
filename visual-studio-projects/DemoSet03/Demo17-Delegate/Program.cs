using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo17_Delegate
{

    public delegate int MathFunction(int x, int y);

    class Program
    {


        public static int Plus(int x,int y) { return x + y; }

        public static int Minus(int x, int y) { return x - y; }

        static void Main(string[] args)
        {
            //DelegateTest01();

            int x = 20;
            int y = 15;

            var calc = new Calculator();

            calc.PrintResult(x, Plus, y);
            calc.PrintResult(x, Minus, y);


            MathFunction abSq = delegate (int a, int b)
             {
                 return (a + b) * (a + b);
             };

            calc.PrintResult(2, abSq, 3); //25


            MathFunction divide = (a, b) => { return a / b; };

            calc.PrintResult(x, divide, y);


            MathFunction multiply = (a, b) => a * b;

            calc.PrintResult(x, multiply, y);


            calc.PrintResult(x, (a, b) => a % b, y);



        }

        private static void DelegateTest01()
        {
            MathFunction add = new MathFunction(Plus);

            MathFunction sub = Minus;




            Console.WriteLine(add.Invoke(4, 8)); //12

            Console.WriteLine(sub(4, 8));
        }
    }
}
