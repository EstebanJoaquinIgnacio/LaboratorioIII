namespace Estacionamiento
{
    partial class frmPrincipal
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
            this.lsbPrincipal = new System.Windows.Forms.ListBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lsbPrincipal
            // 
            this.lsbPrincipal.FormattingEnabled = true;
            this.lsbPrincipal.Location = new System.Drawing.Point(13, 13);
            this.lsbPrincipal.Name = "lsbPrincipal";
            this.lsbPrincipal.Size = new System.Drawing.Size(276, 173);
            this.lsbPrincipal.TabIndex = 0;
            this.lsbPrincipal.SelectedIndexChanged += new System.EventHandler(this.lsbPrincipal_SelectedIndexChanged);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(13, 214);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnIngreso.TabIndex = 1;
            this.btnIngreso.Text = "Ingreso";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(94, 215);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(75, 23);
            this.btnSalida.TabIndex = 2;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Location = new System.Drawing.Point(172, 199);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(67, 13);
            this.lblOrdenar.TabIndex = 3;
            this.lblOrdenar.Text = "Ordenar Por:";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Location = new System.Drawing.Point(175, 215);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenar.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 262);
            this.Controls.Add(this.cmbOrdenar);
            this.Controls.Add(this.lblOrdenar);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.lsbPrincipal);
            this.Name = "frmPrincipal";
            this.Text = "FormPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbPrincipal;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.ComboBox cmbOrdenar;
    }
}

