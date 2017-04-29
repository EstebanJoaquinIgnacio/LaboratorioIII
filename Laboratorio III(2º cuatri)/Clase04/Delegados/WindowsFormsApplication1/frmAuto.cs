using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmAuto : Form
    {
        private Delegados.Auto miAuto;

        public Delegados.Auto Auto1{
            get { return this.miAuto; }
        }
        public frmAuto()
        {
            InitializeComponent();
        }
        public frmAuto(Delegados.Auto paramAuto):base()
        {
            this.miAuto = paramAuto;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public virtual void Accept_Click(object sender, EventArgs e)
        {
            this.miAuto = new Delegados.Auto(this.textBox1.Text);
            this.DialogResult = DialogResult.OK;

        }

        private void frmAuto_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
