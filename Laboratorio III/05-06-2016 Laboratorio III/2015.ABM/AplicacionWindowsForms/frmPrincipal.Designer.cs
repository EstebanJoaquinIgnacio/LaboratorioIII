namespace AplicacionWindowsForms
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAlta = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(12, 266);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 3;
            this.btnAlta.Text = "&Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(12, 12);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(279, 238);
            this.lstLista.TabIndex = 2;
            this.lstLista.SelectedIndexChanged += new System.EventHandler(this.lstLista_SelectedIndexChanged_1);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(116, 266);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 4;
            this.btnBaja.Text = "&Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click_1);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(216, 266);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(75, 23);
            this.btnModificacion.TabIndex = 5;
            this.btnModificacion.Text = "&Modificación";
            this.btnModificacion.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 305);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.lstLista);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnAlta;
        internal System.Windows.Forms.ListBox lstLista;
        internal System.Windows.Forms.Button btnBaja;
        internal System.Windows.Forms.Button btnModificacion;
    }
}

