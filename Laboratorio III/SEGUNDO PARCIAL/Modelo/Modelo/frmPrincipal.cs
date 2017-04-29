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

namespace Modelo
{
    public partial class frmPrincipal : Form
    {

        private DataSet _DataSetAlumnos_Cursos; //objeto que almazena DataTables
        private SqlConnection _cnn;
        private SqlDataAdapter _dataAdapterAlumnos;
        private String stringConeccion = Properties.Settings.Default.cnn1;
        private SqlDataReader _dataReader;

        public frmPrincipal()
        {
            InitializeComponent();
            this._cnn = new SqlConnection(this.stringConeccion);
        }

        public DataTable CrearDatatableCursos() {
            DataTable dtCursos = new DataTable();
            dtCursos.TableName = "Cursos";
            dtCursos.Columns.Add("Codigo", typeof(Int32));
            dtCursos.Columns.Add("Duracion", typeof(Int32));
            dtCursos.Columns.Add("Nombre", typeof(String));
            dtCursos.Columns["Codigo"].AutoIncrement = true;
            dtCursos.Columns["Codigo"].AutoIncrementSeed = 1000;
            dtCursos.Columns["Codigo"].AutoIncrementStep = 5;
            dtCursos.Columns["Codigo"].Unique = true;
            dtCursos.PrimaryKey = new DataColumn[] { dtCursos.Columns["Codigo"] };

            DataRow fila1 = dtCursos.NewRow();
            DataRow fila2 = dtCursos.NewRow();
            DataRow fila3 = dtCursos.NewRow();

            fila1[1] = 13;
            fila1[2] = "Pepito";
            fila2[1] = 3;
            fila2[2] = "Rosa";
            fila3[1] = 5;
            fila3[2] = "Jorge";

            dtCursos.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.xml");
            dtCursos.WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\CursosEsquema.xml");

            return dtCursos;
        }

        public void ConfigurarDataAdapter(){
            //Obtengo un SqlConnection que utiliza el objeto SqlCommand (es el que dice a donde tiene que conectarse) 
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.cnn1);
            //comandos: contienen las instrucciones que se envian a la base de datos.
            SqlCommand _cmmSelect = new SqlCommand("SELECT * FROM dbo.Alumnos", cnn);
            SqlCommand _cmmInsert = new SqlCommand("INSERT INTO dbo.Alumnos VALUES(@legajo, @apellido, @curso)", cnn);
            SqlCommand _cmmUpdate = new SqlCommand("UPDATE dbo.Alumnos SET Legajo_Alumno = @legajo, Apellido_Alumno = @apellido, Curso_Alumno = @curso", cnn);
            SqlCommand _cmmDelete = new SqlCommand("DELETE dbo.Alumnos WHERE Legajo_Alumno = @legajo", cnn);

            //data adapter es intermediario entre mi BD y el programa (Los data set)
            this._dataAdapterAlumnos.SelectCommand = _cmmSelect;
            this._dataAdapterAlumnos.InsertCommand = _cmmInsert;
            this._dataAdapterAlumnos.UpdateCommand = _cmmUpdate;
            this._dataAdapterAlumnos.DeleteCommand = _cmmDelete;


            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@legajo", SqlDbType.Int, 4,  "Legajo_Alumno");
            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "Apellido_Alumno");
            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@curso", SqlDbType.Int, 4, "Curso_Alumno");

            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@legajo", SqlDbType.Int, 4, "Legajo_Alumno");
            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "Apellido_Alumno");
            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@curso", SqlDbType.Int, 4, "Curso_Alumno");

            this._dataAdapterAlumnos.DeleteCommand.Parameters.Add("@legajo", SqlDbType.Int, 4, "Legajo_Alumno");

            try
            {

            }
            catch (Exception)
            {
                
                throw;
            }



        }

        public void TraerDatos()
        {
            //seteo mi datable "DtAlumno" con un dataReader
            DataTable miTabla = new DataTable("dtAlumno");
            SqlCommand cmm = new SqlCommand();

            try
            {
                cmm.CommandType = CommandType.Text;
                cmm.CommandText = "SELECT * FROM dbo.Alumnos";
                cmm.Connection = this._cnn;

                this._cnn.Open();

                this._dataReader = cmm.ExecuteReader();

                miTabla.Load(this._dataReader);

                this._cnn.Close();
            }
            catch (Exception)
            {
            }

            //Lo guardo en mi dataSet
            this._DataSetAlumnos_Cursos.Tables.Add(miTabla);

            //Creo un DataTable Cursos nuevo o lo obtengo de mi xml
            DataTable dtCursos = new DataTable();
            try
            {
                dtCursos.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursoDatos.xml");
            }
            catch (Exception)
            {
                dtCursos = this.CrearDatatableCursos();
            }

            this._DataSetAlumnos_Cursos.Tables.Add(dtCursos);
            /*DataTable MiTablaAlumnos = new DataTable();
            SqlConnection coneccion = new SqlConnection();

            try
            {

            }
            catch (Exception) {               
                throw;
            }
            this._dataSetAlumnos_cursos.Tables.Add();*/
        }

        public void EstablecerRelacion()
        {
            DataRelation relacion = new DataRelation("CursoAlumno",
             this._DataSetAlumnos_Cursos.Tables["dtCursos"].Columns["Codigo"],
             this._DataSetAlumnos_Cursos.Tables["dtAlumno"].Columns["Codigo_Alumno"]);
            this._DataSetAlumnos_Cursos.Relations.Add(relacion);
        }

        //Alta de alumno
        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno AlumnoAlta = new frmAlumno();
            AlumnoAlta.ShowDialog();
            if (AlumnoAlta.DialogResult == DialogResult.OK)
            { 
            
            
            }
        }
            
    }
}
