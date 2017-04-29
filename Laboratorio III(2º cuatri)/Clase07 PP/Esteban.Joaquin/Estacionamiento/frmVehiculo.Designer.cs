namespace Estacionamiento
{
    partial class frmVehiculo
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txbPatente = new Estacionamiento.textBoxMejorado();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(32, 115);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(135, 115);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(72, 78);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 3;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(72, 13);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(47, 13);
            this.lblPatente.TabIndex = 4;
            this.lblPatente.Text = "Patente:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(72, 62);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color:";
            // 
            // txbPatente
            // 
            this.txbPatente.Location = new System.Drawing.Point(75, 30);
            this.txbPatente.Name = "txbPatente";
            this.txbPatente.Size = new System.Drawing.Size(100, 20);
            this.txbPatente.TabIndex = 6;
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 192);
            this.Controls.Add(this.txbPatente);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmVehiculo";
            this.Text = "frmVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblColor;
        protected System.Windows.Forms.Button btnAceptar;
        protected System.Windows.Forms.TextBox txtColor;
        protected textBoxMejorado txbPatente;
    }
}