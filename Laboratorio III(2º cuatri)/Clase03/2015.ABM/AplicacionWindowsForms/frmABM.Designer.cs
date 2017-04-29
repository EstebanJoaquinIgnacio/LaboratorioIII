namespace AplicacionWindowsForms
{
    partial class frmABM
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
            this.txtDatoInteger = new System.Windows.Forms.TextBox();
            this.txtDatoString = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDatoInteger
            // 
            this.txtDatoInteger.Location = new System.Drawing.Point(134, 85);
            this.txtDatoInteger.Name = "txtDatoInteger";
            this.txtDatoInteger.Size = new System.Drawing.Size(100, 20);
            this.txtDatoInteger.TabIndex = 11;
            // 
            // txtDatoString
            // 
            this.txtDatoString.Location = new System.Drawing.Point(134, 46);
            this.txtDatoString.Name = "txtDatoString";
            this.txtDatoString.Size = new System.Drawing.Size(100, 20);
            this.txtDatoString.TabIndex = 10;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(50, 88);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "DatoInteger";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(50, 49);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "DatoString";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(159, 156);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(53, 156);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.txtDatoInteger);
            this.Controls.Add(this.txtDatoString);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmABM";
            this.Text = "frmABM";
            this.Load += new System.EventHandler(this.frmABM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtDatoInteger;
        internal System.Windows.Forms.TextBox txtDatoString;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnAceptar;
    }
}