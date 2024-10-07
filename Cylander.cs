using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Cylander: AreaCalculate
    {
        protected double height;
        protected double volume;
        public void SetHeight(double h)
        {
            this.height = h;
        }
        public double GetHeight()
        {
            return this.height;
        }
        public void SetVolume()
        {
            this.volume = area * this.height;
        }
        public double GetVolume()
        {
            return this.volume;
        }

    }
}
