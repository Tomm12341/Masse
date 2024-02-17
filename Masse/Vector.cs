using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masse
{
    internal class Vector
    {
       
        public double X { get; set; }

        public double Y { get; set; }

        public double Modulo(Vector v1)
        {
            double mod = (Math.Sqrt(X * X + Y * Y));
            return mod;
        }
    }
}
