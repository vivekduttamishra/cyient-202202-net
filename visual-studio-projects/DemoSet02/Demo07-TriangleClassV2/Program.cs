using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_TriangleClassV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(3, 4, 5);
            TestTriangle(t1);

            Triangle t2 = new Triangle(5);
            TestTriangle(t2);

            Triangle t3 = new Triangle();
            TestTriangle(t3);

            Triangle t4 = new Triangle(3, 4, 12);
            TestTriangle(t4);

        }

        private static void TestTriangle(Triangle t)
        {
           


           

            //t.SetSides(x, y, z);

            //if (t.IsValid())
            //{
            //    Console.WriteLine("Triangle is Valid");
            //} else
            //{
            //    Console.WriteLine("Triangle is NOT Valid");
            //}

            t.Draw();
            Console.WriteLine("Perimeter is {0} ", t.Perimeter());
            
            Console.WriteLine();


        }
    }
}
