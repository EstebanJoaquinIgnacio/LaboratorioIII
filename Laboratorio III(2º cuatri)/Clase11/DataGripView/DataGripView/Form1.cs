using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DataGripView
{
    public partial class Form1 : Form
    {
        private SqlDataAdapter Adaptador;
        private DataSet DataSet;
        DataTable tablaProveedor;
        private SqlConnection Coneccion = new SqlConnection(Properties.Settings.Default.cnn);
        private SqlDataReader dataReader;
       

        public Form1()
        {
            InitializeComponent();
            this.DataSet = new DataSet("ADO2008");

            this.Adaptador = new SqlDataAdapter("SELECT * FROM Proveedores", this.Coneccion);            
            DataTable tablaProveedor = new DataTable("Proveedor");
            this.Adaptador.Fill(tablaProveedor);
            this.DataSet.Tables.Add(tablaProveedor);

            this.Adaptador = new SqlDataAdapter("SELECT * FROM Productos", this.Coneccion);
            DataTable tablaProductos = new DataTable("Productos");
            this.Adaptador.Fill(tablaProductos);
            this.DataSet.Tables.Add(tablaProductos);

            
            this.dgvGrilla.DataSource = this.DataSet; //Agrego el DataSet a la grilla
            this.dgvGrilla.DataMember = "Proveedor"; //le indico que tabla quiero que muestre
            this.dgvGrilla.MultiSelect = false; //Evito la multi seleccion
            this.dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Indico que solo seleccione toda la fila
            this.dgvGrilla.EditMode = DataGridViewEditMode.EditProgrammatically; //Cancela la edicion desde el datagrid
            
            //Creo comando INSERT para subir datos
            SqlCommand comandoInsert = new SqlCommand("INSERT INTO Proveedores(IdProveedor,Nombre) VALUES(@Id,@Nombre)",this.Coneccion);
            this.Adaptador.InsertCommand = comandoInsert;

            this.Adaptador.InsertCommand.Parameters.Add("@Id",SqlDbType.Int,18,"IdProveedor");
            this.Adaptador.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");

            //Creo comando DELETE para la baja de datos
            this.Adaptador.DeleteCommand = new SqlCommand("DELETE Proveedores WHERE IdProveedor = @Id", this.Coneccion);

            this.Adaptador.DeleteCommand.Parameters.Add("@Id", SqlDbType.Int, 18, "IdProveedor");
            
            //Creo UPDATE para modificar
            this.Adaptador.UpdateCommand = new SqlCommand("UPDATE Proveedores SET Nombre = @Nombre WHERE IdProveedor = @Id",this.Coneccion);

            this.Adaptador.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this.Adaptador.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int, 18, "IdProveedor");
            //LEER CON DATA READER (INNER JOIN de ambas tablas)
            /*DataTable miTabla = new DataTable("ProveedoresProductos");
            SqlCommand cmm = new SqlCommand();
            
            cmm.CommandType = CommandType.Text;
            cmm.CommandText = "SELECT * FROM Proveedores INNER JOIN Productos ON Proveedores.IdProveedor = Productos.IdProveedor";
            cmm.Connection = this.Coneccion;

            this.Coneccion.Open();

            this.dataReader = cmm.ExecuteReader();

            miTabla.Load(this.dataReader);

            this.Coneccion.Close();

            this.DataSet.Tables.Add(miTabla);
            this.dgvGrilla.DataMember = "ProveedoresProductos";*/
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAlta alta = new frmAlta();
            alta.ShowDialog();

            if (alta.DialogResult == DialogResult.OK)
            {
                DataRow miFila = this.DataSet.Tables["Proveedor"].NewRow();
                Random numRan = new Random();
                miFila[0] = numRan.Next(100,999999999);
                miFila[1] = alta.txtNombre.Text;
                this.DataSet.Tables["Proveedor"].Rows.Add(miFila);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Adaptador.Update(this.DataSet.Tables["Proveedor"]);
        }



        private void dgvGrilla_DoubleClick(object sender, EventArgs e)
        {
            //((DataGridView)sender).sele
            int indice = this.dgvGrilla.CurrentRow.Index;

            if (MessageBox.Show("Esta seguro que quiera eleminarlo", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.DataSet.Tables["Proveedor"].Rows[indice].Delete();
                MessageBox.Show("Borrado exitoso");
                this.Adaptador.Update(this.DataSet.Tables["Proveedor"]);
            }
        }
                 

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.dgvGrilla.CurrentRow.Index;

            frmAlta Modificacion = new frmAlta(this.DataSet.Tables["Proveedor"].Rows[indice]["Nombre"].ToString());
            Modificacion.Text = "Modificacion";
            Modificacion.ShowDialog();
            if (Modificacion.DialogResult == DialogResult.OK)
            {
                this.DataSet.Tables["Proveedor"].Rows[indice]["Nombre"] = Modificacion.txtNombre.Text; //Se puede mandar directamente el NOMBRE
                this.Adaptador.Update(this.DataSet.Tables["Proveedor"]);
            }
        }




    }
}
