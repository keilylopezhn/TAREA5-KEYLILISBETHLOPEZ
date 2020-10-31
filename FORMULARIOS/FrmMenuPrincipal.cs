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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmPorcentaje por = new FORMULARIOS.FrmPorcentaje();
            por.Show();
        }

        private void BtnTanque_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmLitros tanque = new FORMULARIOS.FrmLitros();
            tanque.Show();
        }

        private void BtnCalif_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmCalificaciones cali = new FORMULARIOS.FrmCalificaciones();
            cali.Show();
        }

        private void BtnProm_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmPromedio prom = new FORMULARIOS.FrmPromedio();
            prom.Show();
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmFactura factura = new FORMULARIOS.FrmFactura();
            factura.Show();
        }
    }
}
