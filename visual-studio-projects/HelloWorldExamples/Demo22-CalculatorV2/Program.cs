using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo22_CalculatorV2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string opr= "";   // +, -, * , /
            double number1 = 0;
            double number2 = 0;
            string choice = "";  // 1, 2, o, x

            while(choice!="x")
            {
                choice = Input.ReadString(  "(1) Select Number1 " +
                                            "\n(2) Select Number 2" +
                                            "\n(o) Operation" +
                                            "\n(c) Clear" +
                                            "\n(x) Exit" +
                                            "\nchoose:  ");
                switch(choice)
                {
                    case "1":
                        number1 = Input.ReadDouble("number 1: ");
                        break;
                    case "2":
                        number2 = Input.ReadDouble("number 2: ");
                        break;

                    case "c":
                        number1 = 0;
                        number2 = 0;
                        break;

                    case "o":
                        opr = Input.ReadString("operator (+,-,*,/): ");
                        Calculate(number1, opr, number2);
                        break;

                    case "x":
                        Console.Write("Stopping Calculator...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Retry");
                        break;
                }


            }

            Console.WriteLine("done");

        }

        private static void Calculate(double number1, string opr, double number2)
        {
            double result;
            switch (opr)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    return;

            }

            Console.WriteLine("{0} {1} {2} ={3}", number1, opr, number2, result);
        }
    }
}
