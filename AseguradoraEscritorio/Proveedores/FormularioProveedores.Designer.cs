namespace AseguradoraEscritorio.Proveedores
{
    partial class FormularioProveedores
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
            this.TablaProveedores = new System.Windows.Forms.DataGridView();
            this.nitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CtxOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refrescarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respuestaListadoProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TablaProveedores)).BeginInit();
            this.CtxOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.respuestaListadoProveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaProveedores
            // 
            this.TablaProveedores.AllowUserToAddRows = false;
            this.TablaProveedores.AllowUserToDeleteRows = false;
            this.TablaProveedores.AutoGenerateColumns = false;
            this.TablaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nitDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.TablaProveedores.ContextMenuStrip = this.CtxOpciones;
            this.TablaProveedores.DataSource = this.respuestaListadoProveedoresBindingSource;
            this.TablaProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaProveedores.Location = new System.Drawing.Point(0, 0);
            this.TablaProveedores.Name = "TablaProveedores";
            this.TablaProveedores.ReadOnly = true;
            this.TablaProveedores.RowTemplate.Height = 24;
            this.TablaProveedores.Size = new System.Drawing.Size(765, 417);
            this.TablaProveedores.TabIndex = 0;
            // 
            // nitDataGridViewTextBoxColumn
            // 
            this.nitDataGridViewTextBoxColumn.DataPropertyName = "nit";
            this.nitDataGridViewTextBoxColumn.HeaderText = "Nit";
            this.nitDataGridViewTextBoxColumn.Name = "nitDataGridViewTextBoxColumn";
            this.nitDataGridViewTextBoxColumn.ReadOnly = true;
            this.nitDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre Proveedor";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 250;
            // 
            // CtxOpciones
            // 
            this.CtxOpciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CtxOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refrescarToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.CtxOpciones.Name = "CtxOpciones";
            this.CtxOpciones.Size = new System.Drawing.Size(176, 104);
            // 
            // refrescarToolStripMenuItem
            // 
            this.refrescarToolStripMenuItem.Name = "refrescarToolStripMenuItem";
            this.refrescarToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.refrescarToolStripMenuItem.Text = "Refrescar";
            this.refrescarToolStripMenuItem.Click += new System.EventHandler(this.refrescarToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // respuestaListadoProveedoresBindingSource
            // 
            this.respuestaListadoProveedoresBindingSource.DataMember = "proveedores";
            this.respuestaListadoProveedoresBindingSource.DataSource = typeof(AseguradoraEscritorio.ServicioWebAseguradora.respuestaListadoProveedores);
            // 
            // FormularioProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 417);
            this.Controls.Add(this.TablaProveedores);
            this.Name = "FormularioProveedores";
            this.Text = "Formulario Proveedores";
            this.Shown += new System.EventHandler(this.FormularioProveedores_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TablaProveedores)).EndInit();
            this.CtxOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.respuestaListadoProveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaProveedores;
        private System.Windows.Forms.BindingSource respuestaListadoProveedoresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip CtxOpciones;
        private System.Windows.Forms.ToolStripMenuItem refrescarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
    }
}