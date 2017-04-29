using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace frmPrincipal
{
    public partial class frmPrincipal : Form
    {
        private DataSet dataSetStock;
        private DataTable dtDomicilios;
        private DataTable dtProveedores;
        private SqlDataAdapter daProveedores;
        private SqlConnection coneccion;

        public frmPrincipal()
        {            
            InitializeComponent();
            this.dataSetStock = new DataSet();
            this.coneccion = new SqlConnection(Properties.Settings.Default.cnn);

            //configurar adaptador
            this.daProveedores = new SqlDataAdapter("SELECT * FROM Proveedores", this.coneccion);
            this.daProveedores.UpdateCommand = new SqlCommand("UPDATE Proveedores SET razonSocial = @p2,cuit = @p3,idDomicilio=@p4 WHERE codProveedor = @p1", this.coneccion);

            this.daProveedores.UpdateCommand.Parameters.Add("@p1", SqlDbType.Int, 18, "codProveedor");
            this.daProveedores.UpdateCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "razonSocial");
            this.daProveedores.UpdateCommand.Parameters.Add("@p3", SqlDbType.VarChar, 13, "cuit");
            this.daProveedores.UpdateCommand.Parameters.Add("@p4", SqlDbType.Int, 18, "idDomicilio");

            //traigo tabla dtDomiciolios
            this.dtDomicilios = new DataTable("Domicilios");
            SqlDataReader dataReader;
            SqlCommand comando = new SqlCommand("SELECT * FROM Domicilios",this.coneccion);

            try
            {
                this.coneccion.Open();
                dataReader = comando.ExecuteReader();
                this.dtDomicilios.Load(dataReader);
                this.coneccion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al abrir coneccion y cargar tabla domicilios");
            }
            

            //cargo tablas dtProveedores
            this.dtProveedores = new DataTable("Proveedores");
            this.daProveedores.Fill(this.dtProveedores);

            //cargo dataset
            this.dataSetStock.Tables.Add(this.dtDomicilios);
            this.dataSetStock.Tables.Add(this.dtProveedores);

            //Muestro
            this.dgwMostrar.DataSource = this.dataSetStock;//.Tables["Proveedores"];
            this.dgwMostrar.DataMember = "Proveedores";
            

        }

        private void dgwMostrar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = this.dgwMostrar.CurrentRow.Index;

            Modificacion frmModificacion = new Modificacion(this.dataSetStock.Tables["Proveedores"].Rows[indice]);
            frmModificacion.ShowDialog();
            if (frmModificacion.DialogResult == DialogResult.OK)
            {
                this.dataSetStock.Tables["Proveedores"].Rows[indice][1] = frmModificacion.txtRazonSocial.Text;
                this.dataSetStock.Tables["Proveedores"].Rows[indice][2] = frmModificacion.txtCuid.Text;
                this.dataSetStock.Tables["Proveedores"].Rows[indice][3] = Convert.ToInt32(frmModificacion.txtIdDomicilio.Text);

                this.dgwMostrar.DataSource = this.dataSetStock;//.Tables["Proveedores"];
                this.dgwMostrar.DataMember = "Proveedores"; 
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.daProveedores.Update(this.dataSetStock.Tables["Proveedores"]);
        }


    }
}
