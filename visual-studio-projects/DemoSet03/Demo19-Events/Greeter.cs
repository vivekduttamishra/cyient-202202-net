using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo19_Events
{
    delegate void GreetHandler(string name);
    class Greeter
    {
        public event GreetHandler Greet;

        public void SendGreet(string name)
        {
            if (Greet == null)
                return; //no greeter available

            Greet(name);
        }

        public void Evict()
        {
            Greet = null;
        }
    }
}
