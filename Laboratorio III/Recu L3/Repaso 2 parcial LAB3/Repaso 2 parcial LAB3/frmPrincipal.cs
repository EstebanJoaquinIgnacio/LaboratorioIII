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

        private DataSet DataSetArticulos;
        private DataTable DataTableArticulos;
        private SqlDataAdapter SQLAdaptador;
        private SqlDataReader SQLlector;
        private SqlConnection Coneccion;

        public frmPrincipal()
        {
            InitializeComponent();
            this.DataSetArticulos = new DataSet();
            this.DataTableArticulos = new DataTable("dtArticulos");
            this.DataTableArticulos.Columns.Add("Marca", typeof(string));
            this.DataTableArticulos.Columns.Add("Precio", typeof(double));
            this.DataTableArticulos.Columns.Add("Tipo", typeof(Etipo));
            this.DataTableArticulos.Columns.Add("Stock", typeof(int));

            this.DataSetArticulos.Tables.Add(this.DataTableArticulos);

            //this.DataTableArticulos = new DataTable(

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulo frmAlta = new frmArticulo();
            frmAlta.Text = "Alta articulo";
            frmAlta.ShowDialog();

            if (frmAlta.DialogResult == DialogResult.OK)
            {
                Articulo miArticulo = frmAlta.miArticulo;
                DataRow fila = this.DataSetArticulos.Tables["Articulos"].NewRow();

                fila[0] = miArticulo.Marca;
                fila[1] = miArticulo.PrecioVenta;
                fila[2] = miArticulo.Tipo;                        
                fila[3] = miArticulo.Stock;

                this.DataSetArticulos.Tables["Articulos"].Rows.Add(fila);
            }
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lbxMostrar.Items.Clear();

            foreach (DataRow item in this.DataSetArticulos.Tables["Articulos"].Rows)
            {
                if(item.RowState != DataRowState.Deleted)
                    this.lbxMostrar.Items.Add(item[0] + "-"+item[1]+"-"+item[2]+"-"+item[3]);
            }
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcaABorrar ItemAEliminar = new frmMarcaABorrar();
            ItemAEliminar.Text = "Marca a borrar";
            ItemAEliminar.ShowDialog();

            if (ItemAEliminar.DialogResult == DialogResult.OK)
            {
                bool flag = false;
                for (int i = 0; i < this.DataSetArticulos.Tables["Articulos"].Rows.Count;i++ )
                {
                    if (Convert.ToString(this.DataSetArticulos.Tables["Articulos"].Rows[i][0]) == ItemAEliminar.MarcaABorrar)
                    {
                        
                        this.DataSetArticulos.Tables["Articulos"].Rows[i].Delete();
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    MessageBox.Show("se elimino correctamente");
                }
                else
                {
                    MessageBox.Show("no se encuentra el articulo");
                }
            }
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcaABorrar ItemAModificar = new frmMarcaABorrar();
            ItemAModificar.Text = "Marca a modificar";
            ItemAModificar.ShowDialog();

            if (ItemAModificar.DialogResult == DialogResult.OK)
            {
                bool flag = false;
                for (int i = 0; i < this.DataSetArticulos.Tables["Articulos"].Rows.Count; i++)
                {
                    if (Convert.ToString(this.DataSetArticulos.Tables["Articulos"].Rows[i][0]) == ItemAModificar.MarcaABorrar)
                    {
                        frmArticulo AModificar = new frmArticulo();
                        AModificar.Text = "Modificacion";
                        AModificar.ShowDialog();

                        if (AModificar.DialogResult == DialogResult.OK)
                        {
                            Articulo miArticulo = AModificar.miArticulo;

                            this.DataSetArticulos.Tables["Articulos"].Rows[i][0] = miArticulo.Marca;
                            this.DataSetArticulos.Tables["Articulos"].Rows[i][1] = miArticulo.PrecioVenta;
                            this.DataSetArticulos.Tables["Articulos"].Rows[i][2] = miArticulo.Tipo;
                            this.DataSetArticulos.Tables["Articulos"].Rows[i][3] = miArticulo.Stock;
                            flag = true;
                            break;
                        }                        
                        
                    }
                }

                if (flag)
                {
                    MessageBox.Show("se modifico correctamente");
                }
                else
                {
                    MessageBox.Show("NO SE PUDO MODIFICAR");
                }


            }
        }

        private void ConfigurarDataAdapter()
        {
            this.Coneccion = new SqlConnection(Properties.Settings.Default.cnn);

            SqlCommand _select = new SqlCommand("SELECT * FROM dbo.Articulos", this.Coneccion);
            SqlCommand _insert = new SqlCommand("INSERT INTO dbo.Articulos VALUES (@marca,@precioVenta,@stock,@tipo)",this.Coneccion);
            SqlCommand _update = new SqlCommand("UPDATE dbo.Articulos SET marca = @marca, precioVenta = @precioVenta, Stock=@Stock,tipo = @tipo", this.Coneccion);
            SqlCommand _delete = new SqlCommand("DELETE dbo.Articulos WHERE id = @id", this.Coneccion);

            this.SQLAdaptador.InsertCommand.Parameters.Add("@marca", SqlDbType.VarChar, 30,"marca");
            this.SQLAdaptador.InsertCommand.Parameters.Add("@precioVento", SqlDbType.Real, 3, "precioVenta");
            this.SQLAdaptador.InsertCommand.Parameters.Add("@stock", SqlDbType.Int, 1, "stock");
            this.SQLAdaptador.InsertCommand.Parameters.Add("@tipo", SqlDbType.Int, 1, "tipo");

            this.SQLAdaptador.UpdateCommand.Parameters.Add("@marca", SqlDbType.VarChar, 30, "marca");
            this.SQLAdaptador.UpdateCommand.Parameters.Add("@precioVento", SqlDbType.Real, 3, "precioVenta");
            this.SQLAdaptador.UpdateCommand.Parameters.Add("@stock", SqlDbType.Int, 1, "stock");
            this.SQLAdaptador.UpdateCommand.Parameters.Add("@tipo", SqlDbType.Int, 1, "tipo");

            this.SQLAdaptador.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id");
        }

        private void TraerDatos()
        {
            DataTable dtArticulos = new DataTable("dtArticulos");
            SqlCommand comandoArticulos = new SqlCommand();

            try
            {
                comandoArticulos.CommandType = CommandType.Text;
                comandoArticulos.CommandText = "SELECT * FROM dbo.Articulos";                
                comandoArticulos.Connection = this.Coneccion;

                this.Coneccion.Open();
                this.SQLlector = comandoArticulos.ExecuteReader();
                dtArticulos.Load(this.SQLlector);
                this.Coneccion.Close();                
            }
            catch (Exception)
            {}

            this.DataSetArticulos.Tables.Add(dtArticulos);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SQLAdaptador.Update(this.DataSetArticulos.Tables["dtArticulos"]);
        }

        private void alta()
        {
            frmArticulo alta = new frmArticulo();
            alta.Text = "Alta articulo";
            alta.ShowDialog();

            if (alta.DialogResult == DialogResult.OK)
            {
                Articulo miArticulo = alta.miArticulo;
                DataRow fila = this.DataSetArticulos.Tables["dtArticulos"].NewRow();

                fila[0] = miArticulo.Marca;
                fila[1] = miArticulo.PrecioVenta;
                fila[2] = miArticulo.Stock;
                fila[3] = miArticulo.Tipo;

                this.DataSetArticulos.Tables["dtArticulos"].Rows.Add(fila);

            }

        }

        private void baja()
        {
            frmMarcaABorrar frmDato = new frmMarcaABorrar();
            frmDato.ShowDialog();

            if (frmDato.DialogResult == DialogResult.OK)
            {
                bool flag = false;

                foreach (DataRow item in this.DataSetArticulos.Tables["dtArticulos"].Rows)
	            {
                    if(item[0].ToString() == frmDato.tbxMarcaABorrar.Text)
                    {
                        frmArticulo frmBaja = new frmArticulo(); //cargo con todos los datos, Crear el constructor
                        frmBaja.Text = "baja";
                        frmBaja.ShowDialog();

                        if (frmBaja.DialogResult == DialogResult.OK)
                        {
                            flag = true;
                            item.Delete();
                            break;
                        }
                        
                    }
		            
	            }

                if (!flag)
                {
                    MessageBox.Show("No se encontro producto para borrar");
                }
                
            }
        }

        private void modificar()
        {
            frmMarcaABorrar frmDato = new frmMarcaABorrar();
            frmDato.ShowDialog();

            if (frmDato.DialogResult == DialogResult.OK)
            {
                bool flag = false;

                foreach (DataRow item in this.DataSetArticulos.Tables["dtArticulos"].Rows)
                {
                    if (item[0].ToString() == frmDato.tbxMarcaABorrar.Text)
                    {
                        frmArticulo frmModificar = new frmArticulo(); //cargo con todos los datos, Crear el constructor
                        frmModificar.Text = "modificar";
                        frmModificar.ShowDialog();

                        if (frmModificar.DialogResult == DialogResult.OK)
                        {

                            item[0] = frmModificar.miArticulo.Marca;
                            item[1] = frmModificar.miArticulo.PrecioVenta;
                            item[2] = frmModificar.miArticulo.Stock;
                            item[3] = frmModificar.miArticulo.Tipo;
                            flag = true;
                            break;
                        }

                    }

                }

                if (!flag)
                {
                    MessageBox.Show("No se encontro producto para modificar");
                }

            }
        }

        private void confiDATAADAPTER()
        {
            this.SQLAdaptador = new SqlDataAdapter();
            this.Coneccion = new SqlConnection(Properties.Settings.Default.cnn);

            SqlCommand cmmSelect = new SqlCommand("SELECT * FROM dbo.Articulos",this.Coneccion);
            SqlCommand cmmInsert = new SqlCommand("INSERT INTO dbo.Articulos VALUES(@marca,@precio,@stock,@tipo)", this.Coneccion);
            SqlCommand cmmUpdate = new SqlCommand("UPDATE dbo.Articulos SET marca = @marca,precio=@precio,stock=@stock,tipo=@tipo", this.Coneccion);
            SqlCommand cmmDelete = new SqlCommand("DELETE dbo.Articulos WHERE id = @id", this.Coneccion);

            this.SQLAdaptador.DeleteCommand = cmmDelete;
            this.SQLAdaptador.InsertCommand = cmmInsert;
            this.SQLAdaptador.UpdateCommand = cmmUpdate;
            this.SQLAdaptador.SelectCommand = cmmSelect;

            this.SQLAdaptador.InsertCommand.Parameters.Add("@marca", SqlDbType.VarChar, 30, "marca");
            this.SQLAdaptador.InsertCommand.Parameters.Add("@precio", SqlDbType.Real, 3, "precio");
            this.SQLAdaptador.InsertCommand.Parameters.Add("@stock", SqlDbType.Int, 3, "stock");
            this.SQLAdaptador.InsertCommand.Parameters.Add("@tipo", SqlDbType.Int, 1, "tipo");

            this.SQLAdaptador.UpdateCommand.Parameters.Add("@marca", SqlDbType.VarChar, 30, "marca");
            this.SQLAdaptador.UpdateCommand.Parameters.Add("@precio", SqlDbType.Real, 3, "precio");
            this.SQLAdaptador.UpdateCommand.Parameters.Add("@stock", SqlDbType.Int, 3, "stock");
            this.SQLAdaptador.UpdateCommand.Parameters.Add("@tipo", SqlDbType.Int, 1, "tipo");

            this.SQLAdaptador.DeleteCommand.Parameters.Add("@marca", SqlDbType.VarChar, 30, "marca");


        }

        private void TraerDatos()
        {
            this.DataTableArticulos = new DataTable("dtArticulos");
            SqlCommand comandoTraerDatos = new SqlCommand();

            try
            {
                comandoTraerDatos.CommandType = CommandType.Text;
                comandoTraerDatos.CommandText = "SELECT * FROM dbo.Articulos";
                comandoTraerDatos.Connection = this.Coneccion;

                this.Coneccion.Open();
                this.SQLlector = comandoTraerDatos.ExecuteReader();
                this.DataTableArticulos.Load(this.SQLlector);
                this.Coneccion.Close();

            }
            catch (Exception)
            {
             
            }

            this.DataSetArticulos.Tables.Add(this.DataTableArticulos);
        }

        private void Guardar()
        {
            this.SQLAdaptador.Update(this.DataSetArticulos.Tables["dtArtulos"]);
        }

    }
}
