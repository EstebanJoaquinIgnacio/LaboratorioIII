namespace _02_DataSet
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lstVisor = new System.Windows.Forms.ListBox();
            this.cboTablas = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnMostrarProductosPorProveedor = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.lstVisor);
            this.Panel1.Location = new System.Drawing.Point(192, 10);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(248, 242);
            this.Panel1.TabIndex = 9;
            // 
            // lstVisor
            // 
            this.lstVisor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVisor.FormattingEnabled = true;
            this.lstVisor.Location = new System.Drawing.Point(3, 3);
            this.lstVisor.Name = "lstVisor";
            this.lstVisor.Size = new System.Drawing.Size(242, 238);
            this.lstVisor.TabIndex = 0;
            // 
            // cboTablas
            // 
            this.cboTablas.FormattingEnabled = true;
            this.cboTablas.Location = new System.Drawing.Point(12, 99);
            this.cboTablas.Name = "cboTablas";
            this.cboTablas.Size = new System.Drawing.Size(168, 21);
            this.cboTablas.TabIndex = 8;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 137);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 56);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 13);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(156, 23);
            this.btnCargar.TabIndex = 5;
            this.btnCargar.Text = "Crear DataTables y DataSet";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnMostrarProductosPorProveedor
            // 
            this.btnMostrarProductosPorProveedor.Location = new System.Drawing.Point(12, 184);
            this.btnMostrarProductosPorProveedor.Name = "btnMostrarProductosPorProveedor";
            this.btnMostrarProductosPorProveedor.Size = new System.Drawing.Size(174, 23);
            this.btnMostrarProductosPorProveedor.TabIndex = 10;
            this.btnMostrarProductosPorProveedor.Text = "Mostrar Productos Por Proveedor";
            this.btnMostrarProductosPorProveedor.UseVisualStyleBackColor = true;
            this.btnMostrarProductosPorProveedor.Click += new System.EventHandler(this.btnMostrarProductosPorProveedor_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 262);
            this.Controls.Add(this.btnMostrarProductosPorProveedor);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.cboTablas);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCargar);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.ListBox lstVisor;
        internal System.Windows.Forms.ComboBox cboTablas;
        internal System.Windows.Forms.Button btnMostrar;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnMostrarProductosPorProveedor;
    }
}

