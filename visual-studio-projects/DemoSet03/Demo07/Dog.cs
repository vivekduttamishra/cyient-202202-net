﻿using Demo07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Animals
{
    public class Dog: Mammal, Hunter
    {
        //no need to refine Die, Move, Breed

        public override string Eat()
        {
            return this + " is a flesh eater";
        }

        public string Hunt()
        {
            return this + " hunts its prey";
        }
    }
}
