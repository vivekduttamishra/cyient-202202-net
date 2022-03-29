using Demo07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Animals
{
    public class Horse: Mammal, IRideable // Rideable means also Domestic
    {
        //no need to refine Die, Move, Breed

        public override string Eat()
        {
            return this + " is grass eater";
        }

        public string Ride()
        {
            return this + " is an ancient popular ride";
        }
    }
}
