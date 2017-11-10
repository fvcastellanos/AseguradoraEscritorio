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
        private proveedor _proveedor;

        public FormularioModificarProveedor()
        {
            InitializeComponent();
            _client = new ServicioAseguradoraClient();
        }


    }
}
