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

namespace Modelo.SegundoParcial.LabIII
{
    public partial class frmPrincipal : Form
    {
        
        private DataSet _DataSetAlumnos_Cursos;
        private SqlDataAdapter _dataAdapterAlumnos;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno frmAlta = new frmAlumno();
            frmAlta.ShowDialog();
        }

        public DataTable CrearDataTableCursos() 
        {
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

            dtCursos.Rows.Add(new object[] { 0, 4, "Matematica" });
            dtCursos.Rows.Add(new object[] { 0, 8, "SIC" });
            dtCursos.Rows.Add(new object[] { 0, 16, "Quimica" });

            dtCursos.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\\CursoDatos.xml");
            dtCursos.WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\CursoDatos.xml");

            return dtCursos;

        }

        public void configurarDataAdapter()
        {
 
        }

    }
}
