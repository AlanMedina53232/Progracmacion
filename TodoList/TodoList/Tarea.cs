using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList
{
    class Tarea
    {
        //Aqui se instancian los atributos del objeto
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tareas { get; set; }
        public string Hora { get; set; }
        public DateTime Fecha { get; set; }
        public string Status { get; set; }
    }
}
