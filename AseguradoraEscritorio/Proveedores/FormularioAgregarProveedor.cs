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
    public partial class FormularioAgregarProveedor : Form
    {
        public FormularioAgregarProveedor()
        {
            InitializeComponent();
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            var cliente = new ServicioAseguradoraClient();

            var proveedor = ConstruirProveedor(TextoNit.Text, TextoNombre.Text);
            var respuesta = cliente.agregarProveedor(proveedor);

            if (respuesta.estado.Equals("ERROR"))
            {
                MessageBox.Show(respuesta.mensaje);
                return;
            }

            Close();
        }

        private proveedor ConstruirProveedor(string nit, string nombre)
        {
            return new proveedor()
            {
                nit = nit,
                nombre = nombre
            };
        }
    }
}
