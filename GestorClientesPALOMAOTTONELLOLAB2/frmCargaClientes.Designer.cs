namespace GestorClientesPALOMAOTTONELLOLAB2
{
    partial class frmCargaClientes
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
            this.grbCarga = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAutomovil = new System.Windows.Forms.Label();
            this.cmbAutomovil = new System.Windows.Forms.ComboBox();
            this.grbCarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCarga
            // 
            this.grbCarga.Controls.Add(this.cmbAutomovil);
            this.grbCarga.Controls.Add(this.btnCargar);
            this.grbCarga.Controls.Add(this.txtLimite);
            this.grbCarga.Controls.Add(this.txtNombre);
            this.grbCarga.Controls.Add(this.lblLimite);
            this.grbCarga.Controls.Add(this.lblNombre);
            this.grbCarga.Controls.Add(this.lblAutomovil);
            this.grbCarga.Location = new System.Drawing.Point(62, 37);
            this.grbCarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbCarga.Name = "grbCarga";
            this.grbCarga.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbCarga.Size = new System.Drawing.Size(911, 187);
            this.grbCarga.TabIndex = 0;
            this.grbCarga.TabStop = false;
            this.grbCarga.Text = "Carga de datos";
            this.grbCarga.Enter += new System.EventHandler(this.grbCarga_Enter);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(771, 136);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(112, 35);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(648, 55);
            this.txtLimite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(235, 26);
            this.txtLimite.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(182, 61);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(483, 66);
            this.lblLimite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(128, 20);
            this.lblLimite.TabIndex = 3;
            this.lblLimite.Text = "Lìmite de Crédito";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 61);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(136, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre y Apellido";
            // 
            // lblAutomovil
            // 
            this.lblAutomovil.AutoSize = true;
            this.lblAutomovil.Location = new System.Drawing.Point(27, 139);
            this.lblAutomovil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutomovil.Name = "lblAutomovil";
            this.lblAutomovil.Size = new System.Drawing.Size(82, 20);
            this.lblAutomovil.TabIndex = 1;
            this.lblAutomovil.Text = "Automovil:";
            // 
            // cmbAutomovil
            // 
            this.cmbAutomovil.Enabled = false;
            this.cmbAutomovil.FormattingEnabled = true;
            this.cmbAutomovil.Location = new System.Drawing.Point(140, 130);
            this.cmbAutomovil.Name = "cmbAutomovil";
            this.cmbAutomovil.Size = new System.Drawing.Size(277, 28);
            this.cmbAutomovil.TabIndex = 8;
            // 
            // frmCargaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 351);
            this.Controls.Add(this.grbCarga);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCargaClientes";
            this.Text = "frmCargaClientes";
            this.Load += new System.EventHandler(this.frmCargaClientes_Load);
            this.grbCarga.ResumeLayout(false);
            this.grbCarga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCarga;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAutomovil;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cmbAutomovil;
    }
}