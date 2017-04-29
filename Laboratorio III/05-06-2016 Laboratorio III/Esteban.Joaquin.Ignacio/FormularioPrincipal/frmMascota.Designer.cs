namespace FormularioPrincipal
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
            this.cmbTipoMascota = new System.Windows.Forms.ComboBox();
            this.lblTipoMascota = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new FormularioPrincipal.SoloLetras();
            this.SuspendLayout();
            // 
            // txtEdad
            // 
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // cmbTipoMascota
            // 
            this.cmbTipoMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMascota.FormattingEnabled = true;
            this.cmbTipoMascota.Location = new System.Drawing.Point(92, 164);
            this.cmbTipoMascota.Name = "cmbTipoMascota";
            this.cmbTipoMascota.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoMascota.TabIndex = 4;
            this.cmbTipoMascota.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMascota_SelectedIndexChanged);
            // 
            // lblTipoMascota
            // 
            this.lblTipoMascota.AutoSize = true;
            this.lblTipoMascota.Location = new System.Drawing.Point(89, 139);
            this.lblTipoMascota.Name = "lblTipoMascota";
            this.lblTipoMascota.Size = new System.Drawing.Size(89, 13);
            this.lblTipoMascota.TabIndex = 6;
            this.lblTipoMascota.Text = "Tipo de mascota:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(89, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // frmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTipoMascota);
            this.Controls.Add(this.cmbTipoMascota);
            this.Name = "frmMascota";
            this.Text = "frmMascota";
            this.Load += new System.EventHandler(this.frmMascota_Load);
            this.Controls.SetChildIndex(this.cmbTipoMascota, 0);
            this.Controls.SetChildIndex(this.lblTipoMascota, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.txtEdad, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoMascota;
        private System.Windows.Forms.Label lblNombre;
        protected System.Windows.Forms.ComboBox cmbTipoMascota;
        protected SoloLetras txtNombre;
    }
}