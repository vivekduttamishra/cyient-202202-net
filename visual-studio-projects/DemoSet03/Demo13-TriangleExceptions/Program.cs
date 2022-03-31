using ConceptArchitect.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo13_TriangleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Triangle(3, 4, 5);

            for(int side = 1; side <=3; side++)
            {
                Console.WriteLine($"Triangle side {side} is {t[side]}");
            }

            var t2 = new Triangle(3, 4, 20);
        }
    }
}
