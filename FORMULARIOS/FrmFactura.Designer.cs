namespace TAREA5_REPASO_POO.FORMULARIOS
{
    partial class FrmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCant = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnAgg = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DgvTabla = new System.Windows.Forms.DataGridView();
            this.ClmCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDireccio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTotalp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSub = new System.Windows.Forms.TextBox();
            this.TxtISV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtTotalP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO FACTURA";
            // 
            // TxtCod
            // 
            this.TxtCod.Location = new System.Drawing.Point(390, 23);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.Size = new System.Drawing.Size(105, 25);
            this.TxtCod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE DEL CLIENTE";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(390, 54);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(332, 25);
            this.TxtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "DIRECCION";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(390, 83);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(332, 44);
            this.TxtDireccion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(742, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "TELEFONO";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(839, 51);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(114, 25);
            this.TxtTelefono.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "NOMBRE DEL PRODUCTO";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(390, 133);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(332, 25);
            this.TxtProducto.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "DESCRIPCION PRODUCTO";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(390, 163);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(332, 51);
            this.TxtDescripcion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "CANTIDAD DEL PRODUCTO";
            // 
            // TxtCant
            // 
            this.TxtCant.Location = new System.Drawing.Point(390, 220);
            this.TxtCant.Name = "TxtCant";
            this.TxtCant.Size = new System.Drawing.Size(132, 25);
            this.TxtCant.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "PRECIO DEL PRODUCTO";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(390, 251);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(132, 25);
            this.TxtPrecio.TabIndex = 15;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(839, 21);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(114, 25);
            this.DtpFecha.TabIndex = 16;
            this.DtpFecha.Value = new System.DateTime(2020, 10, 30, 10, 49, 48, 0);
            this.DtpFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(742, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "FECHA";
            // 
            // BtnAgg
            // 
            this.BtnAgg.Location = new System.Drawing.Point(799, 106);
            this.BtnAgg.Name = "BtnAgg";
            this.BtnAgg.Size = new System.Drawing.Size(139, 32);
            this.BtnAgg.TabIndex = 18;
            this.BtnAgg.Text = "AGREGAR";
            this.BtnAgg.UseVisualStyleBackColor = true;
            this.BtnAgg.Click += new System.EventHandler(this.BtnAgg_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(799, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "LIMPIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(799, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 32);
            this.button3.TabIndex = 20;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DgvTabla
            // 
            this.DgvTabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCod,
            this.ClmNombre,
            this.ClmDireccio,
            this.ClmTelefono,
            this.ClmProducto,
            this.ClmDescripcion,
            this.ClmCantidad,
            this.ClmPrecio,
            this.ClmTotalp});
            this.DgvTabla.Location = new System.Drawing.Point(-1, 295);
            this.DgvTabla.Name = "DgvTabla";
            this.DgvTabla.Size = new System.Drawing.Size(1115, 196);
            this.DgvTabla.TabIndex = 21;
            // 
            // ClmCod
            // 
            this.ClmCod.HeaderText = "COD.";
            this.ClmCod.Name = "ClmCod";
            this.ClmCod.Width = 50;
            // 
            // ClmNombre
            // 
            this.ClmNombre.HeaderText = "NOMBRE CLIENTE";
            this.ClmNombre.Name = "ClmNombre";
            this.ClmNombre.Width = 200;
            // 
            // ClmDireccio
            // 
            this.ClmDireccio.HeaderText = "DIRECCION";
            this.ClmDireccio.Name = "ClmDireccio";
            this.ClmDireccio.Width = 200;
            // 
            // ClmTelefono
            // 
            this.ClmTelefono.HeaderText = "TELEFONO";
            this.ClmTelefono.Name = "ClmTelefono";
            // 
            // ClmProducto
            // 
            this.ClmProducto.HeaderText = "NOMBRE PRODUCTO";
            this.ClmProducto.Name = "ClmProducto";
            this.ClmProducto.Width = 150;
            // 
            // ClmDescripcion
            // 
            this.ClmDescripcion.HeaderText = "DESCRIPCION";
            this.ClmDescripcion.Name = "ClmDescripcion";
            this.ClmDescripcion.Width = 150;
            // 
            // ClmCantidad
            // 
            this.ClmCantidad.HeaderText = "CANT.";
            this.ClmCantidad.Name = "ClmCantidad";
            this.ClmCantidad.Width = 70;
            // 
            // ClmPrecio
            // 
            this.ClmPrecio.HeaderText = "PRECIO";
            this.ClmPrecio.Name = "ClmPrecio";
            this.ClmPrecio.Width = 70;
            // 
            // ClmTotalp
            // 
            this.ClmTotalp.HeaderText = "TOTAL A PAGAR";
            this.ClmTotalp.Name = "ClmTotalp";
            this.ClmTotalp.Width = 80;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 501);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "SUB-TOTAL";
            // 
            // TxtSub
            // 
            this.TxtSub.Location = new System.Drawing.Point(201, 498);
            this.TxtSub.Name = "TxtSub";
            this.TxtSub.Size = new System.Drawing.Size(116, 25);
            this.TxtSub.TabIndex = 23;
            // 
            // TxtISV
            // 
            this.TxtISV.Location = new System.Drawing.Point(447, 498);
            this.TxtISV.Name = "TxtISV";
            this.TxtISV.Size = new System.Drawing.Size(116, 25);
            this.TxtISV.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(387, 501);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "I.S.V";
            // 
            // TxtTotalP
            // 
            this.TxtTotalP.Location = new System.Drawing.Point(770, 502);
            this.TxtTotalP.Name = "TxtTotalP";
            this.TxtTotalP.Size = new System.Drawing.Size(116, 25);
            this.TxtTotalP.TabIndex = 27;
            this.TxtTotalP.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(637, 505);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "TOTAL A PAGAR";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(946, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 32);
            this.button1.TabIndex = 28;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1132, 529);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtTotalP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtISV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtSub);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DgvTabla);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAgg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtCant);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCod);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                                                                                " +
    "   FACTURA COMERCIAL ";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnAgg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView DgvTabla;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSub;
        private System.Windows.Forms.TextBox TxtISV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtTotalP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDireccio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTotalp;
    }
}