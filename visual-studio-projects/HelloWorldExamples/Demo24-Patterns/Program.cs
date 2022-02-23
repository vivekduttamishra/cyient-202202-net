using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo24_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = Input.ReadInt("Enter the number of lines?");

            for(int line = 1; line <= lines; line++)
            {
                for(int star=1; star<=line; star++)
                {
                    Console.Write("*\t");
                }

                Console.WriteLine(); //leave the line
            }

        }
    }
}
