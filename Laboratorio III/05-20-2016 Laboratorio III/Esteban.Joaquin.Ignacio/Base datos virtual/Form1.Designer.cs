namespace Base_datos_virtual
{
    partial class frmDataSet
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
            this.gpbInicializacion = new System.Windows.Forms.GroupBox();
            this.gpbMostrar = new System.Windows.Forms.GroupBox();
            this.btnCrearDSyDT = new System.Windows.Forms.Button();
            this.btnCrearRelaciones = new System.Windows.Forms.Button();
            this.btnCargarLocalidades = new System.Windows.Forms.Button();
            this.btnCargarProveedores = new System.Windows.Forms.Button();
            this.btnCargarProductos = new System.Windows.Forms.Button();
            this.btnMostrarProductosCProveedor = new System.Windows.Forms.Button();
            this.btnMostrarProveedorCLocalidad = new System.Windows.Forms.Button();
            this.btnMostrarProductosCProveedorCLocalidad = new System.Windows.Forms.Button();
            this.btnMostrarProveedoresLocalidadQuilmes = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.lsbMostrar = new System.Windows.Forms.ListBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.gpbInicializacion.SuspendLayout();
            this.gpbMostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInicializacion
            // 
            this.gpbInicializacion.Controls.Add(this.btnCargarProductos);
            this.gpbInicializacion.Controls.Add(this.btnCargarProveedores);
            this.gpbInicializacion.Controls.Add(this.btnCargarLocalidades);
            this.gpbInicializacion.Controls.Add(this.btnCrearRelaciones);
            this.gpbInicializacion.Controls.Add(this.btnCrearDSyDT);
            this.gpbInicializacion.Location = new System.Drawing.Point(13, 12);
            this.gpbInicializacion.Name = "gpbInicializacion";
            this.gpbInicializacion.Size = new System.Drawing.Size(186, 444);
            this.gpbInicializacion.TabIndex = 0;
            this.gpbInicializacion.TabStop = false;
            this.gpbInicializacion.Text = "Inicialización";
            // 
            // gpbMostrar
            // 
            this.gpbMostrar.Controls.Add(this.txtFiltro);
            this.gpbMostrar.Controls.Add(this.lsbMostrar);
            this.gpbMostrar.Controls.Add(this.button10);
            this.gpbMostrar.Controls.Add(this.btnMostrarProveedoresLocalidadQuilmes);
            this.gpbMostrar.Controls.Add(this.btnMostrarProductosCProveedorCLocalidad);
            this.gpbMostrar.Controls.Add(this.btnMostrarProveedorCLocalidad);
            this.gpbMostrar.Controls.Add(this.btnMostrarProductosCProveedor);
            this.gpbMostrar.Location = new System.Drawing.Point(205, 12);
            this.gpbMostrar.Name = "gpbMostrar";
            this.gpbMostrar.Size = new System.Drawing.Size(373, 444);
            this.gpbMostrar.TabIndex = 1;
            this.gpbMostrar.TabStop = false;
            this.gpbMostrar.Text = "Mostrar";
            // 
            // btnCrearDSyDT
            // 
            this.btnCrearDSyDT.Location = new System.Drawing.Point(6, 19);
            this.btnCrearDSyDT.Name = "btnCrearDSyDT";
            this.btnCrearDSyDT.Size = new System.Drawing.Size(174, 54);
            this.btnCrearDSyDT.TabIndex = 0;
            this.btnCrearDSyDT.Text = "Crear  DataSete y DataTable";
            this.btnCrearDSyDT.UseVisualStyleBackColor = true;
            this.btnCrearDSyDT.Click += new System.EventHandler(this.btnCrearDSyDT_Click);
            // 
            // btnCrearRelaciones
            // 
            this.btnCrearRelaciones.Location = new System.Drawing.Point(6, 79);
            this.btnCrearRelaciones.Name = "btnCrearRelaciones";
            this.btnCrearRelaciones.Size = new System.Drawing.Size(174, 54);
            this.btnCrearRelaciones.TabIndex = 1;
            this.btnCrearRelaciones.Text = "Crear Relaciones";
            this.btnCrearRelaciones.UseVisualStyleBackColor = true;
            // 
            // btnCargarLocalidades
            // 
            this.btnCargarLocalidades.Location = new System.Drawing.Point(6, 139);
            this.btnCargarLocalidades.Name = "btnCargarLocalidades";
            this.btnCargarLocalidades.Size = new System.Drawing.Size(174, 54);
            this.btnCargarLocalidades.TabIndex = 2;
            this.btnCargarLocalidades.Text = "Cargar Localidades";
            this.btnCargarLocalidades.UseVisualStyleBackColor = true;
            // 
            // btnCargarProveedores
            // 
            this.btnCargarProveedores.Location = new System.Drawing.Point(6, 199);
            this.btnCargarProveedores.Name = "btnCargarProveedores";
            this.btnCargarProveedores.Size = new System.Drawing.Size(174, 54);
            this.btnCargarProveedores.TabIndex = 3;
            this.btnCargarProveedores.Text = "Cargar Proveedores";
            this.btnCargarProveedores.UseVisualStyleBackColor = true;
            // 
            // btnCargarProductos
            // 
            this.btnCargarProductos.Location = new System.Drawing.Point(6, 259);
            this.btnCargarProductos.Name = "btnCargarProductos";
            this.btnCargarProductos.Size = new System.Drawing.Size(174, 54);
            this.btnCargarProductos.TabIndex = 4;
            this.btnCargarProductos.Text = "Cargar Productos";
            this.btnCargarProductos.UseVisualStyleBackColor = true;
            // 
            // btnMostrarProductosCProveedor
            // 
            this.btnMostrarProductosCProveedor.Location = new System.Drawing.Point(6, 19);
            this.btnMostrarProductosCProveedor.Name = "btnMostrarProductosCProveedor";
            this.btnMostrarProductosCProveedor.Size = new System.Drawing.Size(174, 54);
            this.btnMostrarProductosCProveedor.TabIndex = 0;
            this.btnMostrarProductosCProveedor.Text = "1- Mostrar productos con su proveedor";
            this.btnMostrarProductosCProveedor.UseVisualStyleBackColor = true;
            // 
            // btnMostrarProveedorCLocalidad
            // 
            this.btnMostrarProveedorCLocalidad.Location = new System.Drawing.Point(186, 19);
            this.btnMostrarProveedorCLocalidad.Name = "btnMostrarProveedorCLocalidad";
            this.btnMostrarProveedorCLocalidad.Size = new System.Drawing.Size(174, 54);
            this.btnMostrarProveedorCLocalidad.TabIndex = 1;
            this.btnMostrarProveedorCLocalidad.Text = "2 - Mostrar proveedor con su localidad";
            this.btnMostrarProveedorCLocalidad.UseVisualStyleBackColor = true;
            // 
            // btnMostrarProductosCProveedorCLocalidad
            // 
            this.btnMostrarProductosCProveedorCLocalidad.Location = new System.Drawing.Point(6, 79);
            this.btnMostrarProductosCProveedorCLocalidad.Name = "btnMostrarProductosCProveedorCLocalidad";
            this.btnMostrarProductosCProveedorCLocalidad.Size = new System.Drawing.Size(174, 54);
            this.btnMostrarProductosCProveedorCLocalidad.TabIndex = 2;
            this.btnMostrarProductosCProveedorCLocalidad.Text = "3 - Mostrar productos con su proveedor con su localidad";
            this.btnMostrarProductosCProveedorCLocalidad.UseVisualStyleBackColor = true;
            // 
            // btnMostrarProveedoresLocalidadQuilmes
            // 
            this.btnMostrarProveedoresLocalidadQuilmes.Location = new System.Drawing.Point(186, 79);
            this.btnMostrarProveedoresLocalidadQuilmes.Name = "btnMostrarProveedoresLocalidadQuilmes";
            this.btnMostrarProveedoresLocalidadQuilmes.Size = new System.Drawing.Size(174, 54);
            this.btnMostrarProveedoresLocalidadQuilmes.TabIndex = 3;
            this.btnMostrarProveedoresLocalidadQuilmes.Text = "4 - Mostrar proveedores de la localidad Quilmes";
            this.btnMostrarProveedoresLocalidadQuilmes.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 384);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(174, 54);
            this.button10.TabIndex = 4;
            this.button10.Text = "5 - Mostrar proveedores de la localidad ingresados en el txtFiltro";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // lsbMostrar
            // 
            this.lsbMostrar.FormattingEnabled = true;
            this.lsbMostrar.Location = new System.Drawing.Point(6, 139);
            this.lsbMostrar.Name = "lsbMostrar";
            this.lsbMostrar.Size = new System.Drawing.Size(361, 238);
            this.lsbMostrar.TabIndex = 5;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(187, 384);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(180, 54);
            this.txtFiltro.TabIndex = 6;
            // 
            // frmDataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 468);
            this.Controls.Add(this.gpbMostrar);
            this.Controls.Add(this.gpbInicializacion);
            this.Name = "frmDataSet";
            this.Text = "Ejercicio DataSet";
            this.gpbInicializacion.ResumeLayout(false);
            this.gpbMostrar.ResumeLayout(false);
            this.gpbMostrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInicializacion;
        private System.Windows.Forms.Button btnCargarProductos;
        private System.Windows.Forms.Button btnCargarProveedores;
        private System.Windows.Forms.Button btnCargarLocalidades;
        private System.Windows.Forms.Button btnCrearRelaciones;
        private System.Windows.Forms.Button btnCrearDSyDT;
        private System.Windows.Forms.GroupBox gpbMostrar;
        private System.Windows.Forms.ListBox lsbMostrar;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnMostrarProveedoresLocalidadQuilmes;
        private System.Windows.Forms.Button btnMostrarProductosCProveedorCLocalidad;
        private System.Windows.Forms.Button btnMostrarProveedorCLocalidad;
        private System.Windows.Forms.Button btnMostrarProductosCProveedor;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}

