using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _02_WindowsForm.Controles
{
    public partial class frmCheckBox : Form
    {
        //DEFINO ATRIBUTO
        private string _cadenaOriginal;

        public frmCheckBox()
        {
            // Llamada necesaria para el Diseñador de Windows Forms.
            InitializeComponent();

            this._cadenaOriginal = "Estamos visualizando una cadena";
            this.lblMuestra.Text = _cadenaOriginal;

            //COLOCO EL ESTADO EN 'IDETERMINADO'
            this.chkMostrar.CheckState = CheckState.Indeterminate;
        }

        //ESTE EVENTO SE PRODUCE CUANDO SE HACE CLICK EN EL CHECKBOX Y 
        //CAMBIA EL CONTENIDO DE LA CASILLA
        private void chkColor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkColor.CheckState == CheckState.Checked)
                this.BackColor = Color.LightBlue;
            else
                this.ResetBackColor();
        }

        //ESTE EVENTO SE PRODUCE CUANDO CAMBIA EL ESTADO DE LA CASILLA
        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            switch (this.chkMostrar.CheckState)
            {
                case CheckState.Checked:
                    this.lblMuestra.Text = this._cadenaOriginal;
                    break;
                case CheckState.Indeterminate:
                    this.lblMuestra.Text = "";
                    break;
                case CheckState.Unchecked:
                    this.lblMuestra.Text = this._cadenaOriginal.Substring(0, (this._cadenaOriginal.Length / 2));
                    break;
                default:
                    break;
            }

        }
/*
        private void chkColor_CheckedChanged(object sender, EventArgs e)
        {
        }

        //ESTE EVENTO SE PRODUCE CUANDO CAMBIA EL ESTADO DE LA CASILLA
        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {

        }
*/


    }
}
