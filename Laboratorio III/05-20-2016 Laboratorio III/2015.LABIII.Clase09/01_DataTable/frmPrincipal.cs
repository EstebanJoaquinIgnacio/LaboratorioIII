using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _01_DataTable
{
    public partial class frmPrincipal : Form
    {
        private const String PATH_XML_PRODUCTOS = @"C:\DataTableProductosDatos.xml";
        private const String PATH_XML_PRODUCTOS_SCHEMA = @"C:\DataTableProductosSchema.xml";

        private DataTable _dtProductos;


        public frmPrincipal()
        {
            InitializeComponent();

            this.dgvGrilla.MultiSelect = false;
            this.dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.btnModificar.Click += new EventHandler(btnModificar_Click);

            this.btnBorrar.Click += new EventHandler(btnBorrar_Click);

        }

        private void btnCrearDataTable_Click(object sender, EventArgs e)
        {

            this._dtProductos = new DataTable("Productos");

            this._dtProductos.Columns.Add("IdProducto", typeof(Int32));
            this._dtProductos.Columns.Add("Descripcion", typeof(String));

            this._dtProductos.PrimaryKey = new DataColumn[] { this._dtProductos.Columns[0] };

            MessageBox.Show("Se ha creado el DataTable!!!");

        }

        private void btnCargarDataTable_Click(object sender, EventArgs e)
        {
            if(!CargarDataTableConArrayObject())
            {
                MessageBox.Show("Error al cargar DataTable. ", 
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                CargarGrilla();
            }

        }

        private void btnCargarDataTableLista_Click(object sender, EventArgs e)
        {
            if(!CargarDataTableConListaProductos())
            {
                MessageBox.Show("Error al cargar DataTable. ", 
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CargarGrilla();
            }

        }

        private void btnEsquema_Click(object sender, EventArgs e)
        {
            try
            {
                this._dtProductos.WriteXmlSchema(PATH_XML_PRODUCTOS_SCHEMA);

                MessageBox.Show("Se ha serializado el esquema del DataTable!!!");
            }
            catch
            {
                MessageBox.Show("Error al serializar el esquema del DataTable. ",
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            try
            {
                this._dtProductos.WriteXml(PATH_XML_PRODUCTOS);

                MessageBox.Show("Se han serializado los datos del DataTable!!!");
            }
            catch
            {
                MessageBox.Show("Error al serializar los datos del DataTable. ",
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCargarEsquema_Click(object sender, EventArgs e)
        {
            if(File.Exists(PATH_XML_PRODUCTOS_SCHEMA))
            {
                this._dtProductos = new DataTable();

                this._dtProductos.ReadXmlSchema(PATH_XML_PRODUCTOS_SCHEMA);

                MessageBox.Show("Se ha cargado el esquema del DataTable!!!");
            }
            else
                MessageBox.Show("No existe ningún documento XML");

        }

        private void btnCargarXML_Click(object sender, EventArgs e)
        {
            if (File.Exists(PATH_XML_PRODUCTOS))
            {
                this._dtProductos.ReadXml(PATH_XML_PRODUCTOS);

                MessageBox.Show("Se han cargado los datos del DataTable!!!");

                CargarGrilla();
            }
            else
                MessageBox.Show("No existe ningún documento XML");

        }

        private void btnMostrarRowState_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder misDatos = new System.Text.StringBuilder();

            misDatos.AppendLine("Tabla : " + _dtProductos.TableName);

            foreach(DataRow miFila in this._dtProductos.Rows)
            {
                misDatos.Append(miFila.RowState.ToString());
                misDatos.Append("  ");
                misDatos.AppendLine();
            }

            frmMostrar frm = new frmMostrar(misDatos.ToString());

            frm.ShowDialog();
        }

        private void btnAceptarCambios_Click(object sender, EventArgs e)
        {
            //this._dtProductos.AcceptChanges();

            foreach (DataRow fila in this._dtProductos.Rows)
            {
                fila.AcceptChanges();
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            this._dtProductos.RejectChanges();

            CargarGrilla();
        }

        #region Métodos privados

        private Boolean CargarDataTableConArrayObject()
        {
            Boolean todoOK = false;

            try
            {

                this._dtProductos.Rows.Add(new Object[] {1, "Sugus"});
                this._dtProductos.Rows.Add(new Object[] {2, "Sprite"});
                this._dtProductos.Rows.Add(new Object[] {3, "Jorgito"});
                this._dtProductos.Rows.Add(new Object[] {4, "Quilmes"});
                this._dtProductos.Rows.Add(new Object[] {5, "Manaos"});
                this._dtProductos.Rows.Add(new Object[] {6, "7UP"});
                this._dtProductos.Rows.Add(new Object[] {7, "Cachafaz"});

                todoOK = true;
            }
            catch (Exception)
            {
                todoOK = false;

            }

            return todoOK;

        }

        private Boolean CargarDataTableConListaProductos()
        {

            Boolean todoOK = false;

            try{

                DataRow fila;

                foreach(Producto prod in CargarListaGenericaProductos())
                {
                    fila = this._dtProductos.NewRow();

                    fila[0] = prod.idProducto;
                    fila["Descripcion"] = prod.descripcion;

                    this._dtProductos.Rows.Add(fila);

                }

                todoOK = true;
            }
            catch(Exception)
            {
                todoOK = false;
            }

            return todoOK;
        }
        
        private List<Producto> CargarListaGenericaProductos()
        {
            List<Producto> lista =  new List<Producto>();

            lista.Add(new Producto(8, "Cepita"));
            lista.Add(new Producto(9, "Chupetín"));
            lista.Add(new Producto(10, "Paso de los toros"));
            lista.Add(new Producto(11, "Media hora"));
            lista.Add(new Producto(12, "Acuarius"));
            lista.Add(new Producto(13, "Actimel"));
            lista.Add(new Producto(14, "Serenito"));

            return lista;
        }

        private void CargarGrilla()
        {
            this.dgvGrilla.Rows.Clear();

            foreach(DataRow fila in this._dtProductos.Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                    this.dgvGrilla.Rows.Add(new Object[] {fila["IdProducto"], fila["Descripcion"]});
            }

        }
        #endregion

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmABM frm = new frmABM();

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataRow fila = this._dtProductos.NewRow();
                fila["IdProducto"] = frm.ProductoDelFormulario.IdProducto;
                fila["Descripcion"] = frm.ProductoDelFormulario.Descripcion;

                this._dtProductos.Rows.Add(fila);

                CargarGrilla();
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Int32 indice = this.dgvGrilla.CurrentRow.Index;

            Producto p = new Producto(int.Parse(this._dtProductos.Rows[indice]["IdProducto"].ToString()), this._dtProductos.Rows[indice]["Descripcion"].ToString());

            frmABM frm = new frmABM(p);

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this._dtProductos.Rows[indice]["IdProducto"] = frm.ProductoDelFormulario.IdProducto;
                this._dtProductos.Rows[indice]["Descripcion"] = frm.ProductoDelFormulario.Descripcion;

                CargarGrilla();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Int32 indice = this.dgvGrilla.CurrentRow.Index;

            Producto p = new Producto(int.Parse(this._dtProductos.Rows[indice]["IdProducto"].ToString()), this._dtProductos.Rows[indice]["Descripcion"].ToString());

            frmABM frm = new frmABM(p);

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this._dtProductos.Rows[indice].Delete();

                CargarGrilla();
            }
        }

        private void dgvGrilla_SelectionChanged(object sender, EventArgs e)
        {
            //this.dgvGrilla.SelectionChanged -= new EventHandler(dgvGrilla_SelectionChanged);


            //this.btnModificar.Click += new EventHandler(btnModificar_Click);

            //this.btnBorrar.Click += new EventHandler(btnBorrar_Click);

        }



    }
}
