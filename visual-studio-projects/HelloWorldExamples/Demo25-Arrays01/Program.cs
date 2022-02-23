using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo25_Arrays01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 9, 2, 1 };

            Console.WriteLine("Array is  {0}\tLength is {1}", numbers, numbers.Length);


            //Console.WriteLine("numbers[0] =\t" + numbers[0]);


            //let us print all items of the array

            for( int i=0;i< numbers.Length; i++)
            {
                Console.WriteLine("numbers[{0}] = {1}", i, numbers[i]);
                //we can also change the values
                numbers[i] = numbers[i] * 100;
            }

            Console.WriteLine("numbers[6]="+numbers[6]);


        }
    }
}
