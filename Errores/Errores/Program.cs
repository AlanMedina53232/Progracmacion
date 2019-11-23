using System;
using System.Collections.Generic;
namespace Errores
{
    class Program
    {
        public static object Util { get; private set; }
        static void Main(string[] args)
        {
            var estudiante = new List<Estudiante>();
            var agregar = true;
            while (agregar)
            {
                try
                {
                    var e = new Estudiante();
                    var Ncontrol = e.Matricula;
                    Console.Write("\nIngrese matricula: ");
                    bool result = int.TryParse(Console.ReadLine(), out Ncontrol);
                    Console.Write("Ingrese el nombre del alumno: ");
                    e.Nombre = Console.ReadLine();
                    Console.Write("Ingrese la carrera: ");
                    e.Carrera = Console.ReadLine();
                    Console.Write("Ingrese el semestre que cursa: ");
                    e.Semestre = Convert.ToInt32(Console.ReadLine());
                    estudiante.Add(e);
                    //se evalua si se escriben datos string dentro de una variable int
                    if (Ncontrol == 0)
                    {
                        Console.WriteLine("Ingrese un numero.");
                    }
                    Console.WriteLine("Desea agregar un estudiante mas? Y/N");
                    if(Console.ReadLine( ) != "Y")
                    {
                        agregar = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al ingresar el estudiante.");
                }
            }
            Console.ReadKey();
        }
    }
}
