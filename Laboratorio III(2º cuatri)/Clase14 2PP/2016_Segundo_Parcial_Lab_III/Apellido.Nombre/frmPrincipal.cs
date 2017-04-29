using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Apellido.Nombre
{
    public partial class Form1 : Form
    {
        private DataTable _dtPerfiles;
        private DataTable _dtUsuarios;
        private DataSet _dataSetParcial;
        private System.Data.SqlClient.SqlDataAdapter _daParcial;
        private SqlConnection _coneccion;
        private DataRelation _relacion;

        public Form1()
        {
            InitializeComponent();
            this._coneccion = new SqlConnection(Properties.Settings.Default.cnn);
            this._dataSetParcial = new DataSet();
        }
        /// <summary>
        /// Puntos: 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPunto1_Click(object sender, EventArgs e)
        {
            //A.- Configurar de forma ‘manual’ el DataTable _dtPerfiles y cargarlo por medio de un DataReader. 
            //Para ello usted deberá realizar la consulta T-SQL para que se retorne Id y Descripción (utilizar alias). 
            //Nota: el campo ID debe ser autoincremental (comenzando desde 1 y de 3 en 3).
            SqlDataReader DReader;
            
            this._dtPerfiles = new DataTable("Perfiles");
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT Id_Perfil AS Id, Nombre_Perfil AS Descripción FROM Perfiles";
            comando.CommandType = CommandType.Text;
            comando.Connection = this._coneccion;

            try
            {
                this._coneccion.Open();
                DReader = comando.ExecuteReader();
                this._dtPerfiles.Load(DReader);
                this._coneccion.Close();

                this._dtPerfiles.Columns["Id"].AutoIncrement = true;
                this._dtPerfiles.Columns["Id"].AutoIncrementSeed = 1;
                this._dtPerfiles.Columns["Id"].AutoIncrementStep = 3;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar tabla perfil");
            }

            //B.- Serializar el esquema y los datos y guardarlos en dos archivos distintos.
            try
            {
                this._dtPerfiles.WriteXmlSchema("PerfilesEsquema.xml");
                this._dtPerfiles.WriteXml("PerfilesDatos.xml");
            }
            catch (Exception)
            {

                MessageBox.Show("Error al guardar en XML");
            }
            
            //C.- El cboPerfiles mostrará el listado con el nombre de los perfiles (no se podrán editar, por defecto aparecerá OPERADOR).
            //this.cboPerfiles.DataSource = 

            
            for (int i = 0; i < this._dtPerfiles.Rows.Count; i++)
            {
                this.cboPerfiles.Items.Add(this._dtPerfiles.Rows[i]["Descripción"]);
            }
            this.cboPerfiles.SelectedIndex = 2;
            

        }
        /// <summary>
        /// Puntos: 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPunto2_Click(object sender, EventArgs e)
        {
            //A.- Configurar un DataAdapter _daParcial para poder interactuar con el DataTable _dtUsuarios y la tabla Usuarios. 
            //Se pide que la instrucción T-SQL del SelectCommand retorne: Dni, Nombre, Edad y Perfil (utilizar alias). 
            this._dtUsuarios = new DataTable("Usuarios");
            this._daParcial = new SqlDataAdapter("SELECT Dni_Usuario AS Dni,Nombre_Usuario AS Nombre,Edad_Usuario AS Edad,Perfil_Usuario AS Perfil FROM Usuarios", this._coneccion);
            this._daParcial.Fill(this._dtUsuarios);
            
            //B.- Configurar TODOS sus comandos (INSERT, UPDATE y DELETE)
            //Nota: TODOS los campos se podrán modificar, a excepción de la PK.
            this._daParcial.InsertCommand = new SqlCommand("INSERT INTO Usuarios(Dni_Usuario,Nombre_Usuario,Edad_Usuario,Perfil_Usuario) VALUES(@Dni,@Nombre,@Edad,@Perfil)", this._coneccion);
            this._daParcial.UpdateCommand = new SqlCommand("UPDATE Usuarios SET Nombre_Usuario=@Nombre,Edad_Usuario=@Edad,Perfil_Usuario=@Perfil WHERE Dni_Usuario=@Dni", this._coneccion);
            this._daParcial.DeleteCommand = new SqlCommand("DELETE FROM Usuarios WHERE Dni_Usuario = @Dni", this._coneccion);

            this._daParcial.InsertCommand.Parameters.Add("@Dni",SqlDbType.Int,18,"Dni");
            this._daParcial.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this._daParcial.InsertCommand.Parameters.Add("@Edad", SqlDbType.Int, 18, "Edad");
            this._daParcial.InsertCommand.Parameters.Add("@Perfil", SqlDbType.Int, 18, "Perfil");

            this._daParcial.UpdateCommand.Parameters.Add("@Dni", SqlDbType.Int, 18, "Dni");
            this._daParcial.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            this._daParcial.UpdateCommand.Parameters.Add("@Edad", SqlDbType.Int, 18, "Edad");
            this._daParcial.UpdateCommand.Parameters.Add("@Perfil", SqlDbType.Int, 18, "Perfil");

            this._daParcial.DeleteCommand.Parameters.Add("@Dni", SqlDbType.Int, 18, "Dni");
            //C.- Mostrar el contenido del DataTable en dgvGrilla.
            this.dgvGrilla.DataSource = this._dtUsuarios;
            //this.dgvGrilla.DataMember = "Usuarios";
        }
        /// <summary>
        /// Puntos: 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPunto3_Click(object sender, EventArgs e)
        {
            //A.- Agregarle al DataSet _dsParcial los DataTables anteriores.
            this._dataSetParcial.Tables.Add(this._dtUsuarios);
            this._dataSetParcial.Tables.Add(this._dtPerfiles);
            //B.- Crear la relación entre los DataTables
            _relacion = new DataRelation("PerfilUsuarios",
                this._dataSetParcial.Tables["Perfiles"].Columns["Id"],
                this._dataSetParcial.Tables["Usuarios"].Columns["Perfil"]);

            this._dataSetParcial.Relations.Add(this._relacion);
        }
        /// <summary>
        /// Puntos: 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPunto4_Click(object sender, EventArgs e)
        {
            //A.- Agregar al _dtUsuarios cuatro nuevas filas.
            DataRow fila1 = this._dataSetParcial.Tables["Usuarios"].NewRow();
            fila1[0] = 5555;
            fila1[1] = "Micaela";
            fila1[2] = 15;
            fila1[3] = 4;
            this._dataSetParcial.Tables["Usuarios"].Rows.Add(fila1);

            DataRow fila2 = this._dataSetParcial.Tables["Usuarios"].NewRow();
            fila2[0] = 6666;
            fila2[1] = "Josephine";
            fila2[2] = 64;
            fila2[3] = 7;
            this._dataSetParcial.Tables["Usuarios"].Rows.Add(fila2);

            DataRow fila3 = this._dataSetParcial.Tables["Usuarios"].NewRow();
            fila3[0] = 7777;
            fila3[1] = "Armando";
            fila3[2] = 44;
            fila3[3] = 1;
            this._dataSetParcial.Tables["Usuarios"].Rows.Add(fila3);

            DataRow fila4 = this._dataSetParcial.Tables["Usuarios"].NewRow();
            fila4[0] = 8888;
            fila4[1] = "Prototype";
            fila4[2] = 33;
            fila4[3] = 4;
            this._dataSetParcial.Tables["Usuarios"].Rows.Add(fila4);

            //B.- Mostrar el contenido del DataTable en dgvGrilla.
            this.dgvGrilla.DataSource = this._dataSetParcial.Tables["Usuarios"];
        }
        /// <summary>
        /// Puntos: 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPunto5_Click(object sender, EventArgs e)
        {
            //A.- Se procederá a realizar la modificación de las filas 1 y 2. 
            //Previamente se le preguntará al usuario si está seguro de realizar la operación.
            if (MessageBox.Show("Seguro que quiere modificar fila 1 y 2?", "MODIFICACION", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //this._dataSetParcial.Tables["Usuarios"].Rows[0][0] = 12341111;
                this._dataSetParcial.Tables["Usuarios"].Rows[0][1] = "PrimeraFila";
                this._dataSetParcial.Tables["Usuarios"].Rows[0][2] = 10;
                this._dataSetParcial.Tables["Usuarios"].Rows[0][3] = 4;

                //this._dataSetParcial.Tables["Usuarios"].Rows[1][0] = 43214444;
                this._dataSetParcial.Tables["Usuarios"].Rows[1][1] = "SegundaFila";
                this._dataSetParcial.Tables["Usuarios"].Rows[1][2] = 20;
                this._dataSetParcial.Tables["Usuarios"].Rows[1][3] = 1;
            }
            //B.- Mostrar el contenido del DataTable en dgvGrilla.
            this.dgvGrilla.DataSource = this._dataSetParcial.Tables["Usuarios"];

        }
        /// <summary>
        /// Puntos: 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPunto6_Click(object sender, EventArgs e)
        {
            //A.- Se procederá a eliminar la fila 3 del DataTable _dtUsuarios. 
            //Previamente se le preguntará al usuario si está seguro de realizar la operación.
            if (MessageBox.Show("Seguro que quiere ELIMINAR la 3º fila?", "ELIMINAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this._dataSetParcial.Tables["Usuarios"].Rows[2].Delete();
            }
            //B.- Mostrar el contenido del DataTable en dgvGrilla.
            this.dgvGrilla.DataSource = this._dataSetParcial.Tables["Usuarios"];
        }
        /// <summary>
        /// Puntos: 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            //Sincronizar, a travez del DataAdapter _daParcial, el _dtUsuarios con la Base de Datos.
            this._daParcial.Update(this._dataSetParcial.Tables["Usuarios"]);
        }
        /// <summary>
        /// Puntos: 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Se mostrarán (en dgvGrilla) los datos de los usuarios según el perfil elegido (en cboPerfiles).  
            //Además, se mostrará el promedio de edad de los usuarios que poseen ese perfil (lblPromedioEdad). 
            //Nota: Utilizar: Select y GetParentRow o GetChildRows, según corresponda.
            

            DataRow[] padre = this._dataSetParcial.Tables["Perfiles"].Select("Descripción = 'ADMINISTRADOR'");

            switch (this.cboPerfiles.SelectedIndex)
            { 
                case 0:
                    padre = this._dataSetParcial.Tables["Perfiles"].Select("Descripción = 'ADMINISTRADOR'");
                    break;
                case 1:
                    padre = this._dataSetParcial.Tables["Perfiles"].Select("Descripción = 'AUDITOR'");
                    break;
                case 2:
                    padre = this._dataSetParcial.Tables["Perfiles"].Select("Descripción = 'OPERADOR'");
                    break;
            }

            this.dataGridView1.Rows.Clear();

            this.dataGridView1.ColumnCount = 4;

            this.dataGridView1.Columns[0].Name = "Dni_Usuario";
            this.dataGridView1.Columns[1].Name = "Nombre_Usuario";
            this.dataGridView1.Columns[2].Name = "Edad_Usuario";
            this.dataGridView1.Columns[3].Name = "Perfil_Usuario";

            foreach (DataRow item in padre[0].GetChildRows("PerfilUsuarios"))
            {
                this.dataGridView1.Rows.Add(item.ItemArray);
            }

        }
    }
}
