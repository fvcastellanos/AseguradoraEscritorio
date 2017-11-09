using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AseguradoraEscritorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listadoPolizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPolizas formaPolizas = new frmPolizas();
            formaPolizas.Show();
        }
    }
}
