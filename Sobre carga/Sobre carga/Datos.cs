using System;
using System.Collections.Generic;
using System.Text;

namespace Sobre_carga
{
    class Datos
    {
       public void Obtenerdatos()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Ingrese dos datos ");
            Console.Write("\nDato1: ");
            double dato1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDato2: ");
            double dato2 = Convert.ToDouble(Console.ReadLine());
            Operacion op = new Operacion();
            double res = op.Multiplicar(dato1, dato2);
            Console.WriteLine("El resultado es: " + res);
        }
    }
}
