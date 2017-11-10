namespace AseguradoraEscritorio.Polizas
{
    partial class FormularioPolizas
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
            this.dgPolizas = new System.Windows.Forms.DataGridView();
            this.noPolizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPagosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxPolizas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refrescarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgPolizas)).BeginInit();
            this.ctxPolizas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polizasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPolizas
            // 
            this.dgPolizas.AllowUserToAddRows = false;
            this.dgPolizas.AllowUserToDeleteRows = false;
            this.dgPolizas.AutoGenerateColumns = false;
            this.dgPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPolizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noPolizaDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.fechaEmisionDataGridViewTextBoxColumn,
            this.fechaVencimientoDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.noPagosDataGridViewTextBoxColumn,
            this.activaDataGridViewTextBoxColumn});
            this.dgPolizas.ContextMenuStrip = this.ctxPolizas;
            this.dgPolizas.DataSource = this.polizasBindingSource;
            this.dgPolizas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPolizas.Location = new System.Drawing.Point(0, 0);
            this.dgPolizas.MultiSelect = false;
            this.dgPolizas.Name = "dgPolizas";
            this.dgPolizas.ReadOnly = true;
            this.dgPolizas.RowTemplate.Height = 24;
            this.dgPolizas.Size = new System.Drawing.Size(683, 387);
            this.dgPolizas.TabIndex = 0;
            // 
            // noPolizaDataGridViewTextBoxColumn
            // 
            this.noPolizaDataGridViewTextBoxColumn.DataPropertyName = "noPoliza";
            this.noPolizaDataGridViewTextBoxColumn.HeaderText = "No. Poliza";
            this.noPolizaDataGridViewTextBoxColumn.Name = "noPolizaDataGridViewTextBoxColumn";
            this.noPolizaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEmisionDataGridViewTextBoxColumn
            // 
            this.fechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "fechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.HeaderText = "Emision";
            this.fechaEmisionDataGridViewTextBoxColumn.Name = "fechaEmisionDataGridViewTextBoxColumn";
            this.fechaEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaVencimientoDataGridViewTextBoxColumn
            // 
            this.fechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaVencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.HeaderText = "Vencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.Name = "fechaVencimientoDataGridViewTextBoxColumn";
            this.fechaVencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noPagosDataGridViewTextBoxColumn
            // 
            this.noPagosDataGridViewTextBoxColumn.DataPropertyName = "noPagos";
            this.noPagosDataGridViewTextBoxColumn.HeaderText = "Pagos";
            this.noPagosDataGridViewTextBoxColumn.Name = "noPagosDataGridViewTextBoxColumn";
            this.noPagosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activaDataGridViewTextBoxColumn
            // 
            this.activaDataGridViewTextBoxColumn.DataPropertyName = "activa";
            this.activaDataGridViewTextBoxColumn.HeaderText = "Activa";
            this.activaDataGridViewTextBoxColumn.Name = "activaDataGridViewTextBoxColumn";
            this.activaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ctxPolizas
            // 
            this.ctxPolizas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxPolizas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refrescarToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.ctxPolizas.Name = "ctxPolizas";
            this.ctxPolizas.Size = new System.Drawing.Size(143, 76);
            // 
            // refrescarToolStripMenuItem
            // 
            this.refrescarToolStripMenuItem.Name = "refrescarToolStripMenuItem";
            this.refrescarToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.refrescarToolStripMenuItem.Text = "Refrescar";
            this.refrescarToolStripMenuItem.Click += new System.EventHandler(this.refrescarToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // polizasBindingSource
            // 
            this.polizasBindingSource.DataMember = "polizas";
            this.polizasBindingSource.DataSource = typeof(AseguradoraEscritorio.ServicioWebAseguradora.respuestaListadoPolizas);
            // 
            // FormularioPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 387);
            this.Controls.Add(this.dgPolizas);
            this.Name = "FormularioPolizas";
            this.Text = "Listado Polizas";
            this.Shown += new System.EventHandler(this.frmPolizas_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgPolizas)).EndInit();
            this.ctxPolizas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.polizasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgPolizas;
        private System.Windows.Forms.BindingSource polizasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPolizaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPagosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip ctxPolizas;
        private System.Windows.Forms.ToolStripMenuItem refrescarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
    }
}