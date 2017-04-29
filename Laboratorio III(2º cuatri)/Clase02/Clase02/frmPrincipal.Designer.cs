namespace Clase02
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
            this.lstListado = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aLTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstListado
            // 
            this.lstListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstListado.FormattingEnabled = true;
            this.lstListado.Location = new System.Drawing.Point(91, 104);
            this.lstListado.Margin = new System.Windows.Forms.Padding(50, 75, 50, 50);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(330, 108);
            this.lstListado.TabIndex = 0;
            this.lstListado.SelectedIndexChanged += new System.EventHandler(this.lstListado_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLTAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aLTAToolStripMenuItem
            // 
            this.aLTAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaToolStripMenuItem,
            this.alumnoToolStripMenuItem});
            this.aLTAToolStripMenuItem.Name = "aLTAToolStripMenuItem";
            this.aLTAToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aLTAToolStripMenuItem.Text = "ALTA";
            // 
            // personaToolStripMenuItem
            // 
            this.personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            this.personaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.personaToolStripMenuItem.Text = "Persona";
            this.personaToolStripMenuItem.Click += new System.EventHandler(this.personaToolStripMenuItem_Click);
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 283);
            this.Controls.Add(this.lstListado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Frm Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aLTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
    }
}

