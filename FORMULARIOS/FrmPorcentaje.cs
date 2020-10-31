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
    public partial class FrmPorcentaje : Form
    {
        CLASES.PORCENTAJE pORCENTAJE = new CLASES.PORCENTAJE();
        public FrmPorcentaje()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            double c1, c2;


            c1 = Convert.ToDouble(TxtCompra.Text.Trim());
            c2 = Convert.ToDouble(TxtVenta.Text.Trim());


            double dif;
           
            double por;

            dif = (c2 - c1);
            por = (dif / c2) * 100;

            TxtDiferencia.Text = pORCENTAJE.resta(c1, c2, dif).ToString();
            TxtPorcentaje.Text = pORCENTAJE.porcent(c1,c2, dif, por).ToString();


            if (TxtNombre.Text.Trim().Length==0)
            {
                MessageBox.Show("LOS DATOS DE ESTE CAMPO SON REQUERIDOS");
                TxtNombre.Focus();

            }
            if (TxtCompra.Text.Trim().Length == 0)
            {
                MessageBox.Show("LOS DATOS DE ESTE CAMPO SON REQUERIDOS");
                TxtCompra.Focus();

            }
            if (TxtVenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("LOS DATOS DE ESTE CAMPO SON REQUERIDOS");
                TxtVenta.Focus();

            }

           
           
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtCompra.Clear();
            TxtDiferencia.Clear();
            TxtNombre.Clear();
            TxtPorcentaje.Clear();
            TxtVenta.Clear();
        }
    }
}

