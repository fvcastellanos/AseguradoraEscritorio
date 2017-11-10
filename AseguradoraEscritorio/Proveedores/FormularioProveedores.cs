using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AseguradoraEscritorio.ServicioWebAseguradora;

namespace AseguradoraEscritorio.Proveedores
{
    public partial class FormularioProveedores : Form
    {
        public FormularioProveedores()
        {
            InitializeComponent();
        }

        private void CargarProveedores()
        {
            var cliente = new ServicioAseguradoraClient();

            var respuesta = cliente.obtenerProveedores();

            if (respuesta.estado.Equals("ERROR"))
            {
                MessageBox.Show(respuesta.mensaje);
                return;
            }

            respuestaListadoProveedoresBindingSource.Clear();

            foreach (var proveedor in respuesta.proveedores)
            {
                respuestaListadoProveedoresBindingSource.Add(proveedor);
            }
        }

        private void FormularioProveedores_Shown(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void refrescarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new FormularioAgregarProveedor();
            var resultado = formulario.ShowDialog();

            if (resultado.Equals(DialogResult.OK))
                CargarProveedores();
        }
    }

}
