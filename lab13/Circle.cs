using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    class Circle
    {
        double Center { get; set; }
        double r;
        public double R
        {
            get
            {
                return r;
            }

            set
            {
                if (value <= 0)
                {
                   
                    throw new MyException("Радиус моловат...");
                    
                }
                else
                   r = value;
            }

        }
        public Circle() { }

        public Circle(double center, double ra)
        {
            Center = center;
            R = ra;
        }

        public static Circle operator ++(Circle c1)
        {
            c1.R++;
            return c1;
        }

        public static Circle operator --(Circle c1)
        {
            c1.R--;
            return c1;
        }
    }
}
