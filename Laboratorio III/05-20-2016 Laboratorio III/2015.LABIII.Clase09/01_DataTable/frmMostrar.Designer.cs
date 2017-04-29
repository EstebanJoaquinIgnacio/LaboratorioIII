namespace _01_DataTable
{
    partial class frmMostrar
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
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVisor.Location = new System.Drawing.Point(13, 8);
            this.txtVisor.Multiline = true;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(435, 203);
            this.txtVisor.TabIndex = 1;
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 219);
            this.Controls.Add(this.txtVisor);
            this.Name = "frmMostrar";
            this.Text = "frmMostrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtVisor;
    }
}