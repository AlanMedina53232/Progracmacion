using System;
using System.Collections.Generic;
using System.Text;

namespace Convertidor_de_medidas
{
    class Repoconversor
    {
        Operaciones r = new Operaciones();
        public void Menu()
        {
            
            Console.WriteLine("Este es el menu");
            Console.WriteLine("------------------------------------------");
            Console.Write("\nDigite la cantidad a convertir: ");
            double cantidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n1.- Centimetros a metros. ");
            Console.WriteLine("\n2.- Metros a pulgadas. ");
            Console.WriteLine("\n3.- Litros a mililitros. ");
            Console.Write("Seleccione una opcion para convertir: ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    double metros = r.CentMet(cantidad);
                   Console.WriteLine("La cantidad en metros es: " + metros);
                    Menu();
                    break;
                case 2:
                    double pulgadas = r.MetPul(cantidad);
                    Console.WriteLine("La cantidad en pulgadas es: " + pulgadas);
                    Menu();
                    break;
                case 3:
                    double mililitros = r.MilLit(cantidad);
                    Console.WriteLine("La cantidad en mililitros es: " + mililitros);
                    Menu();
                    break;


            }

        }
    }
}
