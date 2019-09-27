using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad_3
{
    class Principal
    {
        int n = 0;
        Valores val = new Valores();
        public void Bienvenida()
        {
            Console.WriteLine("Bienvenido a la calculadora");
        }
        public void Menu()
        {
            Operacion r = new Operacion();
            
            
            
            
            Console.WriteLine("Este es  nuestro menu: ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("1.- Suma");
            Console.WriteLine("2.- Resta");
            Console.WriteLine("3.- Multiplicacion");
            Console.WriteLine("4.- Divicion");
            Console.WriteLine("5.- Salir");
            Console.Write("\nSeleccione la opcion que desea: ");
            n = Convert.ToInt32(Console.ReadLine());
            //Aqui se mandan a llamar los distintos metodos
            switch (n)
            {
                case 1:
                    Console.Clear();
                    GetSum();
                    double res = r.Sumar(val);
                    Console.WriteLine("El resultado de la suma es: " + res);
                    break;
                case 2:
                    Console.Clear();
                    GetRest();
                    double res2 = r.Restar(val);
                    Console.WriteLine("El resultado de la resta es: " + res2);
                    break;
                case 3:
                    Console.Clear();
                    GetMul();
                    double res3 = r.Mult(val);
                    Console.WriteLine("El resultado de la multiplicacion es: " + res3);
                    break;
                case 4:
                    Console.Clear();
                    GetDiv();
                    double res4 = r.Div(val);
                    Console.WriteLine("El resultado de la divicion es: " + res4);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }
        }
        public void GetSum()
        {
            Console.Write("Ingrese el primer valor a sumar: ");
            val.Valor1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nIngrese el segundo valor a sumar: ");
            val.Valor2 = Convert.ToDouble(Console.ReadLine());
        }
        public void GetRest()
        {
            Console.Write("Ingrese el primer valor a restar: ");
            val.Valor1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nIngrese el segundo valor a restar: ");
            val.Valor2 = Convert.ToDouble(Console.ReadLine());
        }
        public void GetMul()
        {
            Console.Write("Ingrese el primer valor a multiplicar: ");
            val.Valor1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nIngrese el segundo valor a multiplicar: ");
            val.Valor2 = Convert.ToDouble(Console.ReadLine());
        }
        public void GetDiv()
        {
            Console.Write("Ingrese el primer valor a dividir: ");
            val.Valor1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nIngrese el segundo valor a dividir: ");
            val.Valor2 = Convert.ToDouble(Console.ReadLine());
        }
    }
}
