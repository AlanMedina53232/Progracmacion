using System;
using System.Collections.Generic;
using System.Text;

namespace Calculos
{
    class Figura
    {
        Operacion op = new Operacion();
        public void Cuadrado()
        {
            Console.Write("Ingrese el valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            double res = op.Calculararea(valor);
            Console.WriteLine("El area del cuadrado es: " + res);
        }
        public void Rectangulo()
        {
            Console.Write("Ingrese el valor1: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el valor2: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            double res = op.Calculararea(valor1, valor2);
            Console.WriteLine("El area del cuadrado es: " + res);
        }
        public void Triangulo()
        {
            Console.Write("Ingrese la base: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la altura: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            double valor3 = 2;
            double res = op.Calculararea(valor1, valor2, valor3);
            Console.WriteLine("El area del cuadrado es: " + res);
        }
        public void Menu()
        {

            



            Console.WriteLine("Este es  nuestro menu: ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("1.- Area del Cuadrado");
            Console.WriteLine("2.- Area del rectyangulo");
            Console.WriteLine("3.- Area del triangulo");
            Console.WriteLine("4.- Salir");
            Console.Write("\nSeleccione la opcion que desea: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //Aqui se mandan a llamar los distintos metodos
            switch (n)
            {
                case 1:
                    Console.Clear();
                    Cuadrado();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Rectangulo();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Triangulo();
                    Console.ReadKey();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
