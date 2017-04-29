namespace frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aLTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bAJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbmOrdenar = new System.Windows.Forms.ComboBox();
            this.lsbMascota = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLTAToolStripMenuItem,
            this.bAJAToolStripMenuItem,
            this.modificacionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aLTAToolStripMenuItem
            // 
            this.aLTAToolStripMenuItem.Name = "aLTAToolStripMenuItem";
            this.aLTAToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.aLTAToolStripMenuItem.Text = "Alta";
            this.aLTAToolStripMenuItem.Click += new System.EventHandler(this.aLTAToolStripMenuItem_Click);
            // 
            // bAJAToolStripMenuItem
            // 
            this.bAJAToolStripMenuItem.Name = "bAJAToolStripMenuItem";
            this.bAJAToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.bAJAToolStripMenuItem.Text = "Baja";
            this.bAJAToolStripMenuItem.Click += new System.EventHandler(this.bAJAToolStripMenuItem_Click);
            // 
            // modificacionToolStripMenuItem
            // 
            this.modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            this.modificacionToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.modificacionToolStripMenuItem.Text = "Modificacion";
            this.modificacionToolStripMenuItem.Click += new System.EventHandler(this.modificacionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cbmOrdenar
            // 
            this.cbmOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmOrdenar.FormattingEnabled = true;
            this.cbmOrdenar.Location = new System.Drawing.Point(215, 2);
            this.cbmOrdenar.Name = "cbmOrdenar";
            this.cbmOrdenar.Size = new System.Drawing.Size(121, 21);
            this.cbmOrdenar.TabIndex = 1;
            // 
            // lsbMascota
            // 
            this.lsbMascota.FormattingEnabled = true;
            this.lsbMascota.Location = new System.Drawing.Point(13, 28);
            this.lsbMascota.Name = "lsbMascota";
            this.lsbMascota.Size = new System.Drawing.Size(323, 264);
            this.lsbMascota.TabIndex = 2;
            this.lsbMascota.SelectedIndexChanged += new System.EventHandler(this.lsbMascota_SelectedIndexChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 301);
            this.Controls.Add(this.lsbMascota);
            this.Controls.Add(this.cbmOrdenar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "ABM Mascotas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aLTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bAJAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbmOrdenar;
        private System.Windows.Forms.ListBox lsbMascota;

    }
}

