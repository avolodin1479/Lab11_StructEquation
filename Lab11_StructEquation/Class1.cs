using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_StructEquation
{
    public struct Equation
    {
        public double coefK;
        public double coefB;

        public Equation(double coefK, double coefB)
        {
            this.coefK = coefK;
            this.coefB = coefB;
        }
        public void Root(double coefK, double coefB, out double rootX)
        {
            rootX = -coefB / coefK;
        }
    }

}
