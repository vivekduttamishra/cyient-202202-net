using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo18_MulticastDelegate
{
    delegate void Greet(String name);

    class Program
    {
        static void WishInEnglish(string name)
        {
            Console.WriteLine($"Hello {name}, Welcome to our service");
        }

        static void WishInHindi(string name)
        {
            Console.WriteLine($"नमस्ते {name}, हमारी सेवा में आपका स्वागत है ");
        }

        static void Main(string[] args)
        {
            Greet greet = WishInEnglish;

            //greet = WishInHindi; //replaces WishInEnglish

            greet += WishInHindi; //multi cast to both WishInEnglish and WishInHindi

            //can even add lambda to multicast
            greet += (name) => Console.WriteLine($"Bonjour {name}, Bienvenue dans notre service");


            


            greet("Cient"); //all the three methods would be called called

            
        }
    }
}
