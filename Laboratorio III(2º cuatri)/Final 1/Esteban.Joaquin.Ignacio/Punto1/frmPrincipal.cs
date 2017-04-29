using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto1
{
    public partial class frmPrincipal : Form
    {
        delegate void miDelegado(Control objeto);

        event miDelegado queEs;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void queEs(Control objeto)
        {
            
        }

        private void button1_Click(Control objeto)
        {

        }
    }
}
