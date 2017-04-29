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
using Microsoft.VisualBasic;

namespace Modelo.SegundoParcial.LabIII
{
    public partial class frmPrincipal : Form
    {
        private DataSet _dataSetAlumnos_Cursos;
        private SqlDataAdapter _dataAdapterAlumnos;
        private SqlConnection coneccion;
        private SqlDataReader _DataReader;
        private DataTable dtCursos;

        public DataTable cursos { get { return this.dtCursos; } }

        public frmPrincipal()
        {
            InitializeComponent();
            this.coneccion = new SqlConnection(Properties.Settings.Default.cnn);
            this._dataSetAlumnos_Cursos = new DataSet();
            this.dtCursos = new DataTable("Cursos");
            //el data reader NO SE INSTANCIA
            //this._DataReader = new SqlDataReader();
            
            this.ConfigurarDataAdapter();
            this.TraerDatos();


            this.EstablecerRelaciones();

        }

        private DataTable CrearDataTableCursos()
        {
            
            DataColumn Codigo = new DataColumn("Codigo", typeof(int));
            DataColumn Duracion = new DataColumn("Duracion", typeof(int));
            DataColumn Nombre = new DataColumn("Nombre", typeof(string));

            Codigo.AutoIncrement = true;
            Codigo.AutoIncrementSeed = 1000;
            Codigo.AutoIncrementStep = 5;

            dtCursos.Columns.Add(Codigo);
            dtCursos.Columns.Add(Duracion);
            dtCursos.Columns.Add(Nombre);

            DataRow fila1 = this.dtCursos.NewRow();
            fila1[1] = 20;
            fila1[2] = "Matematicas";

            DataRow fila2 = this.dtCursos.NewRow();
            fila2[1] = 15;
            fila2[2] = "Ingles";

            DataRow fila3 = this.dtCursos.NewRow();
            fila3[1] = 40;
            fila3[2] = "Folklore";

            dtCursos.Rows.Add(fila1);
            dtCursos.Rows.Add(fila2);
            dtCursos.Rows.Add(fila3);

            try
            {
                dtCursos.WriteXmlSchema("CursosEsquema.xml");
                dtCursos.WriteXml("CursosDatos.xml");
                
            }
            catch (Exception)
            {
                MessageBox.Show("FALLO al escribir XML");
            }
            

            return dtCursos;
        }
        
        private void ConfigurarDataAdapter()
        {
            this._dataAdapterAlumnos = new SqlDataAdapter();
            this._dataAdapterAlumnos.SelectCommand = new SqlCommand("SELECT Legajo_Alumno AS Legajo, Apellido_Alumno AS Apellido,Curso_Alumno AS Curso FROM Alumnos", this.coneccion);
            this._dataAdapterAlumnos.InsertCommand = new SqlCommand("INSERT INTO Alumnos(Legajo_Alumno, Apellido_Alumno ,Curso_Alumno) VALUES(@Legajo,@Apellido,@Curso)", this.coneccion);
            this._dataAdapterAlumnos.UpdateCommand = new SqlCommand("UPDATE Alumnos SET Apellido_Alumno= @Apellido,Curso_Alumno = @Curso WHERE Legajo_Alumno = @Legajo", this.coneccion);
            this._dataAdapterAlumnos.DeleteCommand = new SqlCommand("DELETE FROM Alumnos WHERE Legajo_Alumno = @Legajo",this.coneccion);

            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@Legajo", SqlDbType.Int, 18, "legajo");
            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "apellido");
            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@Curso", SqlDbType.Int, 18, "curso");

            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@Legajo", SqlDbType.Int, 18, "legajo");
            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "apellido");
            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@Curso", SqlDbType.Int, 18, "curso");

            this._dataAdapterAlumnos.DeleteCommand.Parameters.Add("@Legajo", SqlDbType.Int, 18, "legajo");


        }

        private void TraerDatos()
        {
            DataTable Alumnos = new DataTable("Alumnos");
            
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "SELECT Legajo_Alumno AS Legajo, Apellido_Alumno AS Apellido,Curso_Alumno AS Curso FROM Alumnos";
                comando.CommandType = CommandType.Text;
                comando.Connection = this.coneccion;
                this.coneccion.Open();

                this._DataReader = comando.ExecuteReader();
                Alumnos.Load(this._DataReader);

                this.coneccion.Close();
                
            }
            catch (Exception)
            {
                
                
            }

            if (!File.Exists("CursosEsquema.xml") && !File.Exists("CursosDatos.xml"))
                this.dtCursos = this.CrearDataTableCursos();
            else
            {
                this.dtCursos.ReadXmlSchema("CursosEsquema.xml");
                this.dtCursos.ReadXml("CursosDatos.xml");
            }

            this._dataSetAlumnos_Cursos.Tables.Add(Alumnos);
            this._dataSetAlumnos_Cursos.Tables.Add(this.dtCursos);
        }

        private void EstablecerRelaciones()
        {
            DataRelation miRelacion = new DataRelation("CursosAlumnos",
                this._dataSetAlumnos_Cursos.Tables["Cursos"].Columns["Codigo"],
                this._dataSetAlumnos_Cursos.Tables["Alumnos"].Columns["Curso"]);
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos Alta = new frmDatos();
            Alta.Text = "frmAltaAlumno";
            Alta.ShowDialog();
            if (Alta.DialogResult == DialogResult.OK)
            {
                DataRow fila = this._dataSetAlumnos_Cursos.Tables["Alumnos"].NewRow();
                fila[0] = Alta.MiAlumno.Legajo;
                fila[1] = Alta.MiAlumno.Apellido;
                fila[2] = Alta.MiAlumno.CodCurso;

                this._dataSetAlumnos_Cursos.Tables["Alumnos"].Rows.Add(fila);
            }
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar(this._dataSetAlumnos_Cursos, "Alumnos");
            mostrar.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar(this._dataSetAlumnos_Cursos, "Cursos");
            mostrar.Show();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._dataAdapterAlumnos.Update(this._dataSetAlumnos_Cursos.Tables["Alumnos"]);
        }

        private void bajaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {        

            frmLegajo Legajo = new frmLegajo();
            Legajo.ShowDialog();

            if (Legajo.DialogResult == DialogResult.OK)
            {
                bool flag = true;

                for (int i = 0; i < this._dataSetAlumnos_Cursos.Tables["Alumnos"].Rows.Count; i++)
                {
                    if (Legajo.txtLegajo.Text == this._dataSetAlumnos_Cursos.Tables["Alumnos"].Rows[i]["Legajo"].ToString())
                    {
                        frmDatos baja = new frmDatos(this._dataSetAlumnos_Cursos.Tables["Alumnos"].Rows[i]);
                        baja.Text = "Baja";
                        baja.ShowDialog();
                        if (DialogResult.OK == baja.DialogResult)
                        {
                            this._dataSetAlumnos_Cursos.Tables["Alumnos"].Rows[i].Delete();
                        }
                        flag = false;

                    }
                    
                }

                if (flag)
                {
                    MessageBox.Show("NO SE ENCONTRO ESE LEGAJO");
                }
            }

         
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLegajo Legajo = new frmLegajo();
            Legajo.ShowDialog();

            if (Legajo.DialogResult == DialogResult.OK)
            {
                bool flag = true;

                for (int i = 0; i < this._dataSetAlumnos_Cursos.Tables["Alumnos"].Rows.Count; i++)
                {
                    if (Legajo.txtLegajo.Text == this._dataSetAlumnos_Cursos.Tables["Alumnos"].Rows[i]["Legajo"].ToString())
                    {
                        frmDatos Modificacion = new frmDatos(this._dataSetAlumnos_Cursos.Tables["Alumnos"].Rows[i]);
                        Modificacion.Text = "Modificacion";
                        Modificacion.ShowDialog();
                        if (DialogResult.OK == Modificacion.DialogResult)
                        {
                            this._dataSetAlumnos_Cursos.Tables["Alumnos"].Rows[i][1] = Modificacion.MiAlumno.Apellido;
                            this._dataSetAlumnos_Cursos.Tables["Alumnos"].Rows[i][2] = Modificacion.MiAlumno.CodCurso;
                        }
                        flag = false;

                    }

                }

                if (flag)
                {
                    MessageBox.Show("NO SE ENCONTRO ESE LEGAJO");
                }
            }
        }

        private void alumnosConElNombreDelCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarAlumnosDeASPNETToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
