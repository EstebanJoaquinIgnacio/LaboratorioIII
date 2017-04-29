using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_datos_virtual
{ 

    public partial class frmDataSet : Form
    {
        private DataSet BS;
        private DataTable Localidades;
        private DataTable Proveedores;
        private DataTable Productos; 

        public frmDataSet()
        {
            InitializeComponent();

        }

        private void btnCrearDSyDT_Click(object sender, EventArgs e)
        {
            this.BS = new DataSet("Base datos virtual");
            //Instancio y creo campos Localidad
            this.Localidades = new DataTable("Localidades");
            this.Localidades.Columns.Add("IdLocalidad", typeof(Int32));
            this.Localidades.Columns.Add("Localidad", typeof(String));
            this.Localidades.PrimaryKey = new DataColumn[] { this.Localidades.Columns[0] };

            //Instancio y creo campos Localidad
            this.Proveedores = new DataTable("Proveedores");
            this.Proveedores.Columns.Add("IdProveedores", typeof(Int32));
            this.Proveedores.Columns.Add("Proveedores", typeof(String));

            //Instancio y creo campos Localidad
            this.Productos = new DataTable("Productos");
            this.Productos.Columns.Add("IdProductos", typeof(Int32));
            this.Productos.Columns.Add("Productos", typeof(String));
                        
            
        }


    }
}
