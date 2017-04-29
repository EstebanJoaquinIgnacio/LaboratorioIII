namespace FormularioPrincipal
{
    partial class frmABM
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbOrdenamiento = new System.Windows.Forms.ComboBox();
            this.lbxABM = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(373, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.bajaToolStripMenuItem.Text = "Baja";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cmbOrdenamiento
            // 
            this.cmbOrdenamiento.FormattingEnabled = true;
            this.cmbOrdenamiento.Location = new System.Drawing.Point(211, 1);
            this.cmbOrdenamiento.Name = "cmbOrdenamiento";
            this.cmbOrdenamiento.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenamiento.TabIndex = 1;
            // 
            // lbxABM
            // 
            this.lbxABM.FormattingEnabled = true;
            this.lbxABM.Location = new System.Drawing.Point(13, 28);
            this.lbxABM.Name = "lbxABM";
            this.lbxABM.Size = new System.Drawing.Size(319, 225);
            this.lbxABM.TabIndex = 2;
            this.lbxABM.SelectedIndexChanged += new System.EventHandler(this.lbxABM_SelectedIndexChanged);
            // 
            // frmABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 273);
            this.Controls.Add(this.lbxABM);
            this.Controls.Add(this.cmbOrdenamiento);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmABM";
            this.Text = "ABM MASCOTAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmABM_FormClosing);
            this.Load += new System.EventHandler(this.frmABM_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbOrdenamiento;
        private System.Windows.Forms.ListBox lbxABM;
    }
}

