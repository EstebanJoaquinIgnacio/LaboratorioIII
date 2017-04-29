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
using Microsoft.VisualBasic;
using Entidades;
using System.IO;

namespace Aeropuerto
{
    public partial class frmPrincipal : Form
    {
        private DataSet _dataSetAviones_Vuelos;
        private SqlDataAdapter _dataAdapterAviones;
        private SqlConnection _cnn;
        private SqlDataReader _DataReader;

        public frmPrincipal()
        {
            InitializeComponent();
            this._dataSetAviones_Vuelos = new DataSet();
            //this._cnn = new SqlConnection(Properties.Settings.Default.cnnAvion); //AGREGAR LA BASE DE DATOS CON EL NOMBRE cnnAvion;
            this._dataAdapterAviones = new SqlDataAdapter();
            

            this.ConfigurarDataAdapter();
            this.TraerDatos();

        }        

        public DataTable CrearDataTableVuelos()
        {
            DataTable dtVuelos = new DataTable();

            dtVuelos.Columns.Add("Codigo", typeof(Int16));
            dtVuelos.Columns.Add("Destino", typeof(String));

            dtVuelos.Columns["Codigo"].AutoIncrement = true;
            dtVuelos.Columns["Codigo"].AutoIncrementSeed = 1000;
            dtVuelos.Columns["Codigo"].AutoIncrementStep = 5;
            dtVuelos.Columns["Codigo"].Unique = true;
            dtVuelos.PrimaryKey = new DataColumn[] { dtVuelos.Columns["Codigo"] };

            DataRow fila01 = dtVuelos.NewRow();
            DataRow fila02 = dtVuelos.NewRow();
            DataRow fila03 = dtVuelos.NewRow();

            fila01[1] = "Caribe";
            fila02[1] = "Filipinas";
            fila03[1] = "Grecia";

            dtVuelos.Rows.Add(fila01);
            dtVuelos.Rows.Add(fila02);
            dtVuelos.Rows.Add(fila03);

            dtVuelos.WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\VuelosEsquema.XML");
            dtVuelos.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\\VuelosDatos.XML");


            return dtVuelos;
        }

        public void ConfigurarDataAdapter()
        {
            SqlCommand _cmmSelect = new SqlCommand("SELECT * FROM AeropuertoDB", this._cnn);
            SqlCommand _cmmUpdate = new SqlCommand("UPDATE AeropuertoDB SET Matricula_Avion = @Matricula, Marca_Avion = @Marca, Modelo_Avion = @Modelo, Capacidad_Avion = @Capacidad, codigoVuelo = @Codigo",this._cnn);
            SqlCommand _cmmDelate = new SqlCommand("DELATE AeropuertoDB WHERE Matricula_Avion = @Matricula", this._cnn);
            SqlCommand _cmmInsert = new SqlCommand("INSERT INTO AeropuertoDB VALUES(@Matricula,@Marca, @Modelo,@Capacidad,@Codigo)", this._cnn);

            this._dataAdapterAviones.SelectCommand = _cmmSelect;
            this._dataAdapterAviones.UpdateCommand = _cmmUpdate;
            this._dataAdapterAviones.DeleteCommand = _cmmDelate;
            this._dataAdapterAviones.InsertCommand = _cmmInsert;

            this._dataAdapterAviones.UpdateCommand.Parameters.Add("@Matricula", SqlDbType.Int, 4, "Matricula_Avion");
            this._dataAdapterAviones.UpdateCommand.Parameters.Add("@Marca", SqlDbType.VarChar, 50, "Marca_Avion");
            this._dataAdapterAviones.UpdateCommand.Parameters.Add("@Modelo", SqlDbType.VarChar, 50, "Modelo_Avion");
            this._dataAdapterAviones.UpdateCommand.Parameters.Add("@Capacidad", SqlDbType.Int, 4, "Capacidad_Avion");
            this._dataAdapterAviones.UpdateCommand.Parameters.Add("@Codigo", SqlDbType.Int, 4, "codigoVuelo");

            this._dataAdapterAviones.InsertCommand.Parameters.Add("@Matricula", SqlDbType.Int, 4, "Matricula_Avion");
            this._dataAdapterAviones.InsertCommand.Parameters.Add("@Marca", SqlDbType.VarChar, 50, "Marca_Avion");
            this._dataAdapterAviones.InsertCommand.Parameters.Add("@Modelo", SqlDbType.VarChar, 50, "Modelo_Avion");
            this._dataAdapterAviones.InsertCommand.Parameters.Add("@Capacidad", SqlDbType.Int, 4, "Capacidad_Avion");
            this._dataAdapterAviones.InsertCommand.Parameters.Add("@Codigo", SqlDbType.Int, 4, "codigoVuelo");

            this._dataAdapterAviones.DeleteCommand.Parameters.Add("@Matricula",SqlDbType.Int,4,"Matricula_Avion");     
        }

        public void TraerDatos()
        {
            DataTable MisAviones = new DataTable("tablaAviones");

            SqlCommand SqlCmm = new SqlCommand();
            SqlCmm.CommandType = CommandType.Text;
            SqlCmm.CommandText = "SELECT * FROM AeropuertoDB";

            this._cnn.Open();

            this._DataReader = SqlCmm.ExecuteReader();
            MisAviones.Load(this._DataReader);

            this._cnn.Close();

            this._dataSetAviones_Vuelos.Tables.Add(MisAviones);

            DataTable dtVuelos = new DataTable();
            try
            {
                dtVuelos.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "VuelosDatos.XML"); 
            }
            catch (Exception)
            {
                dtVuelos = this.CrearDataTableVuelos();
            }

            this._dataSetAviones_Vuelos.Tables.Add(dtVuelos);

          
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvion formAlta = new frmAvion();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                Avion MiAvion = formAlta.miAvion;
                
                DataRow Row = this._dataSetAviones_Vuelos.Tables["MisAviones"].NewRow();

                Row[0] = MiAvion.Matricula;
                Row[1] = MiAvion.Marca;
                Row[2] = MiAvion.Modelo;
                Row[3] = MiAvion.Capacidad;
                Row[4] = MiAvion.CodVuelo;

                this._dataSetAviones_Vuelos.Tables["MisAviones"].Rows.Add(Row);
                   
            }
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputBox miInputBox = new InputBox();
            miInputBox.ShowDialog();
            if (miInputBox.DialogResult == DialogResult.OK)
            {
                string Legajo = miInputBox.txtLegajo.Text;
                bool Entradas = false;

                foreach (DataRow item in this._dataSetAviones_Vuelos.Tables["MisAviones"].Rows)
                {
                    if (Convert.ToString(item[0]) == Legajo)
                    {
                        frmAvion formBaja = new frmAvion();
                    }
                }

            }
        }
    }

}
