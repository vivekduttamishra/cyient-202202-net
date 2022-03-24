using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Animals
{
    public class Cow : Mammal
    {
        //no need to refine Die, Move, Breed

        public override string Eat()
        {
            return this + " is grass eater";
        }
    }
}
