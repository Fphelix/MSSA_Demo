using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square
    {

        private double side;

        public Square(double aSide)
         => side = aSide;


        public void SetSide(double aSide)
        {
            if (aSide < 0)
            {
                aSide = -aSide;
            }
            else if (aSide == 0)
            {
                aSide = 1;
            }

            side = aSide;
        }

        public double GetSide()
        {
            return side;
        }

        public double GetArea()
        {
            return side * side;
        }
        public double GetPerimeter()

        {
            return 4 * side;
        }

    }
}



