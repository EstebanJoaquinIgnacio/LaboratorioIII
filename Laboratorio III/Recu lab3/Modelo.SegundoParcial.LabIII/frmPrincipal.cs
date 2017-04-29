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
using Entidades;
using Microsoft.VisualBasic;

namespace Modelo.SegundoParcial.LabIII
{
    public partial class frmPrincipal : Form
    {
        private DataSet _DataSetAlumnos_Cursos;
        private SqlConnection _cnn;
        private SqlDataAdapter _dataAdapterAlumnos;
        private SqlDataReader _dr;

        public frmPrincipal()
        {
            InitializeComponent();
            this._DataSetAlumnos_Cursos = new DataSet();
            this._cnn = new SqlConnection(Properties.Settings.Default.cnn);
            configurarDataAdapter();
            TraerDatos();
            EstablecerRelacion();

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno frmAlta = new frmAlumno();
            frmAlta.ShowDialog();

            if(frmAlta.DialogResult == DialogResult.OK)
            {
                Alumno alumnoAlta = frmAlta.MiAlumno;  
                DataRow fila = this._DataSetAlumnos_Cursos.Tables["dtAlumno"].NewRow();

                fila[0] = alumnoAlta.legajo;
                fila[1] = alumnoAlta.apellido;
                fila[2] = alumnoAlta.codCurso;

                this._DataSetAlumnos_Cursos.Tables["dtAlumno"].Rows.Add(fila);
                
                
            }
        }

        public DataTable CrearDataTableCursos() 
        {
            DataTable dtCursos = new DataTable();

            dtCursos.TableName = "dtCursos";
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
            fila1[2] = "Matematica";
            fila2[1] = 3;
            fila2[2] = "Geografia";
            fila3[1] = 5;
            fila3[2] = "La clase de bigote";
            dtCursos.Rows.Add(fila1);
            dtCursos.Rows.Add(fila2);
            dtCursos.Rows.Add(fila3);

            dtCursos.WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\CursoDatos.xml");
            dtCursos.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursoDatos.xml");

            return dtCursos;

        }

        public void configurarDataAdapter() 
        {
            this._dataAdapterAlumnos = new SqlDataAdapter();
            SqlCommand _cmmSelect = new SqlCommand("SELECT * FROM dbo.Alumnos", this._cnn);
            SqlCommand _cmmInsert = new SqlCommand("INSERT INTO dbo.Alumnos VALUES(@legajo, @apellido, @curso)", this._cnn);
            SqlCommand _cmmUpdate = new SqlCommand("UPDATE dbo.Alumnos SET Legajo_Alumno = @legajo, Apellido_Alumno = @apellido, Curso_Alumno = @curso", this._cnn);
            SqlCommand _cmmDelete = new SqlCommand("DELETE dbo.Alumnos WHERE Legajo_Alumno = @legajo", this._cnn);
 
            this._dataAdapterAlumnos.SelectCommand = _cmmSelect;
            this._dataAdapterAlumnos.InsertCommand = _cmmInsert;
            this._dataAdapterAlumnos.UpdateCommand = _cmmUpdate;
            this._dataAdapterAlumnos.DeleteCommand = _cmmDelete;

            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@legajo", SqlDbType.Int, 4, "Legajo_Alumno");
            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "Apellido_Alumno");
            this._dataAdapterAlumnos.InsertCommand.Parameters.Add("@curso", SqlDbType.Int, 4, "Curso_Alumno");

            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@legajo", SqlDbType.Int, 4, "Legajo_Alumno");
            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "Apellido_Alumno");
            this._dataAdapterAlumnos.UpdateCommand.Parameters.Add("@curso", SqlDbType.Int, 4, "Curso_Alumno");

            this._dataAdapterAlumnos.DeleteCommand.Parameters.Add("@legajo", SqlDbType.Int, 4, "Legajo_Alumno");

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

                this._dr = cmm.ExecuteReader();

                miTabla.Load(this._dr);

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
            catch (Exception ex)
            {
                dtCursos = this.CrearDataTableCursos();
            }

            this._DataSetAlumnos_Cursos.Tables.Add(dtCursos);
        }

        private void EstablecerRelacion()
        {
           DataRelation relacion = new DataRelation("CursoAlumno",
                                            this._DataSetAlumnos_Cursos.Tables["dtCursos"].Columns[0],
                                            this._DataSetAlumnos_Cursos.Tables["dtAlumno"].Columns["Curso_Alumno"]);
            this._DataSetAlumnos_Cursos.Relations.Add(relacion);
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputBox inputboxLegajo = new inputBox();
            inputboxLegajo.ShowDialog();

            if(inputboxLegajo.DialogResult == DialogResult.OK)
            {
                string legajo = inputboxLegajo.txtLegajo.Text;
                bool flag = false;
                foreach (DataRow item in this._DataSetAlumnos_Cursos.Tables["dtAlumno"].Rows)
                {
                    if (item[0].ToString() == legajo)
                    {
                        frmAlumno frmBaja = new frmAlumno(item[0].ToString(), (string)item[1], item[2].ToString());
                        frmBaja.ShowDialog();
                        if(frmBaja.DialogResult == DialogResult.OK)
                        {
                            item.Delete();
                            flag = true;
                            break;
                            
                        }

                    }
                }

                if (!flag)
                    MessageBox.Show("Pibe cantina no se encuentra, tu hermana es puta");
            }
        }

        private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputBox inputboxLegajo = new inputBox();
            inputboxLegajo.ShowDialog();

            if (inputboxLegajo.DialogResult == DialogResult.OK)
            {
                string legajo = inputboxLegajo.txtLegajo.Text;
                bool flag = false;
                foreach (DataRow item in this._DataSetAlumnos_Cursos.Tables["dtAlumno"].Rows)
                {
                    if (item[0].ToString() == legajo)
                    {
                        frmAlumno frmMod = new frmAlumno(item[0].ToString(), (string)item[1], item[2].ToString());
                        frmMod.Text = "Modificacion";
                        frmMod.ShowDialog();
                        if (frmMod.DialogResult == DialogResult.OK)
                        {
                            Alumno AlumnoMod = frmMod.MiAlumno;
                            item[1] = AlumnoMod.apellido;
                            item[2] = AlumnoMod.codCurso;

                            flag = true;
                            break;

                        }

                    }
                }

                if (!flag)
                    MessageBox.Show("Pibe cantina no se encuentra, tu hermana es puta");
            }
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> MiLista = new List<string>();

            foreach (DataRow item in this._DataSetAlumnos_Cursos.Tables["dtAlumno"].Rows)
            {
               if(item.RowState != DataRowState.Deleted)
                MiLista.Add(item[0].ToString() + " - " + item[1].ToString() + " - " + item[2].ToString());
            }

            frmMostrar mostrar = new frmMostrar(MiLista);
            mostrar.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> MiLista = new List<string>();

            foreach (DataRow item in this._DataSetAlumnos_Cursos.Tables["dtCursos"].Rows)
            {
                MiLista.Add(item[0].ToString() + " - " + item[1].ToString() + " - " + item[2].ToString());
            }

            frmMostrar mostrar = new frmMostrar(MiLista);
            mostrar.ShowDialog();
        }

        private void alumnosConElNombreDelCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> MiLista = new List<string>();

            foreach (DataRow fila in this._DataSetAlumnos_Cursos.Tables["dtCursos"].Rows)
            {
                MiLista.Add(fila[0].ToString() + " --- " + fila[1].ToString() + " --- " + fila[2].ToString());

                foreach (DataRow filaAlumno in fila.GetChildRows("CursoAlumno"))
                {
                        MiLista.Add("#" + filaAlumno[1].ToString());
                }
                MiLista.Add("///// FIN DEL CURSO /////");
            }

            frmMostrar mostrar = new frmMostrar(MiLista);
            mostrar.ShowDialog();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._dataAdapterAlumnos.Update(this._DataSetAlumnos_Cursos.Tables["dtAlumno"]);
        }
    }
}
