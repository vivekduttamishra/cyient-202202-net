using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_TriangleClassV1
{
    class Triangle
    {
        private int s1;
        private int s2;
        private int s3;
        bool valid;
        public Triangle(int x,int y, int z)
        {
            SetSides(x, y, z);
        }

        public Triangle(int sides)
        {
            SetSides(sides, sides, sides);
        }

        public Triangle()
        {
            SetSides(1, 1, 1);
        }


        public void SetSides(int x,int y, int z)
        {
            if (x > 0 && y > 0 && z > 0 && x + y > z && y + z > x && x + z > y)
            {
                //ok sides are valid. we can set them
                s1 = x;
                s2 = y;
                s3 = z;
                valid = true; //mark triangle as valid internally
                
            }
            else 
                valid = false;    //mark triangle as invalid internally  

            
            
        }

        public bool IsValid()
        {
            return valid;
        }



        public double Perimeter()
        {
            if (IsValid())
                return s1 + s2 + s3;
            else
                return Double.NaN; //A special value to represent not a number
        }
    }
}
