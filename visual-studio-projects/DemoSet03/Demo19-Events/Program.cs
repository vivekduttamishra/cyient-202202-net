using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo19_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter greeter = new Greeter();

            greeter.SendGreet("Person01"); //no listener. so message will not come

            greeter.Greet += name => Console.WriteLine($"Hello {name}, welcome to our service");

            greeter.SendGreet("Person2");

            greeter.Greet += name => Console.WriteLine($"Bonjour {name}, Bienvenue dans notre service");


            greeter.SendGreet("Person3"); //gets greeting in both english and french

            //greeter.Greet("some one else");


            greeter.

            greeter.Evict(); //remove all listner

            greeter.SendGreet("Person 4");

            Console.WriteLine("End of Program");
        }
    }
}
