using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AseguradoraEscritorio.Boletas;
using AseguradoraEscritorio.Polizas;
using AseguradoraEscritorio.Proveedores;

namespace AseguradoraEscritorio
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void polizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formaPolizas = new FormularioPolizas();
            formaPolizas.Show();
        }

        private void boletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new FormularioBoletas();
            formulario.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new FormularioProveedores();
            formulario.Show();
        }
    }
}
