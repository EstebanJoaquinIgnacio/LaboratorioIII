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
using System.IO;

namespace Esteban.Joaquin.Ignacio
{
    public partial class Form1 : Form
    {
        private DataTable dtEnvios;
        private SqlConnection miConexion;
        private DataSet dsStock = new DataSet();
        private SqlDataAdapter adaptadorProveedor;
        private SqlDataAdapter adaptadorProductos;

        public Form1()
        {
            InitializeComponent();
            this.miConexion = new SqlConnection(Properties.Settings.Default.Conexion);
            //this.CrearDataTableEnvios("D:\\");
            this.adaptadorProveedor = this.ConfigurarAdaptadoProveedor();
            this.adaptadorProductos = this.ConfigurarAdaptadorProducto();
            this.AgregarTablas();
            GuardarEnArchivo();
        }

        private DataTable CrearDataTableEnvios(string path)
        {
            this.dtEnvios = new DataTable("dtEnvios");
            bool flag = true;

            try
            {
                //intento leer el readXml
                this.dtEnvios.ReadXml(path + "\\xmlDatos.xml");
                flag = false;


            }
            catch (Exception)
            {

            }

            if (flag)
            {
                this.dtEnvios.Columns.Add("CodigoProveedor", typeof(Int32));
                this.dtEnvios.Columns.Add("CodigoProducto", typeof(Int32));
                this.dtEnvios.Columns.Add("Cantidad", typeof(Int32));

                this.dtEnvios.PrimaryKey = new DataColumn[] { this.dtEnvios.Columns["CodigoProveedor"], this.dtEnvios.Columns["CodigoProducto"] };
                DataRow fila = this.dtEnvios.NewRow();
                fila[0] = 1;
                fila[1] = 1;
                fila[2] = 400;

                DataRow fila1 = this.dtEnvios.NewRow();
                fila1[0] = 2;
                fila1[1] = 2;
                fila1[2] = 550;

                this.dtEnvios.Rows.Add(fila);
                this.dtEnvios.Rows.Add(fila1);

                this.dtEnvios.WriteXml(path + "\\xmlDatos.xml");
                this.dtEnvios.WriteXmlSchema(path + "\\xmlDatos.xml");
            }



            return this.dtEnvios;
        }

        private SqlDataAdapter ConfigurarAdaptadoProveedor()
        {
            SqlDataAdapter miAdaptador = new SqlDataAdapter();//= new SqlDataAdapter(Properties.Settings.Default.Conexion); 


            SqlCommand cmmSelect = new SqlCommand("SELECT * FROM dbo.Proveedores", this.miConexion);
            SqlCommand cmmInsert = new SqlCommand("INSERT INTO dbo.Proveedores VALUES(@Id,@Nombre,@Cuit)", this.miConexion);
            SqlCommand cmmUpdate = new SqlCommand("UPDATE dbo.Proveedores SET(Id = @Id,nombreProveedor = @Nombre,cuitProveedor = @Cuit)", this.miConexion);
            SqlCommand cmmDelete = new SqlCommand("DELETE dbo.Proveedores WHERE Id = @Id", this.miConexion);

            miAdaptador.SelectCommand = cmmSelect;
            miAdaptador.InsertCommand = cmmInsert;
            miAdaptador.UpdateCommand = cmmUpdate;
            miAdaptador.DeleteCommand = cmmDelete;

            miAdaptador.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 4, "Id");
            miAdaptador.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "nombreProveedor");
            miAdaptador.InsertCommand.Parameters.Add("@Cuit", SqlDbType.Int, 18, "cuitProveedor");

            miAdaptador.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int, 4, "Id");
            miAdaptador.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "nombreProveedor");
            miAdaptador.UpdateCommand.Parameters.Add("@Cuit", SqlDbType.Int, 18, "cuitProveedor");

            miAdaptador.DeleteCommand.Parameters.Add("@Id", SqlDbType.Int, 4, "Id");


            return miAdaptador;
        }


        private SqlDataAdapter ConfigurarAdaptadorProducto()
        {
            SqlDataAdapter miAdaptador = new SqlDataAdapter();//= new SqlDataAdapter(Properties.Settings.Default.Conexion); 


            SqlCommand cmmSelect = new SqlCommand("SELECT * FROM dbo.Productos", this.miConexion);
            SqlCommand cmmInsert = new SqlCommand("INSERT INTO dbo.Productos VALUES(@IdProducto,@DescripcionProd,@PrecioProd)", this.miConexion);
            SqlCommand cmmUpdate = new SqlCommand("UPDATE dbo.Productos SET(id = @IdProducto,descripcion = @DescripcionProd,precio = @PrecioProd)", this.miConexion);
            SqlCommand cmmDelete = new SqlCommand("DELETE dbo.Productos WHERE id = @IdProducto", this.miConexion);

            miAdaptador.SelectCommand = cmmSelect;
            miAdaptador.InsertCommand = cmmInsert;
            miAdaptador.UpdateCommand = cmmUpdate;
            miAdaptador.DeleteCommand = cmmDelete;

            miAdaptador.InsertCommand.Parameters.Add("@IdProducto", SqlDbType.Int, 4, "id");
            miAdaptador.InsertCommand.Parameters.Add("@DescripcionProd", SqlDbType.VarChar, 50, "descripcion");
            miAdaptador.InsertCommand.Parameters.Add("@PrecioProd", SqlDbType.Int, 6, "precio");

            miAdaptador.UpdateCommand.Parameters.Add("@IdProducto", SqlDbType.Int, 4, "id");
            miAdaptador.UpdateCommand.Parameters.Add("@DescripcionProd", SqlDbType.VarChar, 50, "descripcion");
            miAdaptador.UpdateCommand.Parameters.Add("@PrecioProd", SqlDbType.Int, 6, "precio");

            miAdaptador.DeleteCommand.Parameters.Add("@IdProducto", SqlDbType.Int, 4, "id");


            return miAdaptador;
        }

        private void AgregarTablas()
        {
            //SqlDataReader lector = new SqlDataReader();
            DataTable tablaProveedores = new DataTable("dtProveedores");
            SqlCommand comandoProveedores = new SqlCommand();
            try
            {
                comandoProveedores.CommandType = CommandType.Text;
                comandoProveedores.CommandText = "SELECT * FROM dbo.Proveedores";
                comandoProveedores.Connection = this.miConexion;

                this.miConexion.Open();
                tablaProveedores.Load(comandoProveedores.ExecuteReader());
                this.miConexion.Close();

            }
            catch (Exception)
            { }

            DataTable tablaProductos = new DataTable("dtProductos");
            SqlCommand comandoProductos = new SqlCommand();
            try
            {
                comandoProductos.CommandType = CommandType.Text;
                comandoProductos.CommandText = "SELECT * FROM dbo.Productos";
                comandoProductos.Connection = this.miConexion;

                this.miConexion.Open();
                tablaProductos.Load(comandoProductos.ExecuteReader());
                this.miConexion.Close();

            }
            catch (Exception)
            { }

            //agrego las 3 tablas
            this.dsStock.Tables.Add(this.CrearDataTableEnvios("D:\\"));
            this.dsStock.Tables.Add(tablaProveedores);
            this.dsStock.Tables.Add(tablaProductos);
        }


        private void GuardarEnArchivo()
        {
            string cadenaAGuardar = "";
            foreach (DataRow item in this.dsStock.Tables["dtProveedores"].Rows)
            {
                cadenaAGuardar += item[2].ToString() + " - " + item[1].ToString();
                if (item[0] == this.dsStock.Tables["dtEnvios"].Rows[0])
                {
                    cadenaAGuardar += " - " + this.dsStock.Tables["dtEnvios"].Rows[2].ToString();
                }
                if (this.dsStock.Tables["dtProductos"].Rows[0] == this.dsStock.Tables["dtEnvios"].Rows[1])
                {
                    cadenaAGuardar += " - " + this.dsStock.Tables["dtProductos"].Rows[1].ToString() + " - " + this.dsStock.Tables["dtProductos"].Rows[2].ToString();
                }
            }

            //guardo en archivo

            File.WriteAllText(@"D:\archivoGuardado.txt", cadenaAGuardar);


        }



        private void CrearRelacion()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.adaptadorProductos.Update(this.dsStock.Tables["dtProductos"]);
            this.adaptadorProveedor.Update(this.dsStock.Tables["dtProveedores"]);
        }
    }
}
