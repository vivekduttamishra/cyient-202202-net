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
            TestTriangle(t1,4); //traingle should become 4,4,5 which should be still be valid

            Triangle t2 = new Triangle(5);
            TestTriangle(t2,11);  //Triangle will become invalid with sides 11,5,5

            Triangle t3 = new Triangle();
            TestTriangle(t3,2); //triangle will become invalid with sides 2,1,1

            Triangle t4 = new Triangle(3, 4, 12);
            TestTriangle(t4,9);  //triangle will become valid with sides 9,4,12


            Console.WriteLine(t4.Side1); //can't pass a parameter

            Console.WriteLine(t4[1]);
            Console.WriteLine(t4[2]);
            Console.WriteLine(t4[3]);

        }

        private static void TestTriangle(Triangle t, int newS1Value)
        {
            t.Draw();
            
            Console.WriteLine("Perimeter is {0} ", t.Perimeter);
            Console.WriteLine("Area is {0}", t.Area);

            //t.SetS1(newS1Value);
            t.Side1 = newS1Value;

           

            Console.WriteLine("Triangle after changing side 1");
            t.Draw();            
            Console.WriteLine();


        }
    }
}
