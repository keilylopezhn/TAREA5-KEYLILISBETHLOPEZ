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
    public partial class FrmLitros : Form
    {
        CLASES.TANQUE tANQUE = new CLASES.TANQUE();
        public FrmLitros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (TxtTamaño.Text.Trim().Length == 0)
            {
                MessageBox.Show("LOS DATOS DE ESTE CAMPO SON REQUERIDOS");
                TxtTamaño.Focus();
            }


            double m, res;

            m = Convert.ToDouble(TxtTamaño.Text.Trim());

            res = m * 1000;


            TxtDiferencia.Text = tANQUE.Tanque(m, res).ToString();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtDiferencia.Clear();
            TxtTamaño.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
