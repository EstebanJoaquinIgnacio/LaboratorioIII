namespace _02_WindowsForm.Controles
{
    partial class frmInicio
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
            this.grpSeleccion = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboEjemplos = new System.Windows.Forms.ComboBox();
            this.grpSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSeleccion
            // 
            this.grpSeleccion.Controls.Add(this.lblTitulo);
            this.grpSeleccion.Controls.Add(this.cboEjemplos);
            this.grpSeleccion.Location = new System.Drawing.Point(12, 12);
            this.grpSeleccion.Name = "grpSeleccion";
            this.grpSeleccion.Size = new System.Drawing.Size(351, 120);
            this.grpSeleccion.TabIndex = 1;
            this.grpSeleccion.TabStop = false;
            this.grpSeleccion.Text = "Seleccionar Ejemplo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(34, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Ejemplo:";
            // 
            // cboEjemplos
            // 
            this.cboEjemplos.FormattingEnabled = true;
            this.cboEjemplos.Location = new System.Drawing.Point(87, 46);
            this.cboEjemplos.Name = "cboEjemplos";
            this.cboEjemplos.Size = new System.Drawing.Size(199, 21);
            this.cboEjemplos.TabIndex = 0;
            this.cboEjemplos.SelectedIndexChanged += new System.EventHandler(this.cboEjemplos_SelectedIndexChanged);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 153);
            this.Controls.Add(this.grpSeleccion);
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.grpSeleccion.ResumeLayout(false);
            this.grpSeleccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpSeleccion;
        internal System.Windows.Forms.Label lblTitulo;
        internal System.Windows.Forms.ComboBox cboEjemplos;
    }
}

