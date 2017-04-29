using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AplicacionWindowsForms
{
    public partial class frmPrincipal : Form
    {
        private List<Entidades.ClaseUno> _lista;

        public frmPrincipal()
        {
            InitializeComponent();

            this._lista = new List<Entidades.ClaseUno>();
            
            //AGREGAR MANEJADOR AL EVENTO SELECTEDINDEXCHANGE DEL LISTBOX
            this.lstLista.SelectedIndexChanged += new EventHandler(this.lstLista_SelectedIndexChanged);

        }

        private void MostrarLista()
        {
            this.lstLista.Items.Clear();

            foreach (Entidades.ClaseUno item in this._lista)
            {
                this.lstLista.Items.Add(item);
            }
        }

        #region ALTA
        private void btnAlta_Click(object sender, EventArgs e)
        {
           frmABM frm = new frmABM();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Text = "ALTA";

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this._lista.Add(frm.MiObjeto);
                this.MostrarLista();
            }
            //AGREGAR OBJETO, SIEMPRE Y CUANDO SE PULSE 'ACEPTAR'
            //REFRESCAR EL LISTADO

        }
        #endregion

        #region BAJA
        private void btnBaja_Click(object sender, EventArgs e)
        {
            
            //OBTENER EL OBJETO QUE FUE SELECCIONADO
            int indice = this.lstLista.SelectedIndex;

            //MOSTRAR EL FROM CON LOS DATOS DE DICHO OBJETO
            frmABM baja = new frmABM(this._lista[indice]);
            baja.Text = "BAJA";
            baja.ShowDialog();

            //REMOVER EL OBJETO, SIEMPRE Y CUANDO SE PULSE 'ACEPTAR'
            if (baja.DialogResult == DialogResult.OK)
            {
                this._lista.Remove(this._lista[indice]);              
                                
            }
            //REFRESCAR EL LISTADO
            this.MostrarLista();
            //REMOVER MANEJADORES PARA QUE NO SE PUEDA ACCEDER AL MANEJADOR       
            this.btnBaja.Click -= new EventHandler(this.btnBaja_Click);
            this.btnModificacion.Click -= new EventHandler(this.btnModificacion_Click);      
            
            //SIN ANTES SELECCIONARLO DEL LISTADO
            //AGREGAR MANEJADOR AL LISTADO
            this.lstLista.SelectedIndexChanged += new EventHandler(this.lstLista_SelectedIndexChanged);

            //COLOR 
            this.btnBaja.BackColor = Color.Transparent;
            this.btnModificacion.BackColor = Color.Transparent;

        }
        #endregion

        #region MODIFICACION
        private void btnModificacion_Click(object sender, EventArgs e)
        {
            //OBTENER EL OBJETO QUE FUE SELECCIONADO
            int indice = this.lstLista.SelectedIndex;
            //MOSTRAR EL FROM CON LOS DATOS DE DICHO OBJETO
            frmABM modificacion = new frmABM(this._lista[indice]);
            modificacion.Text = "MODIFICACION";
            modificacion.ShowDialog();

            //MODIFICAR AL OBJETO, SIEMPRE Y CUANDO SE PULSE 'ACEPTAR'
            if (modificacion.DialogResult == DialogResult.OK)
            {
                this._lista[indice] = modificacion.MiObjeto;
                
            }
            //REFRESCAR EL LISTADO
            this.MostrarLista();
            //REMOVER MANEJADORES PARA QUE NO SE PUEDA ACCEDER AL MANEJADOR       
            this.btnBaja.Click -= new EventHandler(this.btnBaja_Click);
            this.btnModificacion.Click -= new EventHandler(this.btnModificacion_Click); 
            //SIN ANTES SELECCIONARLO DEL LISTADO
            //AGREGO MANEJADOR AL LISTADO
            this.lstLista.SelectedIndexChanged += new EventHandler(this.lstLista_SelectedIndexChanged);

            //COLOR
            this.btnBaja.BackColor = Color.Transparent;
            this.btnModificacion.BackColor = Color.Transparent;

        }
        #endregion

        #region Manejo de los Manejadores
        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AGREGO MANEJADORES PARA LOS EVENTOS CLICK DE LOS BOTONES DE BAJA Y MODIFICACION
            this.btnBaja.Click += new EventHandler(this.btnBaja_Click);
            this.btnModificacion.Click += new EventHandler(this.btnModificacion_Click);
            //REMUEVO EL MANEJADOR DEL SELECTEDINDEXCHANGED, PARA QUE NO SE 'MANEJE' N VECES
            this.lstLista.SelectedIndexChanged -= new EventHandler(this.lstLista_SelectedIndexChanged);

            //COLOR A LOS BOTONES
            this.btnBaja.BackColor = Color.Red;
            this.btnModificacion.BackColor = Color.Yellow;
            
            
        }
        #endregion

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.btnAlta.BackColor = Color.LightGreen;
        }

        private void btnAlta_MouseHover(object sender, EventArgs e)
        {
            Random X = new Random();
            Random Y = new Random();

            X.Next(1, 1000);
            Y.Next(1, 400);

            //this.btnAlta.Location = System.Drawing.Point.Add;
            //this.btnAlta.Location.Y = Y;
        }



    }
}
