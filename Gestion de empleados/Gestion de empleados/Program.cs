using System;

namespace Gestion_de_empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            RepoGestor m = new RepoGestor();
            //Aqui se manda a llamar el menu que va a visualizar el usuario
            m.Menu();
        }
    }
}
