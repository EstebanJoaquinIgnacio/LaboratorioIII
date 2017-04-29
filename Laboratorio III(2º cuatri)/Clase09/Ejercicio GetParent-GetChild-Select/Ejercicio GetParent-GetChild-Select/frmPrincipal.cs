using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_GetParent_GetChild_Select
{
    public partial class frmPrincipal : Form
    {
        private DataSet MiBase;

        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearDataSetDataTable_Click(object sender, EventArgs e)
        {
            this.MiBase = new DataSet("BaseDatos");

            DataTable tabla1 = new DataTable("Localidades");
            tabla1.Columns.Add("Id",typeof(Int32));
            tabla1.Columns.Add("Nombre",typeof(String));            
            tabla1.PrimaryKey = new DataColumn[] {tabla1.Columns[0]};

            DataTable tabla2 = new DataTable("Proveedores");
            tabla2.Columns.Add("Id", typeof(Int32));
            tabla2.Columns.Add("Nombre", typeof(String));
            tabla2.Columns.Add("IdLocalidad", typeof(Int32));
            tabla2.PrimaryKey = new DataColumn[] { tabla2.Columns[0] };

            DataTable tabla3 = new DataTable("Productos");
            tabla3.Columns.Add("Id", typeof(Int32));            
            tabla3.Columns.Add("Descripcion", typeof(String));
            tabla3.Columns.Add("IdProveedores", typeof(Int32));

            tabla3.PrimaryKey = new DataColumn[] { tabla3.Columns[0] };

            this.MiBase.Tables.Add(tabla1);
            this.MiBase.Tables.Add(tabla2);
            this.MiBase.Tables.Add(tabla3);

        }

        private void btnCrearRelaciones_Click(object sender, EventArgs e)
        {
           this.MiBase.Relations.Add("ProductosProveedor",
                this.MiBase.Tables["Proveedores"].Columns["Id"],
            this.MiBase.Tables["Productos"].Columns["IdProveedores"]);

            this.MiBase.Relations.Add("ProveedorLocalidad",
                this.MiBase.Tables["Localidades"].Columns["Id"],
                this.MiBase.Tables["Proveedores"].Columns["IdLocalidad"]);           

        }

        private void btnCargarLocalidades_Click(object sender, EventArgs e)
        {
            this.MiBase.Tables["Localidades"].Rows.Add(new Object[] {1,"Banfiled"});
            this.MiBase.Tables["Localidades"].Rows.Add(new Object[] {2, "Avellaneda" });
            this.MiBase.Tables["Localidades"].Rows.Add(new Object[] {3, "Quilmes" });       
                        

        }

        private void btnCargarProveedores_Click(object sender, EventArgs e)
        {
            this.MiBase.Tables["Proveedores"].Rows.Add(new Object[] { 1, "Jorge", 1 });
            this.MiBase.Tables["Proveedores"].Rows.Add(new Object[] { 2, "Pepe", 2 });
            this.MiBase.Tables["Proveedores"].Rows.Add(new Object[] { 3, "Juan", 3 });
        }

        private void btnCargarProductos_Click(object sender, EventArgs e)
        {
            this.MiBase.Tables["Productos"].Rows.Add(new Object[] { 1, "Chupetin", 1 });
            this.MiBase.Tables["Productos"].Rows.Add(new Object[] { 2, "Agua", 2 });
            this.MiBase.Tables["Productos"].Rows.Add(new Object[] { 3, "Coca", 3 });
            this.MiBase.Tables["Productos"].Rows.Add(new Object[] { 4, "Ramen", 3 });
            this.MiBase.Tables["Productos"].Rows.Add(new Object[] { 5, "Pizza", 1 });
            this.MiBase.Tables["Productos"].Rows.Add(new Object[] { 6, "Pepsi", 3 });
            this.MiBase.Tables["Productos"].Rows.Add(new Object[] { 7, "Havvana", 1 });
            this.MiBase.Tables["Productos"].Rows.Add(new Object[] { 8, "Caramelo", 2 });
            this.MiBase.Tables["Productos"].Rows.Add(new Object[] { 9, "Ajo", 1 });
        }

        private void btnMostrarProductoConSuProveedor_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            foreach (DataRow item in this.MiBase.Tables["Productos"].Rows)
            {
                foreach (DataRow item2 in this.MiBase.Tables["Proveedores"].Rows)
	            {
		            //if()
	            }
                
            }
        }
    }
}
