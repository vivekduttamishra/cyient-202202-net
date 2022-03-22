using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Shapes
{
    public  class Circle
    {
        private double radius; //by default 0

        //string name; //default null

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get 
            { 
                return radius; 
            }

            set
            {
                if(value>0)
                    radius = value; //value is what is supplied client
            }
        }

        public double Perimeter
        {
            get
            {
                return 2 * 3.141592 * radius;
            }
        }

    }
}
