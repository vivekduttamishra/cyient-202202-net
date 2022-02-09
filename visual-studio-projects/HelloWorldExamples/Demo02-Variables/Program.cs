using System;

namespace Demo02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            String title = "The Accursed God";
            String author = "Vivek Dutta Mishra";
            int price = 399;
            double rating = 3.2;

            int discountedPrice = price / 2; //50% discount running

            Console.WriteLine("Title:\t"+title); //  string + anything = string

            Console.WriteLine("Author:\t{0}", author); //we can use placeholders

            /* we are using Write and not WriteLine.
             * That means After completing printing cursor will not go to next line
             * WriteLine ---> Write + "\n"
             */

            Console.WriteLine("Original Price: ₹{0}\tDiscounted Price: ₹{1}",price, discountedPrice);

            Console.Write("Rating:\t{0}",rating); //two placeholder

            bool recommended = rating > 4;  //may be true or false

            Console.WriteLine("\tRecommended:\t"+recommended);

        }
    }
}
