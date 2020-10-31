namespace TAREA5_REPASO_POO.FORMULARIOS
{
    partial class FrmCalificaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtC1 = new System.Windows.Forms.TextBox();
            this.TxtC2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtC3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvTabla = new System.Windows.Forms.DataGridView();
            this.DcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcCalUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcCalD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcCalT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcProm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAgg = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSalida = new System.Windows.Forms.TextBox();
            this.BtnCancelar1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtAcum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE VALORES PARA SALIDA DE DATOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE EL NOMBRE DEL ESTUDIANTE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(387, 49);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(364, 25);
            this.TxtNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "INGRESE  PRIMER CALIFICACION DE  EXAMEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "INGRESE SEGUNDA CALIFICACION DE EXAMEN ";
            // 
            // TxtC1
            // 
            this.TxtC1.Location = new System.Drawing.Point(481, 83);
            this.TxtC1.Name = "TxtC1";
            this.TxtC1.Size = new System.Drawing.Size(134, 25);
            this.TxtC1.TabIndex = 5;
            this.TxtC1.TextChanged += new System.EventHandler(this.TxtC1_TextChanged);
            // 
            // TxtC2
            // 
            this.TxtC2.Location = new System.Drawing.Point(481, 115);
            this.TxtC2.Name = "TxtC2";
            this.TxtC2.Size = new System.Drawing.Size(134, 25);
            this.TxtC2.TabIndex = 6;
            this.TxtC2.TextChanged += new System.EventHandler(this.TxtC2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "INGRESE TERCER CALIFICACION DE EXAMEN";
            // 
            // TxtC3
            // 
            this.TxtC3.Location = new System.Drawing.Point(481, 146);
            this.TxtC3.Name = "TxtC3";
            this.TxtC3.Size = new System.Drawing.Size(134, 25);
            this.TxtC3.TabIndex = 8;
            this.TxtC3.TextChanged += new System.EventHandler(this.TxtC3_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(264, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "DATOS REGISTRADOS ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvTabla
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DgvTabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTabla.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcNombre,
            this.DcCalUno,
            this.DcCalD,
            this.DcCalT,
            this.DcProm});
            this.DgvTabla.Location = new System.Drawing.Point(12, 257);
            this.DgvTabla.Name = "DgvTabla";
            this.DgvTabla.Size = new System.Drawing.Size(835, 160);
            this.DgvTabla.TabIndex = 10;
            this.DgvTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTabla_CellContentClick);
            // 
            // DcNombre
            // 
            this.DcNombre.HeaderText = "NOMBRE COMPLETO";
            this.DcNombre.Name = "DcNombre";
            this.DcNombre.Width = 300;
            // 
            // DcCalUno
            // 
            this.DcCalUno.HeaderText = "CAL-1";
            this.DcCalUno.Name = "DcCalUno";
            this.DcCalUno.Width = 80;
            // 
            // DcCalD
            // 
            this.DcCalD.HeaderText = "CAL-2";
            this.DcCalD.Name = "DcCalD";
            this.DcCalD.Width = 80;
            // 
            // DcCalT
            // 
            this.DcCalT.HeaderText = "CAL-3";
            this.DcCalT.Name = "DcCalT";
            this.DcCalT.Width = 80;
            // 
            // DcProm
            // 
            this.DcProm.HeaderText = "PROMEDIO TOTAL";
            this.DcProm.Name = "DcProm";
            this.DcProm.Width = 250;
            // 
            // BtnAgg
            // 
            this.BtnAgg.Location = new System.Drawing.Point(691, 107);
            this.BtnAgg.Name = "BtnAgg";
            this.BtnAgg.Size = new System.Drawing.Size(128, 33);
            this.BtnAgg.TabIndex = 11;
            this.BtnAgg.Text = "AGREGAR";
            this.BtnAgg.UseVisualStyleBackColor = true;
            this.BtnAgg.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(544, 493);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(128, 33);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(691, 493);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(128, 33);
            this.BtnCerrar.TabIndex = 13;
            this.BtnCerrar.Text = "SALIR";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "PROMEDIO EN EXAMENES";
            // 
            // TxtP
            // 
            this.TxtP.Location = new System.Drawing.Point(291, 423);
            this.TxtP.Name = "TxtP";
            this.TxtP.ReadOnly = true;
            this.TxtP.Size = new System.Drawing.Size(134, 25);
            this.TxtP.TabIndex = 15;
            this.TxtP.TextChanged += new System.EventHandler(this.TxtP_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "REQUISITO DE APROBACION";
            // 
            // TxtSalida
            // 
            this.TxtSalida.Location = new System.Drawing.Point(291, 484);
            this.TxtSalida.Name = "TxtSalida";
            this.TxtSalida.ReadOnly = true;
            this.TxtSalida.Size = new System.Drawing.Size(134, 25);
            this.TxtSalida.TabIndex = 17;
            // 
            // BtnCancelar1
            // 
            this.BtnCancelar1.Location = new System.Drawing.Point(691, 146);
            this.BtnCancelar1.Name = "BtnCancelar1";
            this.BtnCancelar1.Size = new System.Drawing.Size(128, 33);
            this.BtnCancelar1.TabIndex = 18;
            this.BtnCancelar1.Text = "CANCELAR";
            this.BtnCancelar1.UseVisualStyleBackColor = true;
            this.BtnCancelar1.Click += new System.EventHandler(this.BtnCancelar1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "INGRESE NOTA ACUMULATIVA:";
            // 
            // TxtAcum
            // 
            this.TxtAcum.Location = new System.Drawing.Point(481, 177);
            this.TxtAcum.Name = "TxtAcum";
            this.TxtAcum.Size = new System.Drawing.Size(134, 25);
            this.TxtAcum.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "PROMEDIO TOTAL";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(291, 453);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(134, 25);
            this.TxtTotal.TabIndex = 22;
            // 
            // FrmCalificaciones
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(860, 530);
            this.ControlBox = false;
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtAcum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnCancelar1);
            this.Controls.Add(this.TxtSalida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgg);
            this.Controls.Add(this.DgvTabla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtC3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtC2);
            this.Controls.Add(this.TxtC1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmCalificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE EVALUACION DE ESTUDIANTES ";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtC1;
        private System.Windows.Forms.TextBox TxtC2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtC3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvTabla;
        private System.Windows.Forms.Button BtnAgg;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSalida;
        private System.Windows.Forms.Button BtnCancelar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtAcum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCalUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCalD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCalT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcProm;
    }
}