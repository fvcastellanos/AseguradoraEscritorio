using System;
using System.Linq;
using System.Windows.Forms;
using AseguradoraEscritorio.ServicioWebAseguradora;

namespace AseguradoraEscritorio.Boletas
{
    public partial class FormularioBoletas : Form
    {
        private readonly ServicioAseguradoraClient _cliente;
        private readonly string _noPoliza;

        public FormularioBoletas()
        {
            InitializeComponent();
            _cliente = new ServicioAseguradoraClient();
        }

        public FormularioBoletas(string noPoliza)
        {
            InitializeComponent();
            _cliente = new ServicioAseguradoraClient();
            _noPoliza = noPoliza;
        }

        private void CargarBoletas(string poliza)
        {
            var respuesta = _cliente.obtenerBoletasPoliza(poliza);

            if (respuesta.estado.Equals("ERROR"))
            {
                MessageBox.Show(respuesta.mensaje);

                return;
            }

            CargarDatosPoliza(poliza);

            respuestaListadoBoletasBindingSource.Clear();

            var boletasOrdenadas = 
                from boleta in respuesta.boletas
                orderby boleta.fechaPago
                select boleta;

            foreach (var boleta in boletasOrdenadas)
            {
                respuestaListadoBoletasBindingSource.Add(boleta);
            }
        }

        private void CargarDatosPoliza(string noPoliza)
        {
            var respuesta = _cliente.obtenerPoliza(noPoliza);

            if (respuesta.estado.Equals("ERROR")) return;

            var p = respuesta.poliza;
            LabelAsegurado.Text = "Asegurado: " + p.nombres + " " + p.apellidos;
            LabelEmision.Text = "Fecha Emision: " + p.fechaEmision;
            LabelVencimiento.Text = "Fecha Vencimiento: " + p.fechaVencimiento;
            LabelEstado.Text = "Estado: " + (p.activa == 1 ? "Activa" : "Inactiva");
        }

        private void pagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var boleta = (boleta) respuestaListadoBoletasBindingSource.Current;

            if (boleta.poliza.activa == 0)
            {
                MessageBox.Show("La poliza esta inactiva");
                return;
            }

            var respuesta = _cliente.pagarBoleta(boleta.poliza.noPoliza, boleta.mes, boleta.anio);

            if (respuesta.estado.Equals("ERROR"))
            {
                MessageBox.Show(respuesta.mensaje);
                return;
            }

            CargarBoletas(boleta.poliza.noPoliza);
        }

        private void FormularioBoletas_Shown(object sender, EventArgs e)
        {
            CargarBoletas(_noPoliza);
        }
    }
}
