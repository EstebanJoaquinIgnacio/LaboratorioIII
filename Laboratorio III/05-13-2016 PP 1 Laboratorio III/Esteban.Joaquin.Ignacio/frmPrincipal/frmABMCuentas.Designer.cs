namespace frmPrincipal
{
    partial class frmPrincipal
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
            this.btnBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbOrdenamiento = new System.Windows.Forms.ToolStripComboBox();
            this.btnMostrarListado = new System.Windows.Forms.ToolStripMenuItem();
            this.lsbABMCuentas = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.btnBaja,
            this.btnModificar,
            this.btnSalir,
            this.cmbOrdenamiento,
            this.btnMostrarListado});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(38, 21);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(40, 21);
            this.btnBaja.Text = "Baja";
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(62, 21);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(39, 21);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbOrdenamiento
            // 
            this.cmbOrdenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenamiento.Name = "cmbOrdenamiento";
            this.cmbOrdenamiento.Size = new System.Drawing.Size(121, 21);
            // 
            // btnMostrarListado
            // 
            this.btnMostrarListado.Name = "btnMostrarListado";
            this.btnMostrarListado.Size = new System.Drawing.Size(93, 21);
            this.btnMostrarListado.Text = "Mostrar Listado";
            // 
            // lsbABMCuentas
            // 
            this.lsbABMCuentas.FormattingEnabled = true;
            this.lsbABMCuentas.Location = new System.Drawing.Point(13, 29);
            this.lsbABMCuentas.Name = "lsbABMCuentas";
            this.lsbABMCuentas.Size = new System.Drawing.Size(394, 225);
            this.lsbABMCuentas.TabIndex = 1;
            this.lsbABMCuentas.SelectedIndexChanged += new System.EventHandler(this.lsbABMCuentas_SelectedIndexChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 273);
            this.Controls.Add(this.lsbABMCuentas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "ABM Cuentas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnBaja;
        private System.Windows.Forms.ToolStripMenuItem btnModificar;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.ToolStripComboBox cmbOrdenamiento;
        private System.Windows.Forms.ToolStripMenuItem btnMostrarListado;
        private System.Windows.Forms.ListBox lsbABMCuentas;
    }
}

