namespace frmPrincipal
{
    partial class frmCuentaOffShore
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
            this.cmbParaisoFiscal = new System.Windows.Forms.ComboBox();
            this.lblParaisoFiscal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbParaisoFiscal
            // 
            this.cmbParaisoFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParaisoFiscal.FormattingEnabled = true;
            this.cmbParaisoFiscal.Location = new System.Drawing.Point(102, 145);
            this.cmbParaisoFiscal.Name = "cmbParaisoFiscal";
            this.cmbParaisoFiscal.Size = new System.Drawing.Size(121, 21);
            this.cmbParaisoFiscal.TabIndex = 6;
            // 
            // lblParaisoFiscal
            // 
            this.lblParaisoFiscal.AutoSize = true;
            this.lblParaisoFiscal.Location = new System.Drawing.Point(19, 153);
            this.lblParaisoFiscal.Name = "lblParaisoFiscal";
            this.lblParaisoFiscal.Size = new System.Drawing.Size(77, 13);
            this.lblParaisoFiscal.TabIndex = 7;
            this.lblParaisoFiscal.Text = "Paraíso Fiscal:";
            // 
            // frmCuentaOffShore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.lblParaisoFiscal);
            this.Controls.Add(this.cmbParaisoFiscal);
            this.Name = "frmCuentaOffShore";
            this.Text = "frmCuentaOffShore";
            this.Load += new System.EventHandler(this.frmCuentaOffShore_Load);
            
            this.Controls.SetChildIndex(this.cmbParaisoFiscal, 0);
            this.Controls.SetChildIndex(this.lblParaisoFiscal, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParaisoFiscal;
        protected System.Windows.Forms.ComboBox cmbParaisoFiscal;
    }
}