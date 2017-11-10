namespace AseguradoraEscritorio
{
    partial class FormularioPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.polizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polizasToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.boletasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(743, 28);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuPrincipal";
            // 
            // polizasToolStripMenuItem
            // 
            this.polizasToolStripMenuItem.Name = "polizasToolStripMenuItem";
            this.polizasToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.polizasToolStripMenuItem.Text = "Polizas";
            this.polizasToolStripMenuItem.Click += new System.EventHandler(this.polizasToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // boletasToolStripMenuItem
            // 
            this.boletasToolStripMenuItem.Name = "boletasToolStripMenuItem";
            this.boletasToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.boletasToolStripMenuItem.Text = "Boletas";
            this.boletasToolStripMenuItem.Click += new System.EventHandler(this.boletasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 440);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FormularioPrincipal";
            this.Text = "Principal";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem polizasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

