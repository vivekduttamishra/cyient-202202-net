using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12_TriangleV5
{
    class Program
    {
        public static void TestTriangle(Triangle t, double side1Value)
        {
            Console.WriteLine("Triangle Before Change");
            ShowTriangle(t);

            t[1] = side1Value;

            Console.WriteLine("Triangle After Change");
            ShowTriangle(t);

            Console.WriteLine();
        }

        private static void ShowTriangle(Triangle t)
        {
            t.Draw();
            Console.WriteLine("Area:" + t.Area);
            Console.WriteLine("Perimeter:" + t.Perimeter);
        }

        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(3, 4, 5);

            TestTriangle(t1, 4); //triangle should change to Valid Triangle (4,4,5)


            Triangle t2 = new Triangle(5, 5, 5);

            TestTriangle(t2, 12); //triangle should change to Invalid Triangle <12,5,5>


            Triangle t3 = new Triangle(3, 4, 12);
            TestTriangle(t3, 9); //invalid triangle should change to valid Triangle<9,4,12>
        }
    }
}
