using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Animals
{
    public class Reptile : Animal
    {
        public override string Breed()
        {
            return this + " is egg laying";
        }

        public override string Eat()
        {
            return this + " is carnivour";
        }

        public override string Move()
        {
            return this + " is a crawler and swimmer";
        }

        public virtual string Hunt()
        {
            return this + " is a hunter"; //we don't know how it hunts.
        }

    }

    public class Crocodile : Reptile
    {
        public override string Hunt()
        {
            return this + " is a great underwanter hunter";
        }
    }


    public class Snake : Reptile
    {
        public override string Hunt()
        {
            return this + " is a poisonous hunter";
        }
    }
}
