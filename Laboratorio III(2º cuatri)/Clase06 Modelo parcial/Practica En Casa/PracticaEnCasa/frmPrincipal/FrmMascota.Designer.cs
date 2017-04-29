namespace frmPrincipal
{
    partial class FrmMascota
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbTipoMascota = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txbNombre = new frmPrincipal.miTextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(91, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // cmbTipoMascota
            // 
            this.cmbTipoMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMascota.FormattingEnabled = true;
            this.cmbTipoMascota.Location = new System.Drawing.Point(94, 134);
            this.cmbTipoMascota.Name = "cmbTipoMascota";
            this.cmbTipoMascota.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoMascota.TabIndex = 6;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(91, 118);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(75, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo Mascota:";
            // 
            // txbNombre
            // 
            this.txbNombre.Filtro = frmPrincipal.letraNumero.letra;
            this.txbNombre.Location = new System.Drawing.Point(94, 92);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 8;
            // 
            // FrmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipoMascota);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmMascota";
            this.Text = "FrmMascota";
            this.Load += new System.EventHandler(this.FrmMascota_Load);
            this.Controls.SetChildIndex(this.txbEdad, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.cmbTipoMascota, 0);
            this.Controls.SetChildIndex(this.lblTipo, 0);
            this.Controls.SetChildIndex(this.txbNombre, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbTipoMascota;
        private System.Windows.Forms.Label lblTipo;
        protected miTextBox txbNombre;
    }
}