using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle
    {
        private double radius;

        public Circle(double aRadius)
        
           => radius = aRadius;
            //SetRadius(aRadius);
        
        public void SetRadius( double aRadius)
        {
            if (aRadius < 0)
            {
                aRadius = -aRadius;
            }
            else if(aRadius == 0)
            {
                aRadius = 1;
            }

            radius = aRadius;
        }

         public double GetRadius()
        {
            return radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public double GetCircumference()

        {
            return 2* (Math.PI * radius);
        }

    }
}
