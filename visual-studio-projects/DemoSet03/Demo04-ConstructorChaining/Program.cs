using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_ConstructorChaining
{
    class Bird
    {
        int flySpeed;
        public Bird(int flySpeed)
        {
            Console.WriteLine("Bird constructor called with flySpeed "+flySpeed);
        }
    }

    class Parrot : Bird
    {
        public Parrot(int speed)   : base (speed)
        {
            Console.WriteLine("Parrot constructor called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var parrot = new Parrot(20);
        }
    }
}
