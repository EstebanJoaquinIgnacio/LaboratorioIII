namespace ControlDeUsuario._01
{
    partial class frmHerenciaDeControles
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.textBoxColores1 = new MisControles.TextBoxColores();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(62, 185);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(132, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "&Crear Control";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // textBoxColores1
            // 
            this.textBoxColores1.BackColor = System.Drawing.Color.PaleGreen;
            this.textBoxColores1.Location = new System.Drawing.Point(78, 52);
            this.textBoxColores1.Name = "textBoxColores1";
            this.textBoxColores1.Size = new System.Drawing.Size(100, 20);
            this.textBoxColores1.TabIndex = 0;
            // 
            // frmHerenciaDeControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 222);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.textBoxColores1);
            this.Name = "frmHerenciaDeControles";
            this.Text = "Herencia de Controles";
            this.Load += new System.EventHandler(this.frmHerenciaDeControles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MisControles.TextBoxColores textBoxColores1;
        internal System.Windows.Forms.Button btnCrear;
    }
}

