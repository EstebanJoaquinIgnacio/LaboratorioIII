namespace ControlDeUsuario._04
{
    partial class frmEnumerados
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
            this.textBoxMayusculaMinuscula1 = new MisControles.TextBoxMayusculaMinuscula();
            this.textBoxMayusculaMinuscula2 = new MisControles.TextBoxMayusculaMinuscula();
            this.textBoxMayusculaMinuscula3 = new MisControles.TextBoxMayusculaMinuscula();
            this.SuspendLayout();
            // 
            // textBoxMayusculaMinuscula1
            // 
            this.textBoxMayusculaMinuscula1.Location = new System.Drawing.Point(36, 76);
            this.textBoxMayusculaMinuscula1.Name = "textBoxMayusculaMinuscula1";
            this.textBoxMayusculaMinuscula1.Size = new System.Drawing.Size(214, 20);
            this.textBoxMayusculaMinuscula1.TabIndex = 0;
            this.textBoxMayusculaMinuscula1.TipoDeTexto = MisControles.TipoTexto.Ninguno;
            // 
            // textBoxMayusculaMinuscula2
            // 
            this.textBoxMayusculaMinuscula2.Location = new System.Drawing.Point(36, 120);
            this.textBoxMayusculaMinuscula2.Name = "textBoxMayusculaMinuscula2";
            this.textBoxMayusculaMinuscula2.Size = new System.Drawing.Size(214, 20);
            this.textBoxMayusculaMinuscula2.TabIndex = 1;
            this.textBoxMayusculaMinuscula2.TipoDeTexto = MisControles.TipoTexto.Minúscula;
            // 
            // textBoxMayusculaMinuscula3
            // 
            this.textBoxMayusculaMinuscula3.Location = new System.Drawing.Point(36, 166);
            this.textBoxMayusculaMinuscula3.Name = "textBoxMayusculaMinuscula3";
            this.textBoxMayusculaMinuscula3.Size = new System.Drawing.Size(214, 20);
            this.textBoxMayusculaMinuscula3.TabIndex = 2;
            this.textBoxMayusculaMinuscula3.TipoDeTexto = MisControles.TipoTexto.Mayúscula;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxMayusculaMinuscula3);
            this.Controls.Add(this.textBoxMayusculaMinuscula2);
            this.Controls.Add(this.textBoxMayusculaMinuscula1);
            this.Name = "Form1";
            this.Text = "Enumerados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MisControles.TextBoxMayusculaMinuscula textBoxMayusculaMinuscula1;
        private MisControles.TextBoxMayusculaMinuscula textBoxMayusculaMinuscula2;
        private MisControles.TextBoxMayusculaMinuscula textBoxMayusculaMinuscula3;
    }
}

