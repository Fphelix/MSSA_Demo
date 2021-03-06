using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle
    {
        private double length ;
        private double width ;


      

        public Rectangle ( double l, double w)
        {
            SetLength(l);
            SetWidth(w);
        }
        //Methods
    public void SetLength(double length)
    {
            if (length <= 0)
            {
                length = -length;
            }
            else if (length == 0)
            {
                length = 1.0;
            }

            this.length = length;
    }

    public void SetWidth(double width)
    {
            if (width < 0)
            {
                width = -width;
            }
            else if (width ==0)
            {
                width = 1;
            }
            this.width = width;
    }
    public double GetLength()
    {
            return length;
    }
    public double GetWidth()
    {
            return width;
    }
        public double GetArea()
        {
            return width * length;
        }
        public double GetPerimeter()
        {
            return 2 * (length * width);
        }

    

    }// class
}
