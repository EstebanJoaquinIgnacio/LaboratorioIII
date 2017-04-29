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
namespace ModeloSegundoParcialLabIII
{
    public partial class Form1 : Form
    {
        private DataSet _dataSetAlumnos_Cursos;
        private SqlDataAdapter _dataAdapterAlumnos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarAlumnosASSPNETToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public DataTable CrearDataTableCursos()
        {
            DataTable dtCursos = new DataTable("Cursos");
            dtCursos.Columns.Add("Codigo", typeof(Int32));
            dtCursos.Columns.Add("Duracion", typeof(Int32));
            dtCursos.Columns.Add("Nombre", typeof(String));         
            //Indicar que se autoincremente
            dtCursos.Columns["Codigo"].AutoIncrement = true;
            dtCursos.Columns["Codigo"].AutoIncrementSeed = 1000;
            dtCursos.Columns["Codigo"].AutoIncrementStep = 5;
            //indica clave unica
            dtCursos.PrimaryKey = new DataColumn[] { dtCursos.Columns["Codigo"] };

            //cargar la tabla con 3 cursos
            DataRow fila1 = dtCursos.NewRow(); //para instanciar el datarow
            DataRow fila2 = dtCursos.NewRow(); 
            DataRow fila3 = dtCursos.NewRow();

            //Cargo las filas con datos (el 1 correspeonde a Duracion y el 2 a Nombre)
            fila1[1] = 13;
            fila1[2] = "3A";

            fila2[1] = 5;
            fila2[2] = "4C";

            fila3[1] = 8;
            fila3[2] = "2B";

            //Creacion del xml
            dtCursos.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursosDatos.xml"); //Es la tabla con los datos
            dtCursos.WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\CursosEsquema.xml"); //Son las columnas con sus nombres


            return dtCursos;
        }

        public void ConfigurarDataAdapter()
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.cnnCursoAlumnos);
            SqlCommand _cnnSelect = new SqlCommand("SELECT * FROM dbo.Alumnos",cnn); //dbo.Alumnos es la tabla de la base de datos
            SqlCommand _cnnInsert = new SqlCommand("INSERT INTO dbo.Alumnos VALUES(@legajo,@apellido,@curso)",cnn);
            SqlCommand _cnnUpdate = new SqlCommand("UPDATE dbo.Alumnos SET Legajo_Alumno = @legajo,Apellido_Alumno = @apellido,Curso_Alumno = @curso", cnn);
            SqlCommand _cnnDelete = new SqlCommand("DELETE dbo.Alumnos WHERE Legajo_Alumno = @legajo",cnn);

            this._dataAdapterAlumnos.SelectCommand = _cnnSelect;
            this._dataAdapterAlumnos.SelectCommand = _cnnInsert;
            this._dataAdapterAlumnos.SelectCommand = _cnnUpdate;
            this._dataAdapterAlumnos.SelectCommand = _cnnDelete;

            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@legajo", SqlDbType.Int, 4, "legajo");
            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "apellido");
            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@curso", SqlDbType.Int, 4, "curso");

            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@legajo", SqlDbType.Int, 4, "legajo");
            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "apellido");
            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@curso", SqlDbType.Int, 4, "curso");

            this._dataAdapterAlumnos.DeleteCommand.Parameters.Add("@legajo", SqlDbType.Int, 4, "legajo");
            
        }
    }
}
