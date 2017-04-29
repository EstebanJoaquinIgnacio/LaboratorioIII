namespace frmPrincipal
{
    partial class frmMascota
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
            this.lblTipoDeMascota = new System.Windows.Forms.Label();
            this.cmbTipoMascota = new System.Windows.Forms.ComboBox();
            this.txtNombre = new Entidades.miTextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(85, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTipoDeMascota
            // 
            this.lblTipoDeMascota.AutoSize = true;
            this.lblTipoDeMascota.Location = new System.Drawing.Point(85, 121);
            this.lblTipoDeMascota.Name = "lblTipoDeMascota";
            this.lblTipoDeMascota.Size = new System.Drawing.Size(90, 13);
            this.lblTipoDeMascota.TabIndex = 5;
            this.lblTipoDeMascota.Text = "Tipo de Mascota:";
            // 
            // cmbTipoMascota
            // 
            this.cmbTipoMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMascota.FormattingEnabled = true;
            this.cmbTipoMascota.Location = new System.Drawing.Point(88, 137);
            this.cmbTipoMascota.Name = "cmbTipoMascota";
            this.cmbTipoMascota.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoMascota.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.letraNumero = Entidades.tipoTextoPermitido.letras;
            this.txtNombre.Location = new System.Drawing.Point(88, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // frmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbTipoMascota);
            this.Controls.Add(this.lblTipoDeMascota);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmMascota";
            this.Load += new System.EventHandler(this.frmMascota_Load);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.txbEdad, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblTipoDeMascota, 0);
            this.Controls.SetChildIndex(this.cmbTipoMascota, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoDeMascota;
        protected System.Windows.Forms.ComboBox cmbTipoMascota;
        protected Entidades.miTextBox txtNombre;
    }
}