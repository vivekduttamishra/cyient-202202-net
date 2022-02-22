using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo21SimpleCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            while(true)
            {
                String choice = Input.ReadString("Operation +,-,*,/ or 'x' to exit:");

                if (choice == "x")
                    break;

                int number1 = Input.ReadInt("Number 1? ");
                int number2 = Input.ReadInt("Number 2? ");

                Calculate(choice, number1, number2);
            }
            
        }

        private static void Calculate(string choice, int number1, int number2)
        {
            int result;
            switch (choice)
            {
                case "+":
                    result= number1 + number2;
                    break;
                case "-":
                    result =number1 - number2;
                    break;
                case "*":
                    result= number1 * number2;
                    break;
                case "/":
                    result= number1 / number2;
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    return;
                    
            }

            Console.WriteLine("{0} {1} {2} ={3}",number1, choice,number2,result);



        }


        private static void Calculate0(string choice, int number1, int number2)
        {

            int result = 0;

            if (choice == "+")
                result= number1 + number2;

            else if (choice == "-")
                result= number1 - number2;

            else if (choice == "*")
                result= number1 * number2;

            else if (choice == "/")
                result= number1 / number2;

            else
                Console.WriteLine("Invalid Operator. Retry");

            Console.WriteLine("{0} {1} {2} = {3}", number1,choice,number2, result);

        }
    }
}
