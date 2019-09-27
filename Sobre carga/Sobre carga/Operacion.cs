using System;
using System.Collections.Generic;
using System.Text;

namespace Sobre_carga
{
    class Operacion
    {
        public double Multiplicar()
        {
            double m = 5*6;
            return m;

        }
        public double Multiplicar(double a)
        {
            double m = a * 2;
            return m;

        }
        public double Multiplicar(double a, double b)
        {
            double m = a * b;
            return m;
        }
    }
}
