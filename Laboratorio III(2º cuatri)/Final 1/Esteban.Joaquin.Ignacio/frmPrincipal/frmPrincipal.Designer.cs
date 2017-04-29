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
            this.dgwMostrar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMostrar
            // 
            this.dgwMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMostrar.Location = new System.Drawing.Point(13, 13);
            this.dgwMostrar.Name = "dgwMostrar";
            this.dgwMostrar.ReadOnly = true;
            this.dgwMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMostrar.Size = new System.Drawing.Size(512, 244);
            this.dgwMostrar.TabIndex = 0;
            this.dgwMostrar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgwMostrar_MouseDoubleClick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 269);
            this.Controls.Add(this.dgwMostrar);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMostrar;
    }
}

