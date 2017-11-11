namespace AseguradoraEscritorio.Polizas
{
    partial class FormularioModificarPoliza
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.edMonto = new System.Windows.Forms.NumericUpDown();
            this.edNoPagos = new System.Windows.Forms.NumericUpDown();
            this.edFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.edFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.edFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbActivo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EtiquetaNoPoliza = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNoPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(137, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 36);
            this.btnCancelar.TabIndex = 130;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Location = new System.Drawing.Point(12, 403);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 36);
            this.btnGuardar.TabIndex = 129;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // edMonto
            // 
            this.edMonto.DecimalPlaces = 2;
            this.edMonto.Location = new System.Drawing.Point(115, 207);
            this.edMonto.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.edMonto.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edMonto.Name = "edMonto";
            this.edMonto.Size = new System.Drawing.Size(120, 22);
            this.edMonto.TabIndex = 125;
            this.edMonto.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // edNoPagos
            // 
            this.edNoPagos.Location = new System.Drawing.Point(115, 245);
            this.edNoPagos.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.edNoPagos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edNoPagos.Name = "edNoPagos";
            this.edNoPagos.Size = new System.Drawing.Size(120, 22);
            this.edNoPagos.TabIndex = 126;
            this.edNoPagos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edFechaEmision
            // 
            this.edFechaEmision.Location = new System.Drawing.Point(115, 284);
            this.edFechaEmision.Name = "edFechaEmision";
            this.edFechaEmision.Size = new System.Drawing.Size(251, 22);
            this.edFechaEmision.TabIndex = 127;
            // 
            // edFechaVencimiento
            // 
            this.edFechaVencimiento.Location = new System.Drawing.Point(115, 322);
            this.edFechaVencimiento.Name = "edFechaVencimiento";
            this.edFechaVencimiento.Size = new System.Drawing.Size(251, 22);
            this.edFechaVencimiento.TabIndex = 128;
            // 
            // edFechaNacimiento
            // 
            this.edFechaNacimiento.Location = new System.Drawing.Point(115, 171);
            this.edFechaNacimiento.Name = "edFechaNacimiento";
            this.edFechaNacimiento.Size = new System.Drawing.Size(251, 22);
            this.edFechaNacimiento.TabIndex = 124;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 120;
            this.label7.Text = "F. Vencimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 119;
            this.label8.Text = "F. Emision";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 118;
            this.label9.Text = "No. Pagos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 116;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 115;
            this.label5.Text = "F. Nacimiento";
            // 
            // edTelefono
            // 
            this.edTelefono.Location = new System.Drawing.Point(115, 131);
            this.edTelefono.Name = "edTelefono";
            this.edTelefono.Size = new System.Drawing.Size(251, 22);
            this.edTelefono.TabIndex = 123;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 114;
            this.label6.Text = "Telefono";
            // 
            // edApellidos
            // 
            this.edApellidos.Location = new System.Drawing.Point(115, 93);
            this.edApellidos.Name = "edApellidos";
            this.edApellidos.Size = new System.Drawing.Size(503, 22);
            this.edApellidos.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 113;
            this.label3.Text = "Apellidos";
            // 
            // edNombres
            // 
            this.edNombres.Location = new System.Drawing.Point(115, 55);
            this.edNombres.Name = "edNombres";
            this.edNombres.Size = new System.Drawing.Size(503, 22);
            this.edNombres.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 112;
            this.label2.Text = "Nombres";
            // 
            // cbActivo
            // 
            this.cbActivo.FormattingEnabled = true;
            this.cbActivo.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbActivo.Location = new System.Drawing.Point(115, 359);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(121, 24);
            this.cbActivo.TabIndex = 132;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 133;
            this.label10.Text = "Activo";
            // 
            // EtiquetaNoPoliza
            // 
            this.EtiquetaNoPoliza.AutoSize = true;
            this.EtiquetaNoPoliza.Location = new System.Drawing.Point(15, 21);
            this.EtiquetaNoPoliza.Name = "EtiquetaNoPoliza";
            this.EtiquetaNoPoliza.Size = new System.Drawing.Size(76, 17);
            this.EtiquetaNoPoliza.TabIndex = 134;
            this.EtiquetaNoPoliza.Text = "No. Poliza:";
            // 
            // FormularioModificarPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 466);
            this.Controls.Add(this.EtiquetaNoPoliza);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.edMonto);
            this.Controls.Add(this.edNoPagos);
            this.Controls.Add(this.edFechaEmision);
            this.Controls.Add(this.edFechaVencimiento);
            this.Controls.Add(this.edFechaNacimiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edApellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edNombres);
            this.Controls.Add(this.label2);
            this.Name = "FormularioModificarPoliza";
            this.Text = "FormularioModificarPoliza";
            this.Shown += new System.EventHandler(this.FormularioModificarPoliza_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.edMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNoPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown edMonto;
        private System.Windows.Forms.NumericUpDown edNoPagos;
        private System.Windows.Forms.DateTimePicker edFechaEmision;
        private System.Windows.Forms.DateTimePicker edFechaVencimiento;
        private System.Windows.Forms.DateTimePicker edFechaNacimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbActivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label EtiquetaNoPoliza;
    }
}