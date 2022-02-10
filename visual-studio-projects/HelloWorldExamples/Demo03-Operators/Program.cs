using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20, b = 30, c = 5;
            int d = a = b = c;

            Console.WriteLine("a={0}\tb={1}\tc={2}\td={3}",a,b,c,d);


            int e = ++d * 5;   //  (++d)  * 5   --->  6 * 5

            Console.WriteLine("d={0}\te={1}",d,e);


            a = 20;
            b = 40;

            a += b += 10;  //  a+=   (b+=10)

            Console.WriteLine("a={0}\tb={1}",a,b);  //b=50   a=70


            a = 5;
            b = 5;

            c = a++ * ++b;  // 1. ++b     2. a*b    3. c=a*b    4. a++

            Console.WriteLine("a={0}\tb={1}\tc={2}",a,b,c);

            a = 5;
            b = a++ * ++a; //1. ++a  (a<-6)   2. a*a (6*6)   3. b<--30  4. a++

            Console.WriteLine("a={0}\tb={1}",a,b);  //a=7  b=36




        }
    }
}
