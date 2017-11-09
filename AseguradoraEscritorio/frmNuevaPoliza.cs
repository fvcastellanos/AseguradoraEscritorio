﻿using System;
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
    public partial class frmNuevaPoliza : Form
    {
        public frmNuevaPoliza()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var respuesta = CrearPoliza();

            if (respuesta.estado.Equals("ERROR"))
            {
                MessageBox.Show(respuesta.mensaje);

                return;
            }

            Close();
        }

        private respuestaPoliza CrearPoliza()
        {
            var p = new poliza()
            {
                activa = 1,
                nombres = edNombres.Text,
                apellidos = edApellidos.Text,
                fechaEmision = edFechaEmision.Value,
                fechaEmisionSpecified = true,
                fechaNacimiento = edFechaNacimiento.Value,
                fechaNacimientoSpecified = true,
                fechaVencimiento = edFechaVencimiento.Value,
                fechaVencimientoSpecified = true,
                monto = double.Parse(edMonto.Text),
                noPagos = int.Parse(edNoPagos.Text),
                telefono = edTelefono.Text,
                noPoliza = edNoPoliza.Text
            };

            var cliente = new ServicioAseguradoraClient();

            return cliente.crearPoliza(p);
        }
    }
}
