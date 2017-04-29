namespace frmPrincipal
{
    partial class frmMarcaABorrar
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMarcaABorrar = new System.Windows.Forms.Label();
            this.tbxMarcaABorrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(42, 216);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(160, 216);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMarcaABorrar
            // 
            this.lblMarcaABorrar.AutoSize = true;
            this.lblMarcaABorrar.Location = new System.Drawing.Point(98, 67);
            this.lblMarcaABorrar.Name = "lblMarcaABorrar";
            this.lblMarcaABorrar.Size = new System.Drawing.Size(72, 13);
            this.lblMarcaABorrar.TabIndex = 2;
            this.lblMarcaABorrar.Text = "MarcaABorrar";
            // 
            // tbxMarcaABorrar
            // 
            this.tbxMarcaABorrar.Location = new System.Drawing.Point(84, 92);
            this.tbxMarcaABorrar.Name = "tbxMarcaABorrar";
            this.tbxMarcaABorrar.Size = new System.Drawing.Size(100, 20);
            this.tbxMarcaABorrar.TabIndex = 3;
            // 
            // frmMarcaABorrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbxMarcaABorrar);
            this.Controls.Add(this.lblMarcaABorrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmMarcaABorrar";
            this.Text = "frmMarcaABorrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMarcaABorrar;
        public System.Windows.Forms.TextBox tbxMarcaABorrar;
    }
}