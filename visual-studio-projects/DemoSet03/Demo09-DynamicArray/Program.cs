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

            //TestObjectBasedGeneric();

            DynamicArray<int> numbers = new DynamicArray<int>(1, 2, 3, 4, 5);
            var names = new DynamicArray<string>("india", "usa", "uk", "france");

            //numbers.Add("Hello World"); //you can't store wrong value

            //names.Add(20);

            Console.WriteLine("Numbers");
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]*10); //mulitplication works because we know it is int

            Console.WriteLine("\nNames");
            for (int i = 0; i < names.Length; i++)
                Console.WriteLine(names[i].ToUpper()); //works because we know it is string

        }

        private static void TestObjectBasedGeneric()
        {
            DynamicObjectArray numbers = new DynamicObjectArray(1, 2, 3, 4, 5);
            DynamicObjectArray names = new DynamicObjectArray("india", "usa", "uk", "france");

            numbers.Add("Hello World");
            names.Add(20);

            Console.WriteLine("Numbers");
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);

            Console.WriteLine("\nNames");
            for (int i = 0; i < names.Length; i++)
                Console.WriteLine(names[i]);
        }

        private static void TestIndexer()
        {
            var list = new DynamicIntArray(5);
            Console.WriteLine($"{list}\tLength={list.Length}\tCapacity={list.Capacity}");
            for (int i = 0; i < 15; i++)
            {
                list.Add(i);
                Console.WriteLine($"{list}");
            }
        }

        private static void TestInsertRemove()
        {
            var array = new DynamicIntArray(1, 2, 3, 5, 6, 7);
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
