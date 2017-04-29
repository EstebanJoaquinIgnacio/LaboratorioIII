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
            
            //AGREGO MANEJADOR
            this.lstLista.SelectedIndexChanged += new EventHandler(lstLista_SelectedIndexChanged);

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

            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {

                this._lista.Add(frm.MiObjeto);

                this.MostrarLista();
            }

        }
        #endregion

        #region BAJA
        private void btnBaja_Click(object sender, EventArgs e)
        {
            Int32 index = this.lstLista.SelectedIndex;

            frmABM frm = new frmABM(this._lista[index]);

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Text = "BAJA";
            frm.ShowDialog();

            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this._lista.RemoveAt(index);

                this.MostrarLista();
            }

            //REMUEVO EL MANEJADORES DE LOS BOTONES
            this.btnModificacion.Click -= btnModificacion_Click;
            this.btnBaja.Click -= btnBaja_Click;

            //AGREGO MANEJADOR A LA LISTA
            this.lstLista.SelectedIndexChanged += new EventHandler(lstLista_SelectedIndexChanged);
        }
        #endregion

        #region MODIFICACION
        private void btnModificacion_Click(object sender, EventArgs e)
        {
            Int32 index = this.lstLista.SelectedIndex;

            frmABM frm = new frmABM(this._lista[index]);

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Text = "MODIFICACION";
            frm.ShowDialog();

            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this._lista[index] = frm.MiObjeto;

                this.MostrarLista();
            }

            //REMUEVO EL MANEJADORES DE LOS BOTONES
            this.btnModificacion.Click -= btnModificacion_Click;
            this.btnBaja.Click -= btnBaja_Click;
            
            //AGREGO MANEJADOR A LA LISTA
            this.lstLista.SelectedIndexChanged += new EventHandler(lstLista_SelectedIndexChanged);
        }
        #endregion

        #region Manejo de los Manejadores
        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AGREGO MANEJADORES PARA LOS EVENTOS CLICK DE LOS BOTONES DE BAJA Y MODIFICACION
            this.btnBaja.Click += new EventHandler(btnBaja_Click);
            this.btnModificacion.Click += new EventHandler(btnModificacion_Click);
            
            //REMUEVO EL MANEJADOR DEL SELECTEDINDEXCHANGED
            this.lstLista.SelectedIndexChanged -= lstLista_SelectedIndexChanged;
        }
        #endregion

        private void lstLista_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnBaja_Click_1(object sender, EventArgs e)
        {

        }

    }
}
