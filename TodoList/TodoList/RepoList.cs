using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList
{
    class RepoList
    {
        List<Tarea> tareas = new List<Tarea>();
        //List<Tarea> status = new List<Tarea>();
        int c = 0;
        public List<Tarea> ListTareas()
        {
            List<Tarea> t = new List<Tarea>();

            return t;
        }
        public void GetTarea()
        {
            Console.Write("Indique la cantidad de tareas que desea agregar: ");
            c = Convert.ToInt32(Console.ReadLine());
            var count = tareas.Count;


            for (int i = 0; i < c; i++)
            {
                Tarea t1 = new Tarea();
                
                Console.Write("\nNombre de quien se encargara de la tarea: ");
                t1.Name = Console.ReadLine();
                Console.Write("Tarea a realizar: ");
                t1.Tareas = Console.ReadLine();
                Console.Write("Hora en la que se debe realizar: ");
                t1.Hora = Console.ReadLine();
                Console.Write("Fecha en la que esta asignada la tarea: ");
                t1.Fecha = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Status de la tarea: ");
                t1.Status = Console.ReadLine();
                count += 1;
                t1.Id = count;
                tareas.Add(t1);
            }
            Console.Write("\nPrecione cualquier tecla para regresar al menu: ");
            Console.ReadKey();
        }
        public void ShowList(List<Tarea> t)
        {
            Console.WriteLine("Lista de Tareas");
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("Nombre del encargado: "+t[i].Name + "\nTarea: "+t[i].Tareas+"\nHora en la que se debe realizar: "+t[i].Hora+"\nFecha: "+t[i].Fecha+"\nStatus de la tarea: "+t[i].Status);
            }
            Console.Write("\nPrecione cualquier tecla para regresar al menu: ");
            Console.ReadKey();
        }
        public void ShowTareas(List<Tarea> t)
        {
            Console.WriteLine("Tareas ");
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine(i+1+".-Tarea: " + t[i].Tareas);
            }
            Console.Write("Seleccione la tarea de la cual desea ver los detalles: ");
            int op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre del encargado: " + t[op-1].Name + "\nTarea: " + t[op-1].Tareas + "\nHora en la que se debe realizar: " + t[op-1].Hora + "\nFecha: " + t[op-1].Fecha + "\nStatus de la tarea: " + t[op-1].Status);
            Console.Write("\nPrecione cualquier tecla para regresar al menu: ");
            Console.ReadKey();
        }
        public void StatusList(List<Tarea> t)
        {
            Console.WriteLine("Status ");
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine(i+1 + ".-Tarea: " + t[i].Tareas + "\tStatus: " + t[i].Status);
            }
            Console.Write("\nPrecione cualquier tecla para regresar al menu: ");
            Console.ReadKey();
        }
        public void Menu()
        {
            Tarea t = new Tarea();

            Console.WriteLine("Este es  nuestro menu: ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("1.- Agregar tareas");
            Console.WriteLine("2.- Mostrar Lista de tareas");
            Console.WriteLine("3.- Ver detalles de una tarea");
            Console.WriteLine("4.- Ver los estatus");
            Console.WriteLine("5.- Salir");
            Console.Write("\nSeleccione la opcion que desea: ");
           

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    GetTarea();
                    Console.Clear();
                    Menu();
                    break;
                case "2":
                    Console.Clear();
                    ShowList(tareas);
                    Console.Clear();
                    Menu();
                    break;
                case "3":
                    Console.Clear();
                    ShowTareas(tareas);
                    Console.Clear();
                    Menu();
                    break;
                case "4":
                    Console.Clear();
                    StatusList(tareas);
                    Console.Clear();
                    Menu();
                    break;
                case "5":
                    Environment.Exit(1);
                    break;
            }
        }
    }
}
