using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TAREA5_REPASO_POO.CLASES
{
    class PORCENTAJE
    {
        public double resta(double pc, double pv, double res)
        {

            res = pc - pv;

            return res;
        }
        public double porcent(double dif, double c2,double por, double c1) 
        {
            dif = (c2 - c1);
            por = (dif / c2) * 100;

            return por;

        }
      


    }
}
