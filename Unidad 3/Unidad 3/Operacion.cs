using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad_3
{
    class Operacion
    {
        public double Sumar(Valores p)
        {
           p.Valor3 = p.Valor1 + p.Valor2;
            return p.Valor3;
        }
        public double Restar(Valores p)
        {
            p.Valor3 = p.Valor1 - p.Valor2;
            return p.Valor3;
        }
        public double Mult(Valores p)
        {
            p.Valor3 = p.Valor1 * p.Valor2;
            return p.Valor3;
        }
        public double Div(Valores p)
        {
            p.Valor3 = p.Valor1 / p.Valor2;
            return p.Valor3;
        }
    }
}
