
using ConceptArchitect.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo13_PropertyExample
{

   

    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(7);

            

            Triangle t = new Triangle(3, 4, 5);

            Console.WriteLine("Perimeter of Circle is "+c.Perimeter);
            Console.WriteLine("Perimeter of Triangle is " + t.Perimeter);

            c.Radius = 14;
            
            t[1] = 100; //now triangle is invalid

            Console.WriteLine("Perimeter of Circle is " + c.Perimeter);
            Console.WriteLine("Perimeter of Triangle is " + t.Perimeter);
        }
    }
}
