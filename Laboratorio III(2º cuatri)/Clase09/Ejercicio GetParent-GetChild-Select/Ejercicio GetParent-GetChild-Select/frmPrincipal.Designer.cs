namespace Ejercicio_GetParent_GetChild_Select
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
            this.gbxInicialiacion = new System.Windows.Forms.GroupBox();
            this.grpMostrar = new System.Windows.Forms.GroupBox();
            this.btnCrearDataSetDataTable = new System.Windows.Forms.Button();
            this.btnCrearRelaciones = new System.Windows.Forms.Button();
            this.btnCargarLocalidades = new System.Windows.Forms.Button();
            this.btnCargarProveedores = new System.Windows.Forms.Button();
            this.btnCargarProductos = new System.Windows.Forms.Button();
            this.btnMostrarProductoConSuProveedor = new System.Windows.Forms.Button();
            this.btnMostrarProductoConProveedorConSuLocalidad = new System.Windows.Forms.Button();
            this.btnMostrarProveedorConSuLocalidad = new System.Windows.Forms.Button();
            this.btnMostrarProveedoresDeLaLocalidadQuilmes = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMostrarProveedoresDelTXT = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.gbxInicialiacion.SuspendLayout();
            this.grpMostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInicialiacion
            // 
            this.gbxInicialiacion.Controls.Add(this.btnCargarProductos);
            this.gbxInicialiacion.Controls.Add(this.btnCargarProveedores);
            this.gbxInicialiacion.Controls.Add(this.btnCargarLocalidades);
            this.gbxInicialiacion.Controls.Add(this.btnCrearRelaciones);
            this.gbxInicialiacion.Controls.Add(this.btnCrearDataSetDataTable);
            this.gbxInicialiacion.Location = new System.Drawing.Point(13, 12);
            this.gbxInicialiacion.Name = "gbxInicialiacion";
            this.gbxInicialiacion.Size = new System.Drawing.Size(183, 325);
            this.gbxInicialiacion.TabIndex = 0;
            this.gbxInicialiacion.TabStop = false;
            this.gbxInicialiacion.Text = "Inicializacion";
            // 
            // grpMostrar
            // 
            this.grpMostrar.Controls.Add(this.txtFiltro);
            this.grpMostrar.Controls.Add(this.btnMostrarProveedoresDelTXT);
            this.grpMostrar.Controls.Add(this.listBox1);
            this.grpMostrar.Controls.Add(this.btnMostrarProveedoresDeLaLocalidadQuilmes);
            this.grpMostrar.Controls.Add(this.btnMostrarProveedorConSuLocalidad);
            this.grpMostrar.Controls.Add(this.btnMostrarProductoConProveedorConSuLocalidad);
            this.grpMostrar.Controls.Add(this.btnMostrarProductoConSuProveedor);
            this.grpMostrar.Location = new System.Drawing.Point(202, 12);
            this.grpMostrar.Name = "grpMostrar";
            this.grpMostrar.Size = new System.Drawing.Size(389, 325);
            this.grpMostrar.TabIndex = 1;
            this.grpMostrar.TabStop = false;
            this.grpMostrar.Text = "Mostrar";
            this.grpMostrar.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnCrearDataSetDataTable
            // 
            this.btnCrearDataSetDataTable.Location = new System.Drawing.Point(6, 19);
            this.btnCrearDataSetDataTable.Name = "btnCrearDataSetDataTable";
            this.btnCrearDataSetDataTable.Size = new System.Drawing.Size(171, 60);
            this.btnCrearDataSetDataTable.TabIndex = 0;
            this.btnCrearDataSetDataTable.Text = "Crear DataSet y DataTable";
            this.btnCrearDataSetDataTable.UseVisualStyleBackColor = true;
            this.btnCrearDataSetDataTable.Click += new System.EventHandler(this.btnCrearDataSetDataTable_Click);
            // 
            // btnCrearRelaciones
            // 
            this.btnCrearRelaciones.Location = new System.Drawing.Point(6, 85);
            this.btnCrearRelaciones.Name = "btnCrearRelaciones";
            this.btnCrearRelaciones.Size = new System.Drawing.Size(171, 57);
            this.btnCrearRelaciones.TabIndex = 1;
            this.btnCrearRelaciones.Text = "Crear Relaciones";
            this.btnCrearRelaciones.UseVisualStyleBackColor = true;
            this.btnCrearRelaciones.Click += new System.EventHandler(this.btnCrearRelaciones_Click);
            // 
            // btnCargarLocalidades
            // 
            this.btnCargarLocalidades.Location = new System.Drawing.Point(6, 148);
            this.btnCargarLocalidades.Name = "btnCargarLocalidades";
            this.btnCargarLocalidades.Size = new System.Drawing.Size(171, 54);
            this.btnCargarLocalidades.TabIndex = 2;
            this.btnCargarLocalidades.Text = "Cargar Localidades";
            this.btnCargarLocalidades.UseVisualStyleBackColor = true;
            this.btnCargarLocalidades.Click += new System.EventHandler(this.btnCargarLocalidades_Click);
            // 
            // btnCargarProveedores
            // 
            this.btnCargarProveedores.Location = new System.Drawing.Point(6, 208);
            this.btnCargarProveedores.Name = "btnCargarProveedores";
            this.btnCargarProveedores.Size = new System.Drawing.Size(171, 52);
            this.btnCargarProveedores.TabIndex = 3;
            this.btnCargarProveedores.Text = "Cargar Proveedores";
            this.btnCargarProveedores.UseVisualStyleBackColor = true;
            this.btnCargarProveedores.Click += new System.EventHandler(this.btnCargarProveedores_Click);
            // 
            // btnCargarProductos
            // 
            this.btnCargarProductos.Location = new System.Drawing.Point(6, 266);
            this.btnCargarProductos.Name = "btnCargarProductos";
            this.btnCargarProductos.Size = new System.Drawing.Size(171, 54);
            this.btnCargarProductos.TabIndex = 4;
            this.btnCargarProductos.Text = "Cargar Productos";
            this.btnCargarProductos.UseVisualStyleBackColor = true;
            this.btnCargarProductos.Click += new System.EventHandler(this.btnCargarProductos_Click);
            // 
            // btnMostrarProductoConSuProveedor
            // 
            this.btnMostrarProductoConSuProveedor.Location = new System.Drawing.Point(6, 19);
            this.btnMostrarProductoConSuProveedor.Name = "btnMostrarProductoConSuProveedor";
            this.btnMostrarProductoConSuProveedor.Size = new System.Drawing.Size(172, 60);
            this.btnMostrarProductoConSuProveedor.TabIndex = 0;
            this.btnMostrarProductoConSuProveedor.Text = "1-Mostrar Productos Con Su Proveedor";
            this.btnMostrarProductoConSuProveedor.UseVisualStyleBackColor = true;
            this.btnMostrarProductoConSuProveedor.Click += new System.EventHandler(this.btnMostrarProductoConSuProveedor_Click);
            // 
            // btnMostrarProductoConProveedorConSuLocalidad
            // 
            this.btnMostrarProductoConProveedorConSuLocalidad.Location = new System.Drawing.Point(6, 85);
            this.btnMostrarProductoConProveedorConSuLocalidad.Name = "btnMostrarProductoConProveedorConSuLocalidad";
            this.btnMostrarProductoConProveedorConSuLocalidad.Size = new System.Drawing.Size(172, 57);
            this.btnMostrarProductoConProveedorConSuLocalidad.TabIndex = 1;
            this.btnMostrarProductoConProveedorConSuLocalidad.Text = "3-Mostrar  Producto Con Proveedor con su Localidad";
            this.btnMostrarProductoConProveedorConSuLocalidad.UseVisualStyleBackColor = true;
            // 
            // btnMostrarProveedorConSuLocalidad
            // 
            this.btnMostrarProveedorConSuLocalidad.Location = new System.Drawing.Point(184, 19);
            this.btnMostrarProveedorConSuLocalidad.Name = "btnMostrarProveedorConSuLocalidad";
            this.btnMostrarProveedorConSuLocalidad.Size = new System.Drawing.Size(175, 60);
            this.btnMostrarProveedorConSuLocalidad.TabIndex = 2;
            this.btnMostrarProveedorConSuLocalidad.Text = "2-Mostrar Proveedor Con Su Localidad";
            this.btnMostrarProveedorConSuLocalidad.UseVisualStyleBackColor = true;
            // 
            // btnMostrarProveedoresDeLaLocalidadQuilmes
            // 
            this.btnMostrarProveedoresDeLaLocalidadQuilmes.Location = new System.Drawing.Point(184, 85);
            this.btnMostrarProveedoresDeLaLocalidadQuilmes.Name = "btnMostrarProveedoresDeLaLocalidadQuilmes";
            this.btnMostrarProveedoresDeLaLocalidadQuilmes.Size = new System.Drawing.Size(175, 57);
            this.btnMostrarProveedoresDeLaLocalidadQuilmes.TabIndex = 3;
            this.btnMostrarProveedoresDeLaLocalidadQuilmes.Text = "4-Mostrar Proveedores de la localidad \"Quilmes\"";
            this.btnMostrarProveedoresDeLaLocalidadQuilmes.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 148);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(377, 108);
            this.listBox1.TabIndex = 4;
            // 
            // btnMostrarProveedoresDelTXT
            // 
            this.btnMostrarProveedoresDelTXT.Location = new System.Drawing.Point(7, 266);
            this.btnMostrarProveedoresDelTXT.Name = "btnMostrarProveedoresDelTXT";
            this.btnMostrarProveedoresDelTXT.Size = new System.Drawing.Size(171, 54);
            this.btnMostrarProveedoresDelTXT.TabIndex = 5;
            this.btnMostrarProveedoresDelTXT.Text = "5-Mostrar por filtro";
            this.btnMostrarProveedoresDelTXT.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(185, 266);
            this.txtFiltro.Multiline = true;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(174, 53);
            this.txtFiltro.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 349);
            this.Controls.Add(this.grpMostrar);
            this.Controls.Add(this.gbxInicialiacion);
            this.Name = "frmPrincipal";
            this.Text = "Ejercicio DataSet";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbxInicialiacion.ResumeLayout(false);
            this.grpMostrar.ResumeLayout(false);
            this.grpMostrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInicialiacion;
        private System.Windows.Forms.GroupBox grpMostrar;
        private System.Windows.Forms.Button btnCargarProductos;
        private System.Windows.Forms.Button btnCargarProveedores;
        private System.Windows.Forms.Button btnCargarLocalidades;
        private System.Windows.Forms.Button btnCrearRelaciones;
        private System.Windows.Forms.Button btnCrearDataSetDataTable;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnMostrarProveedoresDelTXT;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMostrarProveedoresDeLaLocalidadQuilmes;
        private System.Windows.Forms.Button btnMostrarProveedorConSuLocalidad;
        private System.Windows.Forms.Button btnMostrarProductoConProveedorConSuLocalidad;
        private System.Windows.Forms.Button btnMostrarProductoConSuProveedor;
    }
}

