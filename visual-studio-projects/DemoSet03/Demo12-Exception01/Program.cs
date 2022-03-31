using ConceptArchitect.Collections;
using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12_Exception01
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new DynamicArray<int>(5, 9, 7, 8, 4);  //5 values

            var count = Input.ReadInt("How many Items do you want to see?");

            try
            {
                for (int i = 0; i < count; i++)
                    Console.WriteLine($"list[{i}] = {list[i]}");

                Console.WriteLine("I gave you all numbers you wanted");

            } 
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Hey We have readhed the end of List. Don't push you luck further");
            }

            Console.WriteLine("End of Program");
        }
    }
}
