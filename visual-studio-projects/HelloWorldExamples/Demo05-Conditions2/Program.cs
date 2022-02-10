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
            double price = 399;
            string recommendation = "No recommendatation. decide yourself.";

            if (rating > 4 && price < 400)
                recommendation = "Highly Recommended";
            else if (rating > 4 && price > 500)
                recommendation = "Expensive but recommended";
            else if (rating > 3 && price < 200)
                recommendation = "May be read once";
            else if (rating < 3)
                recommendation = "Not recommended";
            //else
            //default recommendataion

            Console.WriteLine("{0} by {1}\n\tRecommendataion:{2}",title,author,recommendation);



        }
    }
}
