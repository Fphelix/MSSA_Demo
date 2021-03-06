using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Triangle
    {

        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double aSideA, double aSideB, double aSideC)
        {
            SetSideA(aSideA);
            sideB = aSideB;
            sideC = aSideC;
        }


        public void SetSideA( double aSideA)
        {
            if (aSideA <0)
            {
                aSideA = -aSideA;
            }
            else if ( aSideA== 0 )
            {
                aSideA = 1;
            }
            sideA = aSideA;
        }

        public double GetSideA()
        {
            return sideA;
        }


        public void SetSideB(double aSideB)
        {
            if (aSideB < 0)
            {
                aSideB = -aSideB;
            }
            else if (aSideB == 0)
            {
                aSideB = 1;
            }
            sideB = aSideB;
        }

        public double GetSideB()
        {
            return sideB;
        }


        public void SetSideC(double aSideC)
        {
            if (aSideC < 0)
            {
                aSideC = -aSideC;
            }
            else if (aSideC == 0)
            {
                aSideC = 1;
            }
            sideC = aSideC;
        }

        public double GetSideC()
        {
            return sideC;
        }

        public double GetPerimeter()
        {
            return sideA + sideB + sideC;
        }
        public double GetArea()
        {
            double halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * 
                             (halfPerimeter - sideB) * (halfPerimeter - sideC));
        }











    }
}
