using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo.SegundoParcial.LabIII
{
    public partial class frmMostrar : Form
    {
        public frmMostrar()
        {
            InitializeComponent();
        }

        public frmMostrar(DataSet unaDataSet,string DataMenmber):this()
        {
            this.dataGridView1.DataSource = unaDataSet;
            this.dataGridView1.DataMember = DataMenmber;
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {

        }
    }
}
