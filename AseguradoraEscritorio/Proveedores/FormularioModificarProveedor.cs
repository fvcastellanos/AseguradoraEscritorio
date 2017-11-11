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
    public partial class FormularioModificarProveedor : Form
    {
        private readonly ServicioAseguradoraClient _client;
        private readonly string _nit;
        private proveedor _proveedor;

        public FormularioModificarProveedor()
        {
            InitializeComponent();
            _client = new ServicioAseguradoraClient();
        }

        public FormularioModificarProveedor(string nit)
        {
            InitializeComponent();
            _client = new ServicioAseguradoraClient();
            _nit = nit;
        }

        private void CargarProveedor(string nit)
        {
            var resultado = _client.obtenerProveedor(nit);

            if (resultado.estado.Equals("ERROR"))
            {
                MessageBox.Show(resultado.mensaje);

                return;
            }

            _proveedor = resultado.proveedor;

            TextoNit.Text = _proveedor.nit;
            TextoNombre.Text = _proveedor.nombre;
        }

        private void FormularioModificarProveedor_Shown(object sender, EventArgs e)
        {
            CargarProveedor(_nit);
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            GuardarProveedor();
        }

        private void GuardarProveedor()
        {
            _proveedor.nit = TextoNit.Text;
            _proveedor.nombre = TextoNombre.Text;

            var resultado = _client.modificarProveedor(_proveedor);

            if (resultado.estado.Equals("ERROR"))
            {
                MessageBox.Show(resultado.mensaje);

                return;
            }

            Close();
        }
    }
}
