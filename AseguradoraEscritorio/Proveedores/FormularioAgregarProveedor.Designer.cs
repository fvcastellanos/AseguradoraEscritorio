namespace AseguradoraEscritorio.Proveedores
{
    partial class FormularioAgregarProveedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextoNit = new System.Windows.Forms.TextBox();
            this.TextoNombre = new System.Windows.Forms.TextBox();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // TextoNit
            // 
            this.TextoNit.Location = new System.Drawing.Point(90, 27);
            this.TextoNit.Name = "TextoNit";
            this.TextoNit.Size = new System.Drawing.Size(198, 22);
            this.TextoNit.TabIndex = 2;
            // 
            // TextoNombre
            // 
            this.TextoNombre.Location = new System.Drawing.Point(90, 71);
            this.TextoNombre.Name = "TextoNombre";
            this.TextoNombre.Size = new System.Drawing.Size(390, 22);
            this.TextoNombre.TabIndex = 3;
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BotonGuardar.Location = new System.Drawing.Point(29, 117);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(101, 34);
            this.BotonGuardar.TabIndex = 4;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BotonCancelar.Location = new System.Drawing.Point(148, 117);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(101, 34);
            this.BotonCancelar.TabIndex = 5;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // FormularioAgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 226);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonGuardar);
            this.Controls.Add(this.TextoNombre);
            this.Controls.Add(this.TextoNit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioAgregarProveedor";
            this.Text = "Agregar Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextoNit;
        private System.Windows.Forms.TextBox TextoNombre;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.Button BotonCancelar;
    }
}