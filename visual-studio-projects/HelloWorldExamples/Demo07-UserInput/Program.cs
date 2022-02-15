using ConceptArchitect.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07_UserInput
{
    class Program
    {

        static string GetRecommendation(int price, double rating)
        {
            if (price < 200)
                return "Inexpensive: You may read it";
            else if (rating < 3)
                return "Bad Reviews: You can ignore it";
            else if (price < 400 && rating > 4)
                return "Good Book at Great Price. Do Read It";
            else if (rating > 4)
                return "Expensive Book. But you can read it.";
            else
                return "Sorry! No Recommendation. Take your own call!";
        }


        static void Main(string[] args)
        {
            String bookTitle = Input.ReadString("book title? ");
            int price = Input.ReadInt("Price? ");
            double rating = Input.ReadDouble("Rating? ");

            Console.WriteLine("Title:\t" + bookTitle);
            Console.WriteLine("Price:\tRs {0}",price);
            Console.WriteLine("Rating:\t{0}/5",rating);

            if(Input.ReadBoolean("Do you need recommendataion?"))
            {
                string recommendatation = GetRecommendation(price, rating);
                Console.WriteLine("here is my recommendation: {0}",recommendatation);
            }

        }
    }
}
