namespace Aeropuerto
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
            this.mneMenu = new System.Windows.Forms.MenuStrip();
            this.avionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avionesConSuDestinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avionesQueVuelanAlCaribeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mneMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mneMenu
            // 
            this.mneMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avionToolStripMenuItem,
            this.mostrarToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.mneMenu.Location = new System.Drawing.Point(0, 0);
            this.mneMenu.Name = "mneMenu";
            this.mneMenu.Size = new System.Drawing.Size(866, 24);
            this.mneMenu.TabIndex = 1;
            this.mneMenu.Text = "menuStrip1";
            // 
            // avionToolStripMenuItem
            // 
            this.avionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.modificacionToolStripMenuItem});
            this.avionToolStripMenuItem.Name = "avionToolStripMenuItem";
            this.avionToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.avionToolStripMenuItem.Text = "Avion";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bajaToolStripMenuItem.Text = "Baja";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // modificacionToolStripMenuItem
            // 
            this.modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            this.modificacionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificacionToolStripMenuItem.Text = "Modificacion";
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avionesToolStripMenuItem,
            this.destinosToolStripMenuItem,
            this.avionesConSuDestinoToolStripMenuItem,
            this.avionesQueVuelanAlCaribeToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // avionesToolStripMenuItem
            // 
            this.avionesToolStripMenuItem.Name = "avionesToolStripMenuItem";
            this.avionesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.avionesToolStripMenuItem.Text = "Aviones";
            // 
            // destinosToolStripMenuItem
            // 
            this.destinosToolStripMenuItem.Name = "destinosToolStripMenuItem";
            this.destinosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.destinosToolStripMenuItem.Text = "Destinos";
            // 
            // avionesConSuDestinoToolStripMenuItem
            // 
            this.avionesConSuDestinoToolStripMenuItem.Name = "avionesConSuDestinoToolStripMenuItem";
            this.avionesConSuDestinoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.avionesConSuDestinoToolStripMenuItem.Text = "AvionesConSuDestino";
            // 
            // avionesQueVuelanAlCaribeToolStripMenuItem
            // 
            this.avionesQueVuelanAlCaribeToolStripMenuItem.Name = "avionesQueVuelanAlCaribeToolStripMenuItem";
            this.avionesQueVuelanAlCaribeToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.avionesQueVuelanAlCaribeToolStripMenuItem.Text = "AvionesQueVuelanAlCaribe";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 261);
            this.Controls.Add(this.mneMenu);
            this.Name = "frmPrincipal";
            this.Text = "Asignar Vuelos";
            this.mneMenu.ResumeLayout(false);
            this.mneMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mneMenu;
        private System.Windows.Forms.ToolStripMenuItem avionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avionesConSuDestinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avionesQueVuelanAlCaribeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
    }
}

