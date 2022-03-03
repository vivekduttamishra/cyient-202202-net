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
            Triangle t1 = new Triangle();
            t1.s1 = 3;  t1.s2 = 4;     t1.s3 = 5;

            Triangle t2 = new Triangle();
            t2.s1 = 3; t2.s2 = 6; t2.s3 = 12;


            int p1 = t1.Perimeter();
            int p2 = t2.Perimeter();
            Console.WriteLine(p1);
        }

    }
}
