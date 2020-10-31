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
    public partial class FrmFactura : Form
    {
        CLASES.FACTURA f = new CLASES.FACTURA();
        CLASES.HELPERS h = new CLASES.HELPERS();
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DgvTabla.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtCod.Clear();
            TxtNombre.Clear();
            TxtCant.Clear();
            TxtDescripcion.Clear();
            TxtDireccion.Clear();
            TxtISV.Clear();
            TxtPrecio.Clear();
            TxtProducto.Clear();
            TxtSub.Clear();
            TxtTotalP.Clear();
            TxtTelefono.Clear();
        }

        private void BtnAgg_Click(object sender, EventArgs e)
        {
            if (TxtCod.Text.Trim().Length == 0)
            {
                h.Msgwarning("EL CAMPO NOMBRE ES REQUERIDO");
                TxtCod.Focus();
                return;
            }
            if (TxtNombre.Text.Trim().Length == 0)
            {
                h.Msgwarning("ESTE  CAMPO ES REQUERIDO");
                TxtNombre.Focus();
                return;
            }
            if (TxtDescripcion.Text.Trim().Length == 0)
            {
                h.Msgwarning("ESTE CAMPO ES REQUERIDO");
                TxtDescripcion.Focus();
                return;
            }
            if (TxtDireccion.Text.Trim().Length == 0)
            {
                h.Msgwarning("ESTE CAMPO ES REQUERIDO");
                TxtDireccion.Focus();
                return;
            }
           
            if (TxtPrecio.Text.Trim().Length == 0)
            {
                h.Msgwarning("ESTE CAMPO ES REQUERIDO");
                TxtPrecio.Focus();
                return;
            }
            if (TxtProducto.Text.Trim().Length == 0)
            {
                h.Msgwarning("ESTE CAMPO ES REQUERIDO");
                TxtProducto.Focus();
                return;
            }
           
            
            if (TxtTelefono.Text.Trim().Length == 0)
            {
                h.Msgwarning("ESTE CAMPO ES REQUERIDO");
                TxtTelefono.Focus();
                return;
            }

            double c, p;

            c = Convert.ToDouble(TxtCant.Text.Trim());
            p = Convert.ToDouble(TxtPrecio.Text.Trim());
           

            double sub=c*p;

            TxtSub.Text = f.Subtotal(c,p).ToString();

            double impto;
            sub = Convert.ToDouble(TxtSub.Text.Trim());
             impto = sub * 0.15;

            TxtISV.Text = f.Impuesto(impto, sub).ToString();

            double total;

            total = sub + impto;

            TxtTotalP.Text = f.Total(total,sub=0).ToString();

          




            string cod,nom,dir,tel,prod,desc,cant,prec,tp;
            cod = TxtCod.Text.Trim();
            nom = TxtNombre.Text.Trim();
            dir = TxtDireccion.Text.Trim();
            tel = TxtTelefono.Text.Trim();
            prod= TxtProducto.Text.Trim();
            desc= TxtDescripcion.Text.Trim();
            cant = TxtCant.Text.Trim();
            prec= TxtPrecio.Text.Trim();
            tp = TxtTotalP.Text.Trim();
            DgvTabla.Rows.Add(cod, nom, dir, tel, prod, desc, cant, prec, tp);


           



        }

      
    }  }

