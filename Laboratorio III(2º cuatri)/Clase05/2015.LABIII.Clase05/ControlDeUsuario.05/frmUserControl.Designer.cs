namespace ControlDeUsuario._05
{
    partial class frmUserControl
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
            this.usrConvertidorCF1 = new ControlDeUsuario._05.usrConvertidorCF();
            this.SuspendLayout();
            // 
            // usrConvertidorCF1
            // 
            this.usrConvertidorCF1.Location = new System.Drawing.Point(48, 12);
            this.usrConvertidorCF1.Name = "usrConvertidorCF1";
            this.usrConvertidorCF1.Size = new System.Drawing.Size(131, 53);
            this.usrConvertidorCF1.TabIndex = 0;
            // 
            // frmUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 83);
            this.Controls.Add(this.usrConvertidorCF1);
            this.Name = "frmUserControl";
            this.Text = "User Control";
            this.ResumeLayout(false);

        }

        #endregion

        private usrConvertidorCF usrConvertidorCF1;
    }
}

