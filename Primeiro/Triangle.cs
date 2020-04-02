using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroBase
{
    class Triangle
    {
        public double LadoA;
        public double LadoB;
        public double LadoC;

        public double Area()
        {
            return LadoA + LadoB + LadoC;
        }
    }
}
