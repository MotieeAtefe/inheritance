using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Circule
    {
        protected double radius;
        public void setRadius(double r)
        {
            this.radius = r;
        }
        public double getRadius()
        {
            return this.radius;
        }
    }
}
