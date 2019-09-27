using System;

namespace Combersor
{
    class Program
    {
        static void Main(string[] args)
        {
            int tc, tp, tc2;
            Console.Write("Ingrese la cantidad de centavos: ");
            tc = Convert.ToInt32(Console.ReadLine());
            Calcular(tc, out tp, out tc2);

            Console.WriteLine("El resultado es: " + tp + " " + " Pesos " + "\t" + tc2 + " " + " Centavos: ");



            void Calcular (int tocentavos, out int pesos, out int centavos)
            {
                pesos = tocentavos / 100;
                centavos = tocentavos % 100;

            }
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
