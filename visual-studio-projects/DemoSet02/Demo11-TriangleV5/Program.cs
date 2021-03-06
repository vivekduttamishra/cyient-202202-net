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


            Console.WriteLine("t4[4] "+t4[4]);
            Console.WriteLine("t4[0] " + t4[0]);
        }

        private static void TestTriangle(Triangle t, int newS1Value)
        {
            t.Draw();

            Console.Write("sides:\t");

            for(int i=1;i<=3;i++)
                Console.Write("{0}\t", t[i]);  //using triangle indexer



            
            Console.WriteLine("Perimeter is {0} ", t.Perimeter);
            Console.WriteLine("Area is {0}", t.Area);

            //t.SetS1(newS1Value);
            //t.S1 = newS1Value;

            t[1] = newS1Value;  //set the side1 of triangle

           

            Console.WriteLine("Triangle after changing side 1");
            t.Draw();            
            Console.WriteLine();


        }
    }
}
