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
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.cboDropDown.Items.AddRange(new String[] {"AZUL", "VERDE", "AMARILLO", 
                                                        "ROJO", "BLANCO", "MARRÓN", "GRANATE"});
            this.cboDropDownList.Items.AddRange(new String[] {"ELENA", "JOSE", "ANA", 
                                                            "ALFREDO", "LUIS", "ANGEL", 
                                                            "RAQUEL"});
            this.cboSimple.Items.AddRange(new String[] {"AVELLANEDA", "QUILMES", "BERNAL", 
                                                      "LANUS", "BERAZATEGUI"});
        }
    }
}
