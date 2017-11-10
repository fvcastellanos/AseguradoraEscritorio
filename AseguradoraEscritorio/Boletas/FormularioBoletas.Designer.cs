namespace AseguradoraEscritorio.Boletas
{
    partial class FormularioBoletas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NoPolizaTexto = new System.Windows.Forms.TextBox();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.TablaBoletas = new System.Windows.Forms.DataGridView();
            this.respuestaListadoBoletasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CtxPago = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelAsegurado = new System.Windows.Forms.Label();
            this.LabelEmision = new System.Windows.Forms.Label();
            this.LabelVencimiento = new System.Windows.Forms.Label();
            this.LabelEstado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaBoletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaListadoBoletasBindingSource)).BeginInit();
            this.CtxPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelEstado);
            this.panel1.Controls.Add(this.LabelVencimiento);
            this.panel1.Controls.Add(this.LabelEmision);
            this.panel1.Controls.Add(this.LabelAsegurado);
            this.panel1.Controls.Add(this.BotonBuscar);
            this.panel1.Controls.Add(this.NoPolizaTexto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 144);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Poliza:";
            // 
            // NoPolizaTexto
            // 
            this.NoPolizaTexto.Location = new System.Drawing.Point(94, 26);
            this.NoPolizaTexto.Name = "NoPolizaTexto";
            this.NoPolizaTexto.Size = new System.Drawing.Size(242, 22);
            this.NoPolizaTexto.TabIndex = 1;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(357, 22);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(132, 30);
            this.BotonBuscar.TabIndex = 2;
            this.BotonBuscar.Text = "Buscar Boletas";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // TablaBoletas
            // 
            this.TablaBoletas.AllowUserToAddRows = false;
            this.TablaBoletas.AllowUserToDeleteRows = false;
            this.TablaBoletas.AutoGenerateColumns = false;
            this.TablaBoletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaBoletas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mesDataGridViewTextBoxColumn,
            this.anioDataGridViewTextBoxColumn,
            this.fechaPagoDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.pagadaDataGridViewTextBoxColumn});
            this.TablaBoletas.ContextMenuStrip = this.CtxPago;
            this.TablaBoletas.DataSource = this.respuestaListadoBoletasBindingSource;
            this.TablaBoletas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaBoletas.Location = new System.Drawing.Point(0, 144);
            this.TablaBoletas.Name = "TablaBoletas";
            this.TablaBoletas.ReadOnly = true;
            this.TablaBoletas.RowTemplate.Height = 24;
            this.TablaBoletas.Size = new System.Drawing.Size(867, 368);
            this.TablaBoletas.TabIndex = 1;
            // 
            // respuestaListadoBoletasBindingSource
            // 
            this.respuestaListadoBoletasBindingSource.AllowNew = false;
            this.respuestaListadoBoletasBindingSource.DataMember = "boletas";
            this.respuestaListadoBoletasBindingSource.DataSource = typeof(AseguradoraEscritorio.ServicioWebAseguradora.respuestaListadoBoletas);
            this.respuestaListadoBoletasBindingSource.Sort = "fechaPago asc";
            // 
            // mesDataGridViewTextBoxColumn
            // 
            this.mesDataGridViewTextBoxColumn.DataPropertyName = "mes";
            this.mesDataGridViewTextBoxColumn.HeaderText = "Mes";
            this.mesDataGridViewTextBoxColumn.Name = "mesDataGridViewTextBoxColumn";
            this.mesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anioDataGridViewTextBoxColumn
            // 
            this.anioDataGridViewTextBoxColumn.DataPropertyName = "anio";
            this.anioDataGridViewTextBoxColumn.HeaderText = "Año";
            this.anioDataGridViewTextBoxColumn.Name = "anioDataGridViewTextBoxColumn";
            this.anioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPagoDataGridViewTextBoxColumn
            // 
            this.fechaPagoDataGridViewTextBoxColumn.DataPropertyName = "fechaPago";
            this.fechaPagoDataGridViewTextBoxColumn.HeaderText = "Fecha Pago";
            this.fechaPagoDataGridViewTextBoxColumn.Name = "fechaPagoDataGridViewTextBoxColumn";
            this.fechaPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaPagoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fechaPagoDataGridViewTextBoxColumn.Width = 150;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 230;
            // 
            // pagadaDataGridViewTextBoxColumn
            // 
            this.pagadaDataGridViewTextBoxColumn.DataPropertyName = "pagada";
            this.pagadaDataGridViewTextBoxColumn.HeaderText = "Pagada";
            this.pagadaDataGridViewTextBoxColumn.Name = "pagadaDataGridViewTextBoxColumn";
            this.pagadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CtxPago
            // 
            this.CtxPago.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CtxPago.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagarToolStripMenuItem});
            this.CtxPago.Name = "CtxPago";
            this.CtxPago.Size = new System.Drawing.Size(116, 28);
            // 
            // pagarToolStripMenuItem
            // 
            this.pagarToolStripMenuItem.Name = "pagarToolStripMenuItem";
            this.pagarToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.pagarToolStripMenuItem.Text = "Pagar";
            this.pagarToolStripMenuItem.Click += new System.EventHandler(this.pagarToolStripMenuItem_Click);
            // 
            // LabelAsegurado
            // 
            this.LabelAsegurado.AutoSize = true;
            this.LabelAsegurado.Location = new System.Drawing.Point(12, 65);
            this.LabelAsegurado.Name = "LabelAsegurado";
            this.LabelAsegurado.Size = new System.Drawing.Size(81, 17);
            this.LabelAsegurado.TabIndex = 3;
            this.LabelAsegurado.Text = "Asegurado:";
            // 
            // LabelEmision
            // 
            this.LabelEmision.AutoSize = true;
            this.LabelEmision.Location = new System.Drawing.Point(12, 102);
            this.LabelEmision.Name = "LabelEmision";
            this.LabelEmision.Size = new System.Drawing.Size(104, 17);
            this.LabelEmision.TabIndex = 4;
            this.LabelEmision.Text = "Fecha Emision:";
            // 
            // LabelVencimiento
            // 
            this.LabelVencimiento.AutoSize = true;
            this.LabelVencimiento.Location = new System.Drawing.Point(290, 102);
            this.LabelVencimiento.Name = "LabelVencimiento";
            this.LabelVencimiento.Size = new System.Drawing.Size(132, 17);
            this.LabelVencimiento.TabIndex = 5;
            this.LabelVencimiento.Text = "Fecha Vencimiento:";
            // 
            // LabelEstado
            // 
            this.LabelEstado.AutoSize = true;
            this.LabelEstado.Location = new System.Drawing.Point(477, 65);
            this.LabelEstado.Name = "LabelEstado";
            this.LabelEstado.Size = new System.Drawing.Size(56, 17);
            this.LabelEstado.TabIndex = 6;
            this.LabelEstado.Text = "Estado:";
            // 
            // FormularioBoletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 512);
            this.Controls.Add(this.TablaBoletas);
            this.Controls.Add(this.panel1);
            this.Name = "FormularioBoletas";
            this.Text = "Formulario Boletas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaBoletas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaListadoBoletasBindingSource)).EndInit();
            this.CtxPago.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NoPolizaTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.DataGridView TablaBoletas;
        private System.Windows.Forms.BindingSource respuestaListadoBoletasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip CtxPago;
        private System.Windows.Forms.ToolStripMenuItem pagarToolStripMenuItem;
        private System.Windows.Forms.Label LabelEstado;
        private System.Windows.Forms.Label LabelVencimiento;
        private System.Windows.Forms.Label LabelEmision;
        private System.Windows.Forms.Label LabelAsegurado;
    }
}