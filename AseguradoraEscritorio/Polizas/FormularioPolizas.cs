using System;
using System.Linq;
using System.Windows.Forms;
using AseguradoraEscritorio.ServicioWebAseguradora;

namespace AseguradoraEscritorio.Polizas
{
    public partial class FormularioPolizas : Form
    {
        public FormularioPolizas()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
        }

        private void CargarPolizas()
        {
            var cliente = new ServicioAseguradoraClient();

            var respuesta = cliente.obtenerPolizas();

            polizasBindingSource.Clear();

            if (respuesta.estado.Equals("ERROR"))
            {
                MessageBox.Show(respuesta.mensaje);

                return;
            }

            var polizasOrdenadas =
                from d in respuesta.polizas
                orderby d.id
                select d;

            foreach (var p in polizasOrdenadas)
                polizasBindingSource.List.Add(p);
        }

        private void refrescarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarPolizas();
        }

        private void frmPolizas_Shown(object sender, EventArgs e)
        {
            CargarPolizas();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nuevaPoliza = new FormularioNuevaPoliza();
            var result = nuevaPoliza.ShowDialog();

            if (result.Equals(DialogResult.OK))
                CargarPolizas();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var modificarPoliza = new FormularioModificarPoliza();
            var result = modificarPoliza.ShowDialog();

            if (result.Equals(DialogResult.OK))
                CargarPolizas();
        }
    }
}
