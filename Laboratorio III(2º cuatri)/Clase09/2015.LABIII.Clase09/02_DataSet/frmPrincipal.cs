using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _02_DataSet
{
    public partial class frmPrincipal : Form
    {
        private DataTable _dtProductos;
        private DataTable _dtProveedores;
        private DataSet _dsNegocio;

        private static Int32 cont  = 100;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            this._dtProductos = Generadora.DefinirTabla(ETabla.Producto);
            this._dtProveedores = Generadora.DefinirTabla(ETabla.Proveedor);

            this._dsNegocio = Generadora.CargarDataSet(new System.Data.DataTable[]
                                    {this._dtProductos, this._dtProveedores});

            this._dsNegocio = Generadora.EstablecerRelaciones(this._dsNegocio);


            foreach(DataTable Tabla in this._dsNegocio.Tables)
                this.cboTablas.Items.Add(Tabla.TableName);


            MessageBox.Show("DataTables y DataSet creados!!!");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Declaro un DataRow
            DataRow fila;
            cont++;

            //le doy el formato de mi tabla
            fila = this._dsNegocio.Tables["Productos"].NewRow();
            
            //agrego valores
            try
            {
                //Agrego a proveedores
                this._dsNegocio.Tables["Proveedores"].Rows.Add(new Object[] {cont, "NombreProveedor" + cont});
                
                //Agrego a Productos
                fila[1] = "NombreProducto" + cont;
                fila[2] = cont;

                this._dsNegocio.Tables["Productos"].Rows.Add(fila);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Int32 i = this.cboTablas.SelectedIndex;

            this.lstVisor.Items.Clear();

            try
            {
                switch (i)
	            {
                    case 0://PRODUCTOS
                        foreach (DataRow fila in this._dsNegocio.Tables[i].Rows)
	                    {
	    	                this.lstVisor.Items.Add(fila[0].ToString() + " --- " +
                                fila.GetParentRow("ProductosProveedor")[1].ToString() +
                                fila[1].ToString());
	                    }
                        break;
                    case 1://PROVEEDORES
                        foreach (DataRow fila in this._dsNegocio.Tables[i].Rows)
	                    {
                            this.lstVisor.Items.Add(fila[0].ToString() + " --- " +
                                fila[1].ToString());
                        }
                        break;
		            default:
                        break;
	            }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrarProductosPorProveedor_Click(object sender, EventArgs e)
        {
            this.lstVisor.Items.Clear();

            foreach (DataRow fila in this._dsNegocio.Tables["Proveedores"].Rows)
            {
                this.lstVisor.Items.Add(fila[0].ToString() + " --- " +
                    fila[1].ToString());
                this.lstVisor.Items.Add("*********************************");

                foreach (DataRow filaProd in fila.GetChildRows("ProductosProveedor"))
                {
                    this.lstVisor.Items.Add(filaProd[0].ToString() + " --- " +
                        filaProd[1].ToString());
                }
                this.lstVisor.Items.Add("*********************************");
            }

        }

    }
}
