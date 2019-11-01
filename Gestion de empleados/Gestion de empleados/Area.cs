using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_empleados
{
    //Aqui se heredan los datos de una persona 
    public class Area:Persona
    {
        //Se instancian los datos del area de un empleado
        public string TipoEmpleado { get; set; }
        public string AreaAsignada { get; set; }

    }
}
