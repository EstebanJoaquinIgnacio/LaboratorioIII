namespace FormularioPrincipal
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
            this.ltbMostrar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ltbMostrar
            // 
            this.ltbMostrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltbMostrar.FormattingEnabled = true;
            this.ltbMostrar.Location = new System.Drawing.Point(13, 13);
            this.ltbMostrar.Name = "ltbMostrar";
            this.ltbMostrar.Size = new System.Drawing.Size(259, 234);
            this.ltbMostrar.TabIndex = 0;
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ltbMostrar);
            this.Name = "frmMostrar";
            this.Text = "frmMostrar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltbMostrar;
    }
}