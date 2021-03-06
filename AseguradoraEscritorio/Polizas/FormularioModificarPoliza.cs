﻿using System;
using System.Windows.Forms;
using AseguradoraEscritorio.ServicioWebAseguradora;

namespace AseguradoraEscritorio.Polizas
{
    public partial class FormularioModificarPoliza : Form
    {
        private poliza _poliza;
        private readonly string _noPoliza;
        private readonly ServicioAseguradoraClient _cliente = new ServicioAseguradoraClient();


        public FormularioModificarPoliza()
        {
            InitializeComponent();
        }

        public FormularioModificarPoliza(string noPoliza)
        {
            InitializeComponent();
            _noPoliza = noPoliza;
        }

        private void CargarPoliza(poliza poliza)
        {
            EtiquetaNoPoliza.Text = "No. Poliza -> " + poliza.noPoliza;
            edNombres.Text = poliza.nombres;
            edApellidos.Text = poliza.apellidos;
            edTelefono.Text = poliza.telefono;
            edFechaNacimiento.Value = poliza.fechaNacimiento;
            edFechaEmision.Value = poliza.fechaEmision;
            edFechaVencimiento.Value = poliza.fechaVencimiento;
            edNoPagos.Text = poliza.noPagos.ToString();
            edMonto.Text = poliza.monto.ToString();
            cbActivo.Text = poliza.activa == 1 ? "S" : "N";

            _poliza = poliza;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var respuesta = ModificarPoliza();

            if (respuesta.estado.Equals("ERROR"))
            {
                MessageBox.Show(respuesta.mensaje);

                return;
            }

            Close();
        }

        private respuestaPoliza ModificarPoliza()
        {
            _poliza.nombres = edNombres.Text;
            _poliza.apellidos = edApellidos.Text;
            _poliza.telefono = edTelefono.Text;
            _poliza.fechaNacimiento = edFechaNacimiento.Value;
            _poliza.fechaNacimientoSpecified = true;
            _poliza.fechaEmision = edFechaEmision.Value;
            _poliza.fechaEmisionSpecified = true;
            _poliza.fechaVencimiento = edFechaVencimiento.Value;
            _poliza.fechaVencimientoSpecified = true;
            _poliza.noPagos = int.Parse(edNoPagos.Text);
            _poliza.monto = double.Parse(edMonto.Text);
            _poliza.activa = cbActivo.Text.Equals("S") ? 1 : 0;

            return _cliente.actualizarPoliza(_poliza);
        }

        private void FormularioModificarPoliza_Shown(object sender, EventArgs e)
        {
            var respuesta = _cliente.obtenerPoliza(_noPoliza);

            if (respuesta.estado.Equals("ERROR"))
            {
                MessageBox.Show(respuesta.mensaje);

                return;
            }

            CargarPoliza(respuesta.poliza);

        }
    }
}
