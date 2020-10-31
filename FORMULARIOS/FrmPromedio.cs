using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA5_REPASO_POO.FORMULARIOS
{
    public partial class FrmPromedio : Form

    {
        CLASES.PROMEDIO pROMEDIO = new CLASES.PROMEDIO();
        CLASES.HELPERS h = new CLASES.HELPERS();
        public FrmPromedio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text.Trim().Length == 0)
            {
                h.Msgwarning("EL CAMPO NOMBRE ES REQUERIDO");
                TxtNombre.Focus();
                return;
            }
            if (TxtC1.Text.Trim().Length == 0)
            {
                h.Msgwarning("EL CAMPO  PRIMER  CALIFICACION  ES REQUERIDO");
                TxtC1.Focus();
                return;
            }
            if (TxtC2.Text.Trim().Length == 0)
            {
                h.Msgwarning("EL CAMPO SEGUNDA CALIFICACION ES REQUERIDO");
                TxtC2.Focus();
                return;
            }
            if (TxtC3.Text.Trim().Length == 0)
            {
                h.Msgwarning("EL CAMPO TERCER CALIFICACION ES REQUERIDO");
                TxtC3.Focus();
                return;
            }
            if (TxtC4.Text.Trim().Length == 0)
            {
                h.Msgwarning("EL CAMPO CUARTA CALIFICACION ES REQUERIDO");
                TxtC4.Focus();
                return;
            }

            double c1, c2, c3, c4;

            c1 = Convert.ToDouble(TxtC1.Text.Trim());
            c2 = Convert.ToDouble(TxtC2.Text.Trim());
            c3 = Convert.ToDouble(TxtC3.Text.Trim());
            c4 = Convert.ToDouble(TxtC4.Text.Trim());

            double sal = ((c1 + c2 + c3 + c4) / 4);

            TxtPromG.Text = pROMEDIO.salida(c1, c2, c3, c4, sal).ToString();



           

            if (sal >= 65)
            {
                Console.WriteLine("APROBADOS");

            }
            else
            {
                Console.WriteLine("REPROBADO");
            }



            DgvTabla.Rows.Count.ToString();









            string nombre, cal1, cal2, cal3, cal4, promg, ap, rep;

            nombre = TxtNombre.Text.Trim();
            cal1 = TxtC1.Text.Trim();
            cal2 = TxtC2.Text.Trim();
            cal3 = TxtC3.Text.Trim();
            cal4 = TxtC4.Text.Trim();
            promg = TxtPromG.Text.Trim();
            ap = TxtAp.Text.Trim();
            rep = TxtRep.Text.Trim();

            DgvTabla.Rows.Add(nombre, cal1, cal2, cal3, cal4, promg, ap, rep);


           

          


        }







        private void ClearForm()
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
                TxtNombre.Focus();
            }
        }

        private void FrmPromedio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DgvTabla.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

    

