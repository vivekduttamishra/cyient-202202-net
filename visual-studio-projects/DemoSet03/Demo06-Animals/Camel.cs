﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Animals
{
    public class Camel : Mammal
    {
        //no need to refine Die, Move, Breed

        public override string Eat()
        {
            return this + " is grass eater";
        }

        public string Ride()
        {
            return this + " is a great desert ride";
        }
    }
}
