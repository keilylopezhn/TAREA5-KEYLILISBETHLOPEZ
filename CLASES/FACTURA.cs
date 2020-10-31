using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA5_REPASO_POO.CLASES
{
    class FACTURA
    {
        public double Subtotal(double c, double p)
        {



             double s = c * p;

            return s;
        }

        public double Impuesto(double impto,double sub)
        {

            impto =  (sub * 0.15);

            return impto;
        }
        public double Total (double impto, double sub)
        {
            
             double total = (sub + impto);

            return total;
        }
    }

}




