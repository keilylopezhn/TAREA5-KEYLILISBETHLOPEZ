namespace TAREA5_REPASO_POO.FORMULARIOS
{
    partial class FrmPromedio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtC4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.DgvTabla = new System.Windows.Forms.DataGridView();
            this.DcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcPg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcRep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtC3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtC2 = new System.Windows.Forms.TextBox();
            this.TxtC1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPromG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtRep = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtC4
            // 
            this.TxtC4.Location = new System.Drawing.Point(371, 191);
            this.TxtC4.Margin = new System.Windows.Forms.Padding(4);
            this.TxtC4.Name = "TxtC4";
            this.TxtC4.Size = new System.Drawing.Size(173, 25);
            this.TxtC4.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 190);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "INGRESE CUARTA CALIFICACION";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(1062, 683);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(192, 46);
            this.BtnCerrar.TabIndex = 36;
            this.BtnCerrar.Text = "SALIR";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // DgvTabla
            // 
            this.DgvTabla.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DgvTabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTabla.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcNombre,
            this.DcN1,
            this.DcNd,
            this.DcNt,
            this.DcNc,
            this.DcPg,
            this.DcCant,
            this.DcRep});
            this.DgvTabla.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvTabla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DgvTabla.Location = new System.Drawing.Point(4, 262);
            this.DgvTabla.Margin = new System.Windows.Forms.Padding(4);
            this.DgvTabla.Name = "DgvTabla";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DgvTabla.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvTabla.Size = new System.Drawing.Size(938, 136);
            this.DgvTabla.TabIndex = 33;
            // 
            // DcNombre
            // 
            this.DcNombre.HeaderText = "NOMBRE COMPLETO";
            this.DcNombre.Name = "DcNombre";
            this.DcNombre.Width = 200;
            // 
            // DcN1
            // 
            this.DcN1.HeaderText = "NOTA-1";
            this.DcN1.Name = "DcN1";
            this.DcN1.Width = 70;
            // 
            // DcNd
            // 
            this.DcNd.HeaderText = "NOTA-2";
            this.DcNd.Name = "DcNd";
            this.DcNd.Width = 70;
            // 
            // DcNt
            // 
            this.DcNt.HeaderText = "NOTA-3";
            this.DcNt.Name = "DcNt";
            this.DcNt.Width = 70;
            // 
            // DcNc
            // 
            this.DcNc.HeaderText = "NOTA-4";
            this.DcNc.Name = "DcNc";
            this.DcNc.Width = 70;
            // 
            // DcPg
            // 
            this.DcPg.HeaderText = "PROMEDIO GENERAL";
            this.DcPg.Name = "DcPg";
            // 
            // DcCant
            // 
            this.DcCant.HeaderText = "CANT-APROBADOS";
            this.DcCant.Name = "DcCant";
            this.DcCant.Width = 150;
            // 
            // DcRep
            // 
            this.DcRep.HeaderText = "CANT-REPROBADOS";
            this.DcRep.Name = "DcRep";
            this.DcRep.Width = 160;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(269, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(481, 26);
            this.label6.TabIndex = 32;
            this.label6.Text = "DATOS REGISTRADOS ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtC3
            // 
            this.TxtC3.Location = new System.Drawing.Point(371, 159);
            this.TxtC3.Margin = new System.Windows.Forms.Padding(4);
            this.TxtC3.Name = "TxtC3";
            this.TxtC3.Size = new System.Drawing.Size(173, 25);
            this.TxtC3.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "INGRESE TERCER CALIFICACION ";
            // 
            // TxtC2
            // 
            this.TxtC2.Location = new System.Drawing.Point(371, 124);
            this.TxtC2.Margin = new System.Windows.Forms.Padding(4);
            this.TxtC2.Name = "TxtC2";
            this.TxtC2.Size = new System.Drawing.Size(173, 25);
            this.TxtC2.TabIndex = 29;
            // 
            // TxtC1
            // 
            this.TxtC1.Location = new System.Drawing.Point(371, 88);
            this.TxtC1.Margin = new System.Windows.Forms.Padding(4);
            this.TxtC1.Name = "TxtC1";
            this.TxtC1.Size = new System.Drawing.Size(173, 25);
            this.TxtC1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "INGRESE SEGUNDA CALIFICACION ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "INGRESE  PRIMER CALIFICACION ";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(371, 58);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(389, 25);
            this.TxtNombre.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "INGRESE EL NOMBRE DEL ESTUDIANTE";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "INGRESE VALORES PARA SALIDA DE DATOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 36);
            this.button1.TabIndex = 46;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(754, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 36);
            this.button2.TabIndex = 45;
            this.button2.Text = "AGREGAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(816, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 33);
            this.button3.TabIndex = 48;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(682, 469);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 33);
            this.button4.TabIndex = 47;
            this.button4.Text = "CANCELAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 411);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "PROMEDIO ESTUDIANTE";
            // 
            // TxtPromG
            // 
            this.TxtPromG.Location = new System.Drawing.Point(371, 404);
            this.TxtPromG.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPromG.Name = "TxtPromG";
            this.TxtPromG.ReadOnly = true;
            this.TxtPromG.Size = new System.Drawing.Size(173, 25);
            this.TxtPromG.TabIndex = 50;
            this.TxtPromG.Text = "0.00";
            this.TxtPromG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 438);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 18);
            this.label8.TabIndex = 51;
            this.label8.Text = "CANTIDAD DE APROBADOS";
            // 
            // TxtAp
            // 
            this.TxtAp.Location = new System.Drawing.Point(371, 436);
            this.TxtAp.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAp.Name = "TxtAp";
            this.TxtAp.ReadOnly = true;
            this.TxtAp.Size = new System.Drawing.Size(173, 25);
            this.TxtAp.TabIndex = 52;
            this.TxtAp.Tag = "";
            this.TxtAp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 469);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 18);
            this.label10.TabIndex = 53;
            this.label10.Text = "CANTIDAD DE REPROBADOS";
            // 
            // TxtRep
            // 
            this.TxtRep.Location = new System.Drawing.Point(371, 466);
            this.TxtRep.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRep.Name = "TxtRep";
            this.TxtRep.ReadOnly = true;
            this.TxtRep.Size = new System.Drawing.Size(173, 25);
            this.TxtRep.TabIndex = 54;
            this.TxtRep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(607, 411);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 18);
            this.label11.TabIndex = 55;
            this.label11.Text = "PROMEDIO GENERAL";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(787, 408);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(107, 25);
            this.textBox1.TabIndex = 56;
            this.textBox1.Text = "0.00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmPromedio
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 514);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtRep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtAp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtPromG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtC4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnCerrar);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPromedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "0.00";
            this.Text = "FrmPromedio";
            this.Load += new System.EventHandler(this.FrmPromedio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtC4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridView DgvTabla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtC3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtC2;
        private System.Windows.Forms.TextBox TxtC1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcPg;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcRep;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPromG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtRep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
    }
}