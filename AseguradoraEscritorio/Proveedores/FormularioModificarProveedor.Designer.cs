namespace AseguradoraEscritorio.Proveedores
{
    partial class FormularioModificarProveedor
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
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.TextoNombre = new System.Windows.Forms.TextBox();
            this.TextoNit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BotonCancelar.Location = new System.Drawing.Point(138, 111);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(101, 34);
            this.BotonCancelar.TabIndex = 11;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BotonGuardar.Location = new System.Drawing.Point(19, 111);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(101, 34);
            this.BotonGuardar.TabIndex = 10;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            // 
            // TextoNombre
            // 
            this.TextoNombre.Location = new System.Drawing.Point(80, 65);
            this.TextoNombre.Name = "TextoNombre";
            this.TextoNombre.Size = new System.Drawing.Size(390, 22);
            this.TextoNombre.TabIndex = 9;
            // 
            // TextoNit
            // 
            this.TextoNit.Location = new System.Drawing.Point(80, 21);
            this.TextoNit.Name = "TextoNit";
            this.TextoNit.Size = new System.Drawing.Size(198, 22);
            this.TextoNit.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nit";
            // 
            // FormularioModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 171);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonGuardar);
            this.Controls.Add(this.TextoNombre);
            this.Controls.Add(this.TextoNit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioModificarProveedor";
            this.Text = "Modificar Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.TextBox TextoNombre;
        private System.Windows.Forms.TextBox TextoNit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}