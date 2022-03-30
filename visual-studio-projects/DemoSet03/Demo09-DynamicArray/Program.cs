using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestInsertRemove();

            var list = new DynamicArray(5);
            Console.WriteLine($"{list}\tLength={list.Length}\tCapacity={list.Capacity}");
            for (int i = 0; i < 15; i++)
            {
                list.Add(i);
                Console.WriteLine($"{list}");
            }


        }

        private static void TestInsertRemove()
        {
            var array = new DynamicArray(1, 2, 3, 5, 6, 7);
            array.Insert(3, 4);
            Console.WriteLine(array);

            array.Remove(4); //4th item will be 5
            Console.WriteLine(array);

            Console.WriteLine($"Array Length is {array.Length}");
            Console.WriteLine($"Array Capacity is {array.Capacity}");

            for (var i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}
