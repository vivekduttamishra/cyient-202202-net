using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_Triangle01
{
    class Program
    {
		static int Perimeter(int s1, int s2, int s3)
		{
			return s1 + s2 + s3;
		}

		static void Main()
		{

			int s1 = 3, s2 = 4, s3 = 5;  //represents three sides of the triangle

			int p = Perimeter(s1, s2, s3);

			Console.WriteLine("Perimeter of Triangle is " + p);

		}

	}
}
