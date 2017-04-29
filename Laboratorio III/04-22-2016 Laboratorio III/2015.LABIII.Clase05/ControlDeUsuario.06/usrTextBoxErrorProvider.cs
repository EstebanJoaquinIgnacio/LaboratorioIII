using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlDeUsuario._06
{
    public partial class usrTextBoxErrorProvider : UserControl
    {
        public String Apellido 
        {
            get { return this.txtApellido.Text; } 
        }

        public String Nombre
        {
            get { return this.txtNombre.Text; }
        }

        public usrTextBoxErrorProvider()
        {
            InitializeComponent();

            //AGREGO MANEJADOR PARA EL EVENTO VALIDATING
            this.txtApellido.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxes_Validating);
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxes_Validating);

            //AGREGO MANEJADOR PARA EL EVENTO VALIDATED
            this.txtApellido.Validated += new System.EventHandler(this.textBoxes_Validated);
            this.txtNombre.Validated += new System.EventHandler(this.textBoxes_Validated);

        }

        private void textBoxes_Validating(object sender, CancelEventArgs e)
        {
            //SI EL DATO NO ES VALIDO, CANCELO LA VALIDACION
            if (String.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                e.Cancel = true;

                //SETEO AL OBJETO ERRORPROVIDER
                errorProvider1.SetError((Control)sender, "El campo es requerido!!!");
                errorProvider1.BlinkRate = 500;
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            }
        }

        private void textBoxes_Validated(object sender, EventArgs e)
        {
            //ES VALIDO EL CAMPO, LIMPIO EL ERRORPROVIDER 
            errorProvider1.Clear();
        }
    }
}
