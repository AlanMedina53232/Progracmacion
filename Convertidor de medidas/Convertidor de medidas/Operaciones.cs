using System;
using System.Collections.Generic;
using System.Text;

namespace Convertidor_de_medidas
{
    class Operaciones
    {
        
        public double CentMet(double cantidad)
        {
            
            
           return cantidad / 100;
            
        }
        public double MetPul(double cantidad)
        {
            
             return cantidad * 39.37;
            
        }
        public double MilLit(double cantidad)
        {
            
            return cantidad * 1000 ;
            
        }
    }
}
