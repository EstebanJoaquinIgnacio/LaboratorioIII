namespace ControlDeUsuario._05
{
    partial class usrConvertidorCF
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCelcius = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCelcius
            // 
            this.lblCelcius.AutoSize = true;
            this.lblCelcius.Location = new System.Drawing.Point(3, 6);
            this.lblCelcius.Name = "lblCelcius";
            this.lblCelcius.Size = new System.Drawing.Size(18, 13);
            this.lblCelcius.TabIndex = 0;
            this.lblCelcius.Text = "°C";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(3, 32);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(17, 13);
            this.lblFahrenheit.TabIndex = 1;
            this.lblFahrenheit.Text = "°F";
            // 
            // txtCelcius
            // 
            this.txtCelcius.Location = new System.Drawing.Point(27, 3);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(100, 20);
            this.txtCelcius.TabIndex = 2;
            this.txtCelcius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelcius_KeyPress);
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(27, 29);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.ReadOnly = true;
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 3;
            // 
            // usrConvertidorCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCelcius);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblCelcius);
            this.Name = "usrConvertidorCF";
            this.Size = new System.Drawing.Size(131, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCelcius;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.TextBox txtCelcius;
        private System.Windows.Forms.TextBox txtFahrenheit;
    }
}
