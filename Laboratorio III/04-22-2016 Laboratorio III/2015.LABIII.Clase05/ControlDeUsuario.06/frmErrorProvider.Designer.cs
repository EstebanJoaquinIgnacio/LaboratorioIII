namespace ControlDeUsuario._06
{
    partial class frmErrorProvider
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.usrTextBoxErrorProvider1 = new ControlDeUsuario._06.usrTextBoxErrorProvider();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(33, 135);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(219, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Nombre y Apellido";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // usrTextBoxErrorProvider1
            // 
            this.usrTextBoxErrorProvider1.Location = new System.Drawing.Point(40, 33);
            this.usrTextBoxErrorProvider1.Name = "usrTextBoxErrorProvider1";
            this.usrTextBoxErrorProvider1.Size = new System.Drawing.Size(219, 54);
            this.usrTextBoxErrorProvider1.TabIndex = 0;
            // 
            // frmErrorProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 188);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.usrTextBoxErrorProvider1);
            this.Name = "frmErrorProvider";
            this.Text = "Error Provider";
            this.ResumeLayout(false);

        }

        #endregion

        private usrTextBoxErrorProvider usrTextBoxErrorProvider1;
        private System.Windows.Forms.Button btnMostrar;
    }
}

