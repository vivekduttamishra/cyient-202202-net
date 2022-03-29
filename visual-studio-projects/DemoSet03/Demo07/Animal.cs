using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Animals
{
    public abstract class Animal
    {
        public override string ToString()
        {
            return $"{GetType().Name}#{GetHashCode()}";
        }

        public abstract string Eat();
        public abstract string Move();
        public abstract string Breed();
        
        public  string Die()
        {
            return this + " Dies";
        }
    }
}
