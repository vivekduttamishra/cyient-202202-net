using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Animals
{
    public class Animal
    {
        public virtual string Eat()
        {
            return this + " Eats something";
        }

        public virtual string Move()
        {
            return this + " Moves somehow";
        }

        public virtual string Breed()
        {
            return this + "Breeds somehow";
        }

        public string Die()
        {
            return this + " Dies";
        }
    }
}
