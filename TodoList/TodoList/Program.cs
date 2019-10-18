using System;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            RepoList r = new RepoList();
            r.Menu();
        }
    }
}
