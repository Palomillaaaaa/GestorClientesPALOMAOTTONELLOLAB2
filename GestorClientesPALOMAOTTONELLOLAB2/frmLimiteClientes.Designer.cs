namespace GestorClientesPALOMAOTTONELLOLAB2
{
    partial class frmLimiteClientes
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
            this.grbConsultadedatos = new System.Windows.Forms.GroupBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCantidadDeClientes = new System.Windows.Forms.Label();
            this.lblTOTAL = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.dvgClientes = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbConsultadedatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grbConsultadedatos
            // 
            this.grbConsultadedatos.Controls.Add(this.btnReporte);
            this.grbConsultadedatos.Controls.Add(this.lblPromedio);
            this.grbConsultadedatos.Controls.Add(this.lblCantidadDeClientes);
            this.grbConsultadedatos.Controls.Add(this.lblTOTAL);
            this.grbConsultadedatos.Controls.Add(this.lblPromedioDeuda);
            this.grbConsultadedatos.Controls.Add(this.lblCantidad);
            this.grbConsultadedatos.Controls.Add(this.lblTotalDeuda);
            this.grbConsultadedatos.Controls.Add(this.dvgClientes);
            this.grbConsultadedatos.Location = new System.Drawing.Point(30, 31);
            this.grbConsultadedatos.Name = "grbConsultadedatos";
            this.grbConsultadedatos.Size = new System.Drawing.Size(516, 359);
            this.grbConsultadedatos.TabIndex = 0;
            this.grbConsultadedatos.TabStop = false;
            this.grbConsultadedatos.Text = "Consulta de datos";
            this.grbConsultadedatos.Enter += new System.EventHandler(this.grbConsultadedatos_Enter);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(26, 277);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(100, 32);
            this.btnReporte.TabIndex = 16;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPromedio.Location = new System.Drawing.Point(317, 308);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(130, 31);
            this.lblPromedio.TabIndex = 15;
            this.lblPromedio.UseWaitCursor = true;
            // 
            // lblCantidadDeClientes
            // 
            this.lblCantidadDeClientes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCantidadDeClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadDeClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCantidadDeClientes.Location = new System.Drawing.Point(317, 266);
            this.lblCantidadDeClientes.Name = "lblCantidadDeClientes";
            this.lblCantidadDeClientes.Size = new System.Drawing.Size(130, 32);
            this.lblCantidadDeClientes.TabIndex = 14;
            this.lblCantidadDeClientes.UseWaitCursor = true;
            this.lblCantidadDeClientes.Click += new System.EventHandler(this.lblCantidadDeClientes_Click);
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTOTAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTOTAL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTOTAL.Location = new System.Drawing.Point(317, 229);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(130, 30);
            this.lblTOTAL.TabIndex = 13;
            this.lblTOTAL.UseWaitCursor = true;
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(154, 326);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(153, 13);
            this.lblPromedioDeuda.TabIndex = 12;
            this.lblPromedioDeuda.Text = "El promedio de la deuda es de ";
            this.lblPromedioDeuda.Click += new System.EventHandler(this.lblPromedioDeuda_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(158, 285);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(149, 13);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "La cantidad de clientes es de ";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Location = new System.Drawing.Point(177, 246);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(130, 13);
            this.lblTotalDeuda.TabIndex = 8;
            this.lblTotalDeuda.Text = "El total de la deuda es de ";
            this.lblTotalDeuda.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // dvgClientes
            // 
            this.dvgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Deuda,
            this.Limite});
            this.dvgClientes.Location = new System.Drawing.Point(17, 20);
            this.dvgClientes.Name = "dvgClientes";
            this.dvgClientes.Size = new System.Drawing.Size(446, 190);
            this.dvgClientes.TabIndex = 0;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre y Apellido";
            this.Nombre.Name = "Nombre";
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            // 
            // Limite
            // 
            this.Limite.HeaderText = "Limite de Crédito";
            this.Limite.Name = "Limite";
            // 
            // frmLimiteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbConsultadedatos);
            this.Name = "frmLimiteClientes";
            this.Text = "frmLimiteClientes";
            this.Load += new System.EventHandler(this.frmLimiteClientes_Load);
            this.grbConsultadedatos.ResumeLayout(false);
            this.grbConsultadedatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbConsultadedatos;
        private System.Windows.Forms.DataGridView dvgClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblCantidadDeClientes;
        private System.Windows.Forms.Label lblTOTAL;
        private System.Windows.Forms.Button btnReporte;
    }
}