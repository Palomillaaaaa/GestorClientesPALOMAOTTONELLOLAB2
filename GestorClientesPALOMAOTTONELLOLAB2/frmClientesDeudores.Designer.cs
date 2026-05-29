namespace GestorClientesPALOMAOTTONELLOLAB2
{
    partial class frmClientesDeudores
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
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCantidadDeClientes = new System.Windows.Forms.Label();
            this.lblTOTAL = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.dgvDeudores = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.grbConsultadedatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // grbConsultadedatos
            // 
            this.grbConsultadedatos.Controls.Add(this.btnReporte);
            this.grbConsultadedatos.Controls.Add(this.btnListar);
            this.grbConsultadedatos.Controls.Add(this.lblPromedio);
            this.grbConsultadedatos.Controls.Add(this.lblCantidadDeClientes);
            this.grbConsultadedatos.Controls.Add(this.lblTOTAL);
            this.grbConsultadedatos.Controls.Add(this.lblPromedioDeuda);
            this.grbConsultadedatos.Controls.Add(this.lblCantidad);
            this.grbConsultadedatos.Controls.Add(this.lblTotalDeuda);
            this.grbConsultadedatos.Controls.Add(this.dgvDeudores);
            this.grbConsultadedatos.Location = new System.Drawing.Point(213, 71);
            this.grbConsultadedatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbConsultadedatos.Name = "grbConsultadedatos";
            this.grbConsultadedatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbConsultadedatos.Size = new System.Drawing.Size(774, 870);
            this.grbConsultadedatos.TabIndex = 1;
            this.grbConsultadedatos.TabStop = false;
            this.grbConsultadedatos.Text = "Consulta de datos";
            // 
            // lblPromedio
            // 
            this.lblPromedio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPromedio.Location = new System.Drawing.Point(500, 732);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(195, 48);
            this.lblPromedio.TabIndex = 15;
            this.lblPromedio.UseWaitCursor = true;
            // 
            // lblCantidadDeClientes
            // 
            this.lblCantidadDeClientes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCantidadDeClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadDeClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCantidadDeClientes.Location = new System.Drawing.Point(500, 668);
            this.lblCantidadDeClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadDeClientes.Name = "lblCantidadDeClientes";
            this.lblCantidadDeClientes.Size = new System.Drawing.Size(195, 49);
            this.lblCantidadDeClientes.TabIndex = 14;
            this.lblCantidadDeClientes.UseWaitCursor = true;
            this.lblCantidadDeClientes.Click += new System.EventHandler(this.lblCantidadDeClientes_Click);
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTOTAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTOTAL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTOTAL.Location = new System.Drawing.Point(500, 611);
            this.lblTOTAL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(195, 46);
            this.lblTOTAL.TabIndex = 13;
            this.lblTOTAL.UseWaitCursor = true;
            this.lblTOTAL.Click += new System.EventHandler(this.lblTOTAL_Click);
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(255, 760);
            this.lblPromedioDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(227, 20);
            this.lblPromedioDeuda.TabIndex = 12;
            this.lblPromedioDeuda.Text = "El promedio de la deuda es de ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(261, 697);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(219, 20);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "La cantidad de clientes es de ";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Location = new System.Drawing.Point(290, 637);
            this.lblTotalDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(192, 20);
            this.lblTotalDeuda.TabIndex = 8;
            this.lblTotalDeuda.Text = "El total de la deuda es de ";
            // 
            // dgvDeudores
            // 
            this.dgvDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Deuda,
            this.Limite});
            this.dgvDeudores.Location = new System.Drawing.Point(26, 31);
            this.dgvDeudores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDeudores.Name = "dgvDeudores";
            this.dgvDeudores.RowHeadersWidth = 62;
            this.dgvDeudores.Size = new System.Drawing.Size(669, 537);
            this.dgvDeudores.TabIndex = 0;
            this.dgvDeudores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 8;
            this.Código.Name = "Código";
            this.Código.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre y Apellido";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.MinimumWidth = 8;
            this.Deuda.Name = "Deuda";
            this.Deuda.Width = 150;
            // 
            // Limite
            // 
            this.Limite.HeaderText = "Limite de Crédito";
            this.Limite.MinimumWidth = 8;
            this.Limite.Name = "Limite";
            this.Limite.Width = 150;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(548, 803);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(150, 49);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar deudores";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(364, 803);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(150, 49);
            this.btnReporte.TabIndex = 17;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // frmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1050);
            this.Controls.Add(this.grbConsultadedatos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClientesDeudores";
            this.Text = "frmClientesDeudores";
            this.Load += new System.EventHandler(this.frmClientesDeudores_Load);
            this.grbConsultadedatos.ResumeLayout(false);
            this.grbConsultadedatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbConsultadedatos;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblCantidadDeClientes;
        private System.Windows.Forms.Label lblTOTAL;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.DataGridView dgvDeudores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnReporte;
    }
}