namespace ControlDeUsuario._02
{
    partial class frmControlUsuarioEventos
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
            this.textBoxSoloLetraA1 = new MisControles.TextBoxSoloLetraA();
            this.SuspendLayout();
            // 
            // textBoxSoloLetraA1
            // 
            this.textBoxSoloLetraA1.BackColor = System.Drawing.Color.PaleGreen;
            this.textBoxSoloLetraA1.Location = new System.Drawing.Point(34, 107);
            this.textBoxSoloLetraA1.Name = "textBoxSoloLetraA1";
            this.textBoxSoloLetraA1.Size = new System.Drawing.Size(221, 20);
            this.textBoxSoloLetraA1.TabIndex = 0;
            this.textBoxSoloLetraA1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoloLetraA1_KeyPress);
            // 
            // frmControlUsuarioEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxSoloLetraA1);
            this.Name = "frmControlUsuarioEventos";
            this.Text = "Eventos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MisControles.TextBoxSoloLetraA textBoxSoloLetraA1;
    }
}

