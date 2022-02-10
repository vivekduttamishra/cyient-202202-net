using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "The Accursed God";
            string author = "Vivek Dutta Mishra";
            double rating = 4.1;
            double price = 599;

            if(rating>4)
            {
                if(price<400)
                {
                    Console.WriteLine("{0} is Highly Recommended",title);
                } else
                {
                    Console.WriteLine("{0} is expensive but recommended",title);
                }
            } else
            {
                if(rating<3)
                    Console.WriteLine("{0} is not recommended",title);
                else
                {
                    if(price<200 && rating>3)
                    {
                        Console.WriteLine("{0} may be a one time read",title);
                    } else
                    {
                        Console.WriteLine("{0} has No Recommendation",title);
                    }
                }
            }

        }
    }
}
