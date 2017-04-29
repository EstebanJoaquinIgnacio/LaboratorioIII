namespace Aeropuerto
{
    partial class frmAvion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMatricula);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.lblModelo);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.lblCapacidad);
            this.groupBox1.Controls.Add(this.txtCapacidad);
            this.groupBox1.Controls.Add(this.lblDestino);
            this.groupBox1.Controls.Add(this.cmbDestino);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Avión";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(16, 39);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(53, 13);
            this.lblMatricula.TabIndex = 14;
            this.lblMatricula.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(16, 56);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(216, 20);
            this.txtMatricula.TabIndex = 15;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(19, 94);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(19, 111);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(216, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(19, 149);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 8;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(19, 165);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(216, 20);
            this.txtModelo.TabIndex = 9;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(19, 204);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(61, 13);
            this.lblCapacidad.TabIndex = 12;
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(19, 219);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(216, 20);
            this.txtCapacidad.TabIndex = 13;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(19, 259);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(46, 13);
            this.lblDestino.TabIndex = 10;
            this.lblDestino.Text = "Destino:";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(19, 273);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(216, 21);
            this.cmbDestino.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(34, 353);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(175, 353);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // frmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmAvion";
            this.Text = "Cambiar el texto o 1pto menos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
    }
}