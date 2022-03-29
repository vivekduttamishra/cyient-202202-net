using Demo07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Animals
{
    public abstract class Reptile : Animal, IHunter
    {
      
        public override string Breed()
        {
            return this + " is egg laying";
        }

        public override string Eat()
        {
            return this + " is carnivour";
        }

        public abstract string Hunt();

        public override string Move()
        {
            return this + " is a crawler and swimmer";
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
