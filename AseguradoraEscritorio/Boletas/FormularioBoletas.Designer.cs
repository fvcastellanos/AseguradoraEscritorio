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
            this.LabelEstado = new System.Windows.Forms.Label();
            this.LabelVencimiento = new System.Windows.Forms.Label();
            this.LabelEmision = new System.Windows.Forms.Label();
            this.LabelAsegurado = new System.Windows.Forms.Label();
            this.TablaBoletas = new System.Windows.Forms.DataGridView();
            this.mesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CtxPago = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respuestaListadoBoletasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaBoletas)).BeginInit();
            this.CtxPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaListadoBoletasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelEstado);
            this.panel1.Controls.Add(this.LabelVencimiento);
            this.panel1.Controls.Add(this.LabelEmision);
            this.panel1.Controls.Add(this.LabelAsegurado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 96);
            this.panel1.TabIndex = 0;
            // 
            // LabelEstado
            // 
            this.LabelEstado.AutoSize = true;
            this.LabelEstado.Location = new System.Drawing.Point(477, 9);
            this.LabelEstado.Name = "LabelEstado";
            this.LabelEstado.Size = new System.Drawing.Size(56, 17);
            this.LabelEstado.TabIndex = 6;
            this.LabelEstado.Text = "Estado:";
            // 
            // LabelVencimiento
            // 
            this.LabelVencimiento.AutoSize = true;
            this.LabelVencimiento.Location = new System.Drawing.Point(290, 46);
            this.LabelVencimiento.Name = "LabelVencimiento";
            this.LabelVencimiento.Size = new System.Drawing.Size(132, 17);
            this.LabelVencimiento.TabIndex = 5;
            this.LabelVencimiento.Text = "Fecha Vencimiento:";
            // 
            // LabelEmision
            // 
            this.LabelEmision.AutoSize = true;
            this.LabelEmision.Location = new System.Drawing.Point(12, 46);
            this.LabelEmision.Name = "LabelEmision";
            this.LabelEmision.Size = new System.Drawing.Size(104, 17);
            this.LabelEmision.TabIndex = 4;
            this.LabelEmision.Text = "Fecha Emision:";
            // 
            // LabelAsegurado
            // 
            this.LabelAsegurado.AutoSize = true;
            this.LabelAsegurado.Location = new System.Drawing.Point(12, 9);
            this.LabelAsegurado.Name = "LabelAsegurado";
            this.LabelAsegurado.Size = new System.Drawing.Size(81, 17);
            this.LabelAsegurado.TabIndex = 3;
            this.LabelAsegurado.Text = "Asegurado:";
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
            this.TablaBoletas.Location = new System.Drawing.Point(0, 96);
            this.TablaBoletas.Name = "TablaBoletas";
            this.TablaBoletas.ReadOnly = true;
            this.TablaBoletas.RowTemplate.Height = 24;
            this.TablaBoletas.Size = new System.Drawing.Size(766, 283);
            this.TablaBoletas.TabIndex = 1;
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
            // respuestaListadoBoletasBindingSource
            // 
            this.respuestaListadoBoletasBindingSource.AllowNew = false;
            this.respuestaListadoBoletasBindingSource.DataMember = "boletas";
            this.respuestaListadoBoletasBindingSource.DataSource = typeof(AseguradoraEscritorio.ServicioWebAseguradora.respuestaListadoBoletas);
            this.respuestaListadoBoletasBindingSource.Sort = "fechaPago asc";
            // 
            // FormularioBoletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 379);
            this.Controls.Add(this.TablaBoletas);
            this.Controls.Add(this.panel1);
            this.Name = "FormularioBoletas";
            this.Text = "Formulario Boletas";
            this.Shown += new System.EventHandler(this.FormularioBoletas_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaBoletas)).EndInit();
            this.CtxPago.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.respuestaListadoBoletasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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