using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA5_REPASO_POO.FORMULARIOS
{
    public partial class FrmCalificaciones : Form
    {
        CLASES.HELPERS h = new CLASES.HELPERS();

        CLASES.CALIFICACION cal = new CLASES.CALIFICACION();
        public FrmCalificaciones()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c1, c2, c3, prom, na, acum;


            c1 = Convert.ToDouble(TxtC1.Text.Trim());
            c2 = Convert.ToDouble(TxtC2.Text.Trim());
            c3 = Convert.ToDouble(TxtC3.Text.Trim());
            na = Convert.ToDouble(TxtAcum.Text.Trim());
            prom = (c1 + c2 + c3) / 3;
            acum = na + prom;

            if (acum > 65)
            {
                TxtSalida.Text = MessageBox.Show("APROBO").ToString();
            }
            else
            {
                TxtSalida.Text = MessageBox.Show( "REPROBO").ToString();
            }

            TxtP.Text =prom.ToString();
            TxtAcum.Text = na .ToString();
            TxtTotal.Text = acum.ToString();

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

        }

        private void TxtP_TextChanged(object sender, EventArgs e)
        {
            if (TxtP.Text.Trim().Length == 0)
            {
                h.Alert(TxtP.Text.Trim());
            }
        }

        private void TxtC1_TextChanged(object sender, EventArgs e)
        {
            if (h.CheifisNumber(TxtC1.Text.Trim())=="N")
            {
                h.Msgwarning("EL VALOR  PRIMER CALIFICACION DEBE SER NUMERICO");
                TxtC1.Focus();
                return;
            }
        }

        private void TxtC2_TextChanged(object sender, EventArgs e)
        {

            if (h.CheifisNumber(TxtC2.Text.Trim()) == "N")
            {
                h.Msgwarning("EL VALOR SEGUNDA CALIFICACION DEBE SER NUMERICO");
                TxtC2.Focus();
                return;
            }
        }

        private void TxtC3_TextChanged(object sender, EventArgs e)
        {

            if (h.CheifisNumber(TxtC3.Text.Trim()) == "N")
            {
                h.Msgwarning("EL VALOR TERCER CALIFICACION DEBE SER NUMERICO");
                TxtC3.Focus();
                return;
            }

            string nombre, cal1, cal2, cal3, promedio;
            nombre = TxtNombre.Text.Trim();
            cal1 = TxtC1.Text.Trim();
            cal2 = TxtC2.Text.Trim();
            cal3 = TxtC3.Text.Trim();
            promedio = TxtTotal.Text.Trim();

           
             

            DgvTabla.Rows.Add(nombre, cal1, cal2, cal3, promedio);
        }

        private void ClearForm()
        {
            foreach (TextBox Txt in this.Controls.OfType<TextBox>())
            {
                Txt.Clear();
            }
            TxtNombre.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DgvTabla.Rows.Clear();
           
                }

        private void DgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCancelar1_Click(object sender, EventArgs e)
        {
            TxtC1.Clear();
            TxtC2.Clear();
            TxtC3.Clear();
            TxtNombre.Clear();
            TxtTotal.Clear();
            TxtP.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

