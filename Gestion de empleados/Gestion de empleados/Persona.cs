using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_empleados
{
    public class Persona
    {
        //Aqui se instancian los datos de una persona
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int NumEmpleado { get; set; }
        public Boolean Asistencia { get; set; }
    }
}
