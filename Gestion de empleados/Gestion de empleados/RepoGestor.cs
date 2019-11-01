using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_empleados
{
    public class RepoGestor
    {
        //Aqui se genera la lista con los datos de los empleados
        List<Area> area = new List<Area>();
        int c = 0;

        //En este metodo se comienzan a ingresar los datos de cada empleado
        public void GetPersona()
        {
            Console.Clear();
            Console.Write("Indique la cantidad de tareas que desea agregar: ");
            c = Convert.ToInt32(Console.ReadLine());
            var count = area.Count;


            for (int i = 0; i < c; i++)
            {
                Area a = new Area();

                Console.Write("\nNombre: ");
                a.Nombre = Console.ReadLine();
                Console.Write("Correo: ");
                a.Correo = Console.ReadLine();
                Console.Write("Telefono de contacto: ");
                a.Telefono = Console.ReadLine();
                Console.Write("No. de empleado: ");
                a.NumEmpleado = Convert.ToInt32(Console.ReadLine());
                Console.Write("Tipo de empleado: ");
                a.TipoEmpleado = Console.ReadLine();
                Console.Write("Area asignada: ");
                a.AreaAsignada = Console.ReadLine();
                Console.Write("Asistencia: ");
                //Se utiliza esta desicion debido a que es un dato booleano y esto nos permite indicar si asistio o no
                if(Console.ReadLine() == "si")
                {
                    a.Asistencia = true;
                }
                else if(Console.ReadLine()== "no")
                {
                    a.Asistencia = false;
                }
                count += 1;
                a.Id = count;
                //En esta linea se envian todos los datos capturados hacia la lista
                area.Add(a);

            }
            Console.Write("\nPrecione cualquier tecla para regresar al menu: ");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        //Este metodo nos permite visualizar la lista de todos los empleados 
        public void ShowEmpleados()
        {
            Console.Clear();
            Console.WriteLine("Esta es la lista de empleados...");
            foreach(Area a in area)
            {
                Console.WriteLine("\n" + a.Id + ".-Nombre: " + a.Nombre+"\nCorreo: "+a.Correo+"\nTelefono: "+a.Telefono+"\nNo. de empleado: "+a.NumEmpleado+"\nTipo de empleado: "+a.TipoEmpleado+"\nArea asignada: "+a.AreaAsignada+"\nAsistencia: "+a.Asistencia);
            }
            Console.Write("\nPrecione cualquier tecla para regresar al menu: ");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        //Aqui nos permite modificar los datos completos de un empleado 
        public void ModificarDatos()
        {
            Console.Clear();
            //Se despliega la lista de los empleados nuevamente
            Console.WriteLine("Esta es la lista de empleados...");
            foreach (Area a in area)
            {
                Console.WriteLine("\n" + a.Id + ".-Nombre: " + a.Nombre + "\nCorreo: " + a.Correo + "\nTelefono: " + a.Telefono + "\nNo. de empleado: " + a.NumEmpleado + "\nTipo de empleado: " + a.TipoEmpleado + "\nArea asignada: " + a.AreaAsignada + "\nAsistencia: " + a.Asistencia);
            }
            //En esta parte nos permite seleccionar el empleado que se desea modificar
            Console.WriteLine("Indique que empleado que desea modificar: ");
            int op = Convert.ToInt32(Console.ReadLine());
            if (area.Contains(area[op-1]))
            {
                
                Console.Write("\nNombre: ");
                area[op-1].Nombre = Console.ReadLine();
                Console.Write("Correo: ");
                area[op-1].Correo = Console.ReadLine();
                Console.Write("Telefono de contacto: ");
                area[op-1].Telefono = Console.ReadLine();
                Console.Write("No. de empleado: ");
                area[op-1].NumEmpleado = Convert.ToInt32(Console.ReadLine());
                Console.Write("Tipo de empleado: ");
                area[op-1].TipoEmpleado = Console.ReadLine();
                Console.Write("Area asignada: ");
                area[op-1].AreaAsignada = Console.ReadLine();
                Console.Write("Asistencia: ");
                //Se utiliza esta desicion debido a que es un dato booleano y esto nos permite indicar si asistio o no
                if (Console.ReadLine() == "si" )
                {
                    area[op-1].Asistencia = true;
                }
                else if (Console.ReadLine() == "no")
                {
                    area[op-1].Asistencia = false;
                }
            }
            //Aqui se le da la opcion al usiario para regresar al menu o modificar otro empleado
            Console.WriteLine("\n1.-Volver al menu.\t2.-Modificar datos de otro empleado. ");
            switch (Console.ReadLine())
            {
                case "1":
                    Menu();
                    break;
                case "2":
                    ModificarDatos();
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
        //Aqui podemos dar de baja por completo un usuario eliminandolo por completo de la lista
        public void BajaEmpleado()
        {
            Console.Clear();
            //Se despliega la lista de los empleados nuevamente
            Console.WriteLine("Esta es la lista de empleados...");
            foreach (Area a in area)
            {
                Console.WriteLine("\n" + a.Id + ".-Nombre: " + a.Nombre + "\nCorreo: " + a.Correo + "\nTelefono: " + a.Telefono + "\nNo. de empleado: " + a.NumEmpleado + "\nTipo de empleado: " + a.TipoEmpleado + "\nArea asignada: " + a.AreaAsignada + "\nAsistencia: " + a.Asistencia);
            }
            //Aqui nos permite seleccionar el empleado que desea dar de baja
            Console.Write("Indique el  empleado que desea dar de baja: ");
            int op = Convert.ToInt32(Console.ReadLine());
            if (area.Contains(area[op-1]))
            {
                area.Remove(area[op-1]);
            }
            Console.WriteLine("1.-Volver al menu.\t2.-Dar de baja a otro empleado.");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Menu();
                    break;
                case "2":
                    Console.Clear();
                    BajaEmpleado();
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
        //Este es el menu que visualizara el usuario desde un principio
        public void Menu()
        {
            Console.WriteLine("Este es  nuestro menu: ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("1.- Alta de empleados");
            Console.WriteLine("2.- Lista de empleados");
            Console.WriteLine("3.- Modificaciones");
            Console.WriteLine("4.- Baja de empleados");
            Console.WriteLine("5.- Salir");
            Console.Write("\nSeleccione la opcion que desea: ");

            switch (Console.ReadLine())
            {
                case "1":
                    GetPersona();
                    break;
                case "2":
                    ShowEmpleados();
                    break;
                case "3":
                    ModificarDatos();
                    break;
                case "4":
                    BajaEmpleado();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
        
    }
}
