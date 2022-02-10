using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Function
{
    class Program
    {
        static int ReadInt(String prompt)
        {

            Console.Write(prompt);   //display the prompt without leaving the line

            string input = Console.ReadLine();   //read user keyboard input as String

            int value = int.Parse(input); //try to convert string into int. May fail if conversion is not possible

            return value;
        }




        static void Main(string[] args)
        {
            int price = ReadInt("book price?");
            Console.WriteLine("Book Price: Rs {0}\t after Rs 100 Discount : Rs {1}  ",price,price-100);
        }
    }
}
