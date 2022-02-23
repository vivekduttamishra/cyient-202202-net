using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo26_String
{
    class Program
    {
        static void Main(string[] args)
        {
            String name1 = "Vivek";
            String name2 = "Vijay";

            Console.WriteLine(name1.CompareTo(name2));

            Console.WriteLine("India".CompareTo("France"));

            Console.WriteLine("France".CompareTo("India"));


            Console.WriteLine("INDIA".CompareTo("India"));

            Console.WriteLine(name1.ToUpper()); //print's INDIA. But doesn't change name1

            Console.WriteLine(name1);
        }
    }
}
