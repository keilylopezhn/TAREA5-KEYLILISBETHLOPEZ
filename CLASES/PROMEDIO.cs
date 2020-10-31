using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TAREA5_REPASO_POO.CLASES
{
    class PROMEDIO
    {
        public double Sumval(double suma)
        {
            int i;

            for(i=0; i<100; i++)
            {
                suma += i;
            }

            return i;

        }

        public double Promedio(double prom)
        {
            int j;

            for (j=0; j<100; j++)
            {
                prom /= j;
            }

            return j;
        }


        public double salida(double c1, double c2, double c3, double c4, double sal)
        { 
            sal = ((c1 + c2 + c3 + c4) / 4);
            return sal;
        }

       public  double Respuesta (string [] args)
        {
            int i;

            for (i=1;i<=100;i++)
            {
                Console.Write(i);
                Console.Write("-");
            }
            return i;
        }

       
        
        internal object Respuesta(int i)
        {
            throw new NotImplementedException();
        }
         }
}
