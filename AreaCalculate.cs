using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
   
    internal class AreaCalculate: Circule
    {
        protected double area;
        public void SetAreaCalculate(double r)
        {
            this.area = Math.PI * r * r;
         
        }
        public double GetAreaCalculate()
        {
            return this.area;
        }

    }
}
