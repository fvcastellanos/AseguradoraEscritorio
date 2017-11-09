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

namespace AseguradoraEscritorio
{
    public partial class frmPolizas : Form
    {


        public frmPolizas()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
        }

        private void cargarPolizas()
        {
            var cliente = new ServicioAseguradoraClient();

            var respuesta = cliente.obtenerPolizas();

            polizasBindingSource.Clear();

            if (respuesta.estado.Equals("ERROR"))
            {
                MessageBox.Show(respuesta.mensaje);

                return;
            }

            foreach (var p in respuesta.polizas)
                polizasBindingSource.List.Add(p);
        }

        private void refrescarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarPolizas();
        }

        private void frmPolizas_Shown(object sender, EventArgs e)
        {
            cargarPolizas();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nuevaPoliza = new frmNuevaPoliza();
            nuevaPoliza.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var modificarPoliza = new frmModificarPoliza();
            modificarPoliza.Show();
        }
    }
}
