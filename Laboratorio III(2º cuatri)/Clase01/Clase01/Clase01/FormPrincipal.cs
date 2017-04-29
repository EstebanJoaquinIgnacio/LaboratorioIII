using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase01
{
    //En las propiedades del FORMULARIO tengo AcceptButton y CancelButton, que me declara que tecla hace que cosa respectivamente con Enter y ESC
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;
            resultado = Int32.Parse(this.txtNumeroUno.Text) + Int32.Parse(this.txtNumeroDos.Text);
            if (resultado == 0)
                this.txtResultado.ForeColor = System.Drawing.Color.Red;
            else if(0 == (resultado % 2))
                this.txtResultado.ForeColor = System.Drawing.Color.Black;
            else
                this.txtResultado.ForeColor = System.Drawing.Color.Violet;
            this.txtResultado.Text = resultado.ToString();
            this.txtNumeroUno.ReadOnly = true;
            this.txtNumeroDos.ReadOnly = true;
            // this.txtResultado.ReadOnly = true;
            
        }

 

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumeroDos.ReadOnly = false;
            this.txtNumeroUno.ReadOnly = false;
            this.txtNumeroDos.Text = "";
            this.txtNumeroUno.Text = "";
            this.txtResultado.Text = "";
            this.txtNumeroUno.Focus();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //TabIndex sigue el orden segun los numeros que le pusiste(sigue el orden) y el TabStop cancela que siga al tab
            this.txtNumeroUno.Focus();
            this.txtNumeroUno.TabIndex = 1;
            this.txtNumeroDos.TabIndex = 2;
            this.btnCalcular.TabIndex = 3;
            this.btnLimpiar.TabIndex = 4;
            this.txtResultado.TabStop = false;

        }

        //este evento es para cuando AGARRA o PIERDE EL FOCO
        private void txtResultado_Enter(object sender, EventArgs e)
        {
            this.txtResultado.ReadOnly = true;
        }

        private void txtResultado_Leave(object sender, EventArgs e)
        {
            this.txtResultado.ReadOnly = false;
        }


        
    }

        
}
