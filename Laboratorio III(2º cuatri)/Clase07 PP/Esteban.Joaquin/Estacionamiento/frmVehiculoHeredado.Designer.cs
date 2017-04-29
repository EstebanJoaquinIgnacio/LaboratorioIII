namespace Estacionamiento
{
    partial class frmVehiculoHeredado
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
            this.lblCosto = new System.Windows.Forms.Label();
            this.txbCosto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(75, 145);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(37, 13);
            this.lblCosto.TabIndex = 6;
            this.lblCosto.Text = "Costo:";
            // 
            // txbCosto
            // 
            this.txbCosto.Location = new System.Drawing.Point(78, 162);
            this.txbCosto.Name = "txbCosto";
            this.txbCosto.Size = new System.Drawing.Size(100, 20);
            this.txbCosto.TabIndex = 7;
            // 
            // frmVehiculoHeredado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 192);
            this.Controls.Add(this.txbCosto);
            this.Controls.Add(this.lblCosto);
            this.Name = "frmVehiculoHeredado";
            this.Text = "frmVehiculoHeredado";
            this.Load += new System.EventHandler(this.frmVehiculoHeredado_Load);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.txbPatente, 0);
            this.Controls.SetChildIndex(this.txtColor, 0);
            this.Controls.SetChildIndex(this.lblCosto, 0);
            this.Controls.SetChildIndex(this.txbCosto, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txbCosto;
    }
}