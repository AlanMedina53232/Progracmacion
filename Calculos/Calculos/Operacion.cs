using System;
using System.Collections.Generic;
using System.Text;

namespace Calculos
{
    class Operacion
    {
        public double Calculararea( double ladoa)
        {
            double res = ladoa * ladoa ;
            return res;

        }
        public double Calculararea(double ladoa, double ladob)
        {
            double res = ladoa * ladob;
            return res;
        }
        public double Calculararea(double ladoa, double ladob, double ladoc)
        {
            double res = ladoa * ladob / ladoc;
            return res;
        }
    }
}
