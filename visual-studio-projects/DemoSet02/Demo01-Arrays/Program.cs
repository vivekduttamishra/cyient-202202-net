using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] names = new string[3];

            for(int i=0;i<names.Length;i++)
            {
                names[i] = Input.ReadString("Name?");
            }


            Console.WriteLine("\n\nDisplaying names using for loop");
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i].ToUpper());
            }

            Console.WriteLine("\n\nDisplayng Names using for-each loop");

            foreach(string name in names)
            {
                Console.WriteLine(name.ToUpper());
            }

        }
    }
}
