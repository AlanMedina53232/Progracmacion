using System;

namespace Sobre_carga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Operacion r = new Operacion();
            var res1 = r.Multiplicar(2, 3);
            var res2 = r.Multiplicar(5);
            var res3 = r.Multiplicar();
            Console.WriteLine("El resultado uno es: " + res1);
            Console.WriteLine("El resultado dos es: " + res2);
            Console.WriteLine("El resultado tres es: " + res3);
            Console.ReadKey();
            Datos d = new Datos();
            d.Obtenerdatos();
            Console.ReadKey();
        }
    }
}
