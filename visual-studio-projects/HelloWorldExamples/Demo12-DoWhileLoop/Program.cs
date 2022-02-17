using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12_DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            do
            {
                Console.WriteLine("Hello World");
                count++;

            } while (count < 5);
        }
    }
}
