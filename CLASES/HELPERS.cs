using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA5_REPASO_POO.CLASES
{
    class HELPERS
    {
        //METODO MSWARNING
        public void Msgwarning(string msg)
        {
            MessageBox.Show(msg, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //METODO ALERTNONUMBER
        public void Alert(string str)
        {
            double x;

            if (!double.TryParse(str, out x))
            {
                Msgwarning("EL VALOR DEBE SER NUMERICO");

            }
        }
        //METODO CHECKIFISNUMBER
        public string CheifisNumber(string str) {

            string resp = " ";
            double x;
            if (double.TryParse (str,out x))
            {
                resp = "S";
            }
            else
            {
                resp = "N";
            }
            return resp;

        }
        //METODO RETURNNUMBER
        public double ReturnsNumber(string str)
        {
            double value = 0;
            if (double.TryParse(str, out value))
            {
                value = Convert.ToDouble(str);

               
            }
            return value;
        }


        }
    }


