using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA5_REPASO_POO.CLASES
{
    class CALIFICACION
    {
        public double Promedio (double c1, double c2, double c3)
        {
            double prom;
            double suma;
            suma = c1 + c2 + c3;

            prom = suma / 3;

            return prom;
        }
       
    }
}
