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

namespace Clase12_JOA
{
    public partial class frmPrincipal : Form
    {
        private List<Persona> _listaPersonas;
        private BindingSource _BindingSouce;
        private Binding _binNombre;
        private Binding _binApellido;
        private Binding _binEdad;

        //private DataSet _DSet;
        private DataTable _DTable;
        private SqlDataAdapter _dataAdapter;
        private SqlConnection _conexion;
        

        public frmPrincipal()
        {
            InitializeComponent();

            //Instancias para cargar la tabla
            //this._DSet = new DataSet("Personas");
            this._conexion = new SqlConnection(Properties.Settings.Default.cnn);
            this._dataAdapter = new SqlDataAdapter("SELECT * FROM tPersonas", this._conexion);
            this._DTable = new DataTable("TablaPersonas");
            this._dataAdapter.Fill(this._DTable);
            //this._DSet.Tables.Add(this._DTable);

            //Definiciones de los comandos para el UPDATE
            this._dataAdapter.InsertCommand = new SqlCommand("INSERT INTO tPersonas(Apellido,Nombre,Edad) VALUES(@Apellido,@Nombre,@Edad)",this._conexion);
            this._dataAdapter.InsertCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50, "Apellido");
            this._dataAdapter.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this._dataAdapter.InsertCommand.Parameters.Add("@Edad", SqlDbType.Int, 18, "Edad");
           
            //Creo comando DELETE para la baja de datos
            this._dataAdapter.DeleteCommand = new SqlCommand("DELETE tPersonas WHERE @Id = Id", this._conexion);
            this._dataAdapter.DeleteCommand.Parameters.Add("@Id", SqlDbType.Int, 18, "Id");
            

            //Creo UPDATE para modificar
            this._dataAdapter.UpdateCommand = new SqlCommand("UPDATE tPersonas SET Apellido = @Apellido, Nombre = @Nombre, Edad = @Edad WHERE Id = @Id", this._conexion);
            this.Adaptador.UpdateCommand = new SqlCommand("UPDATE Proveedores SET Nombre = @Nombre WHERE IdProveedor = @Id", this.Coneccion);

            this.Adaptador.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this.Adaptador.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int, 18, "IdProveedor");

            this._listaPersonas = new List<Persona>();

            Persona persona1 = new Persona("Pedro","Ramires",22);
            Persona persona2 = new Persona("Joa", "Perez", 32);
            Persona persona3 = new Persona("Joaquin", "Esteba", 17);
            Persona persona4 = new Persona("David", "Canceres", 56);
            Persona persona5 = new Persona("Lucius", "Malfois", 34);

            this._listaPersonas.Add(persona1);
            this._listaPersonas.Add(persona2);
            this._listaPersonas.Add(persona3);
            this._listaPersonas.Add(persona4);
            this._listaPersonas.Add(persona5);

            this._BindingSouce = new BindingSource();
            this._BindingSouce.DataSource = this._DTable;//this._listaPersonas;
            this.dgwPrincipal.DataSource = this._BindingSouce;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this._binNombre = new Binding("Text", this._BindingSouce,"nombre",false,DataSourceUpdateMode.Never);
            this._binApellido = new Binding("Text", this._BindingSouce, "apellido",false,DataSourceUpdateMode.Never);
            this._binEdad = new Binding("Text", this._BindingSouce, "edad",false,DataSourceUpdateMode.Never);

            this.txtNombre.DataBindings.Add(this._binNombre);
            this.txtApellido.DataBindings.Add(this._binApellido);
            this.txtEdad.DataBindings.Add(this._binEdad);


        }



        private void btnPrimero_Click(object sender, EventArgs e)
        {
            this._BindingSouce.MoveFirst();

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this._BindingSouce.MovePrevious();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this._BindingSouce.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            this._BindingSouce.MoveLast();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate Alta = new frmUpdate();
            Alta.ShowDialog();

            if (Alta.DialogResult == DialogResult.OK)
            {    //this.dgwPrincipal.Rows.Add(Alta.miPersona);
                this._listaPersonas.Add(Alta.miPersona);
                this.dgwPrincipal.DataSource = null;
                this.dgwPrincipal.DataSource = this._BindingSouce;
            }
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate Baja = new frmUpdate(this._listaPersonas[this.dgwPrincipal.CurrentRow.Index]);
            Baja.Text = "Baja";
            Baja.ShowDialog();

            if (Baja.DialogResult == DialogResult.OK)
            {
                if (MessageBox.Show("SEGURITO SEGURITO QUE QUIERE BORRAR", "DELETEEEE", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.dgwPrincipal.Rows.Remove(this.dgwPrincipal.CurrentRow);
                    //this._listaPersonas.Remove(Baja.miPersona);
                    this._BindingSouce.MoveNext();
                }                
            }
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate Modificacion = new frmUpdate(this._listaPersonas[this.dgwPrincipal.CurrentRow.Index]);
            Modificacion.Text = "Modificacion";
            Modificacion.ShowDialog();

            if (Modificacion.DialogResult == DialogResult.OK)
            {
                this._listaPersonas[this.dgwPrincipal.CurrentRow.Index] = Modificacion.miPersona;
                this.dgwPrincipal.DataSource = null;
                this.dgwPrincipal.DataSource = this._BindingSouce;
            }
                
        }

    }
}
