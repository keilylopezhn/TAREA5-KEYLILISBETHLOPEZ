namespace TAREA5_REPASO_POO.FORMULARIOS
{
    partial class FrmMenuPrincipal
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
            this.BtnPorcentaje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTanque = new System.Windows.Forms.Button();
            this.BtnCalif = new System.Windows.Forms.Button();
            this.BtnProm = new System.Windows.Forms.Button();
            this.BtnFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPorcentaje
            // 
            this.BtnPorcentaje.Location = new System.Drawing.Point(12, 72);
            this.BtnPorcentaje.Name = "BtnPorcentaje";
            this.BtnPorcentaje.Size = new System.Drawing.Size(297, 39);
            this.BtnPorcentaje.TabIndex = 0;
            this.BtnPorcentaje.Text = "PORCENTAJE DE GANANCIA ";
            this.BtnPorcentaje.UseVisualStyleBackColor = true;
            this.BtnPorcentaje.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "ELIJA UNA OPCION ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnTanque
            // 
            this.BtnTanque.Location = new System.Drawing.Point(12, 117);
            this.BtnTanque.Name = "BtnTanque";
            this.BtnTanque.Size = new System.Drawing.Size(297, 39);
            this.BtnTanque.TabIndex = 2;
            this.BtnTanque.Text = "TANQUE EN BASE A LITROS ";
            this.BtnTanque.UseVisualStyleBackColor = true;
            this.BtnTanque.Click += new System.EventHandler(this.BtnTanque_Click);
            // 
            // BtnCalif
            // 
            this.BtnCalif.Location = new System.Drawing.Point(12, 162);
            this.BtnCalif.Name = "BtnCalif";
            this.BtnCalif.Size = new System.Drawing.Size(297, 39);
            this.BtnCalif.TabIndex = 3;
            this.BtnCalif.Text = "CALIFICACION DE ESTUDIANTES";
            this.BtnCalif.UseVisualStyleBackColor = true;
            this.BtnCalif.Click += new System.EventHandler(this.BtnCalif_Click);
            // 
            // BtnProm
            // 
            this.BtnProm.Location = new System.Drawing.Point(12, 207);
            this.BtnProm.Name = "BtnProm";
            this.BtnProm.Size = new System.Drawing.Size(297, 39);
            this.BtnProm.TabIndex = 4;
            this.BtnProm.Text = "PROMEDIO GENERAL ESTUDIANTE";
            this.BtnProm.UseVisualStyleBackColor = true;
            this.BtnProm.Click += new System.EventHandler(this.BtnProm_Click);
            // 
            // BtnFactura
            // 
            this.BtnFactura.Location = new System.Drawing.Point(12, 252);
            this.BtnFactura.Name = "BtnFactura";
            this.BtnFactura.Size = new System.Drawing.Size(297, 39);
            this.BtnFactura.TabIndex = 5;
            this.BtnFactura.Text = "FACTURA ";
            this.BtnFactura.UseVisualStyleBackColor = true;
            this.BtnFactura.Click += new System.EventHandler(this.BtnFactura_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(322, 335);
            this.Controls.Add(this.BtnFactura);
            this.Controls.Add(this.BtnProm);
            this.Controls.Add(this.BtnCalif);
            this.Controls.Add(this.BtnTanque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPorcentaje);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPorcentaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnTanque;
        private System.Windows.Forms.Button BtnCalif;
        private System.Windows.Forms.Button BtnProm;
        private System.Windows.Forms.Button BtnFactura;
    }
}