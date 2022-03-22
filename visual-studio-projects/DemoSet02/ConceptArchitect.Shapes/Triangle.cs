using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Shapes
{
    public class Triangle
    {
        double[] sides;  //will hold the sides;
        public bool Valid { get; private set; } //is autoimplemented property with default get/set logic

        public Triangle(double s1, double s2, double s3)
        {
            SetSides(s1, s2, s3);
        }

        public Triangle(double side)
        {
            SetSides(side, side, side); //equlilateral
        }

        public Triangle()
        {
            SetSides(1, 1, 1); //unit triangle
        }

        private void SetSides(double s1, double s2, double s3)
        {
            sides =new double[]{ s1,s2,s3};

            Validate();

        }

        private void Validate()
        {
            Valid = sides[0] > 0 && sides[1] > 0 && sides[2] > 0 &&
                    sides[0] + sides[1] > sides[2] &&
                    sides[1] + sides[2] > sides[0] &&
                    sides[2] + sides[0] > sides[1];
        }

        public double this [ int side ]
        {
            get
            {
                if (side < 1 || side > 3)  //invalid triangle side
                    return double.NaN;
                return sides[side - 1];  //side1 is stored on 0 index, side2 is stored on 1 index 
            }

            set
            {
                if (side < 1 || side > 3)
                    return;
                sides[side - 1]=value;  //side1 is stored on 0 index, side2 is stored on 1 index 
                Validate();
            }
        }

        public double Perimeter
        {
            get
            {
                if (!Valid)
                    return double.NaN;

                double p = 0;
                foreach(double side in sides)
                    p += side;

                return p;
            }
        }

        public double Area
        {
            get
            {
                if (!Valid)
                    return double.NaN;

                double s = Perimeter / 2;

                double x = s;

                foreach (double side in sides)
                    x *= (s - side);  // x= x*(s-side); --> each loop will havde side= s1, s2, s3

                return Math.Sqrt(x);

            }
        }

        public void Draw()
        {
            ConsoleColor color = ConsoleColor.Blue;
            String text = "Triangle";

            if (!Valid)
            {
                color = ConsoleColor.Red;
                text = "Invalid Triangle";
            }

            text = text + "<";

            for (int i = 0; i < 3; i++)
                text += string.Format("{0}{1} ", sides[i], i < 2 ? "," : ">");

            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();

        }



    }
}
