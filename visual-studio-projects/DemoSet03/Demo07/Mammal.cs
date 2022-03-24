using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Animals
{
    public abstract class Mammal : Animal
    {
        public override string Breed()
        {
            return this + " is child bearing";
        }

        public override string Move()
        {
            //true for most cases. Bat or whale may override this method again
            return this + " moves on ground"; 
            
        }
    }

    



}
