using Demo07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Animals
{
    public abstract class Bird : Animal
    {
        public override string Breed()
        {
            return this + " is egg laying";
        }

      
        public override string Move()
        {
            return Fly();
        }

        public virtual string Fly()
        {
            return this + " Flies in sky"; //we don't know how it hunts.
        }

    }

    public class Parrot: Bird, IDomestic
    {
        public override string Eat()
        {
            return this + " is a fruitarian";
        }
    }


    public class Eagle: Bird,IHunter
    {
        public override string Eat()
        {
            return this + " is a flesh eater";
        }

        public  string Hunt()
        {
            return this + " is a flying hunter";
        }
    }
}
