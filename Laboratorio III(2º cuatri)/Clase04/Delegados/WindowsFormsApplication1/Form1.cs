using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delegados;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<Auto> miLista = new List<Auto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuto Alta = new frmAuto();
            Alta.ShowDialog();
            if (Alta.DialogResult == DialogResult.OK) {
                this.miLista.Add(Alta.Auto1);
            }
            foreach (Auto item in this.miLista)
            {
                this.listBox1.Items.Add(item.ToString());
            }
        }
    }
}
