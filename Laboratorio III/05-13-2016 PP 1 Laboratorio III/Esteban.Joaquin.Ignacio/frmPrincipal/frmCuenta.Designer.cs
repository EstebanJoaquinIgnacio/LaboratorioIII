namespace frmPrincipal
{
    partial class frmCuenta
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
            this.lblNroCuenta = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.txtNroCuenta = new ControlesMios.SoloNumeros();
            this.txtTitular = new ControlesMios.SoloLetras();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(42, 210);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(161, 209);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblNroCuenta
            // 
            this.lblNroCuenta.AutoSize = true;
            this.lblNroCuenta.Location = new System.Drawing.Point(42, 71);
            this.lblNroCuenta.Name = "lblNroCuenta";
            this.lblNroCuenta.Size = new System.Drawing.Size(64, 13);
            this.lblNroCuenta.TabIndex = 2;
            this.lblNroCuenta.Text = "Nro Cuenta:";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(42, 121);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(39, 13);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular:";
            // 
            // txtNroCuenta
            // 
            this.txtNroCuenta.Location = new System.Drawing.Point(102, 71);
            this.txtNroCuenta.Name = "txtNroCuenta";
            this.txtNroCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtNroCuenta.TabIndex = 7;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(102, 114);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 20);
            this.txtTitular.TabIndex = 8;
            // 
            // frmCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.txtNroCuenta);
            this.Controls.Add(this.lblTitular);
            this.Controls.Add(this.lblNroCuenta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmCuenta";
            this.Text = "frmCuenta";
            this.Load += new System.EventHandler(this.frmCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNroCuenta;
        private System.Windows.Forms.Label lblTitular;
        protected ControlesMios.SoloNumeros txtNroCuenta;
        protected ControlesMios.SoloLetras txtTitular;
       // private SoloLetras soloLetras1;
        
    }
}