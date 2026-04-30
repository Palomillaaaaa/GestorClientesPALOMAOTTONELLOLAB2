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
            this.dvgDeudores = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbConsultadedatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // grbConsultadedatos
            // 
            this.grbConsultadedatos.Controls.Add(this.lblPromedio);
            this.grbConsultadedatos.Controls.Add(this.lblCantidadDeClientes);
            this.grbConsultadedatos.Controls.Add(this.lblTOTAL);
            this.grbConsultadedatos.Controls.Add(this.lblPromedioDeuda);
            this.grbConsultadedatos.Controls.Add(this.lblCantidad);
            this.grbConsultadedatos.Controls.Add(this.lblTotalDeuda);
            this.grbConsultadedatos.Controls.Add(this.dvgDeudores);
            this.grbConsultadedatos.Location = new System.Drawing.Point(142, 46);
            this.grbConsultadedatos.Name = "grbConsultadedatos";
            this.grbConsultadedatos.Size = new System.Drawing.Size(516, 533);
            this.grbConsultadedatos.TabIndex = 1;
            this.grbConsultadedatos.TabStop = false;
            this.grbConsultadedatos.Text = "Consulta de datos";
            // 
            // lblPromedio
            // 
            this.lblPromedio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPromedio.Location = new System.Drawing.Point(333, 476);
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
            this.lblCantidadDeClientes.Location = new System.Drawing.Point(333, 434);
            this.lblCantidadDeClientes.Name = "lblCantidadDeClientes";
            this.lblCantidadDeClientes.Size = new System.Drawing.Size(130, 32);
            this.lblCantidadDeClientes.TabIndex = 14;
            this.lblCantidadDeClientes.UseWaitCursor = true;
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTOTAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTOTAL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTOTAL.Location = new System.Drawing.Point(333, 397);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(130, 30);
            this.lblTOTAL.TabIndex = 13;
            this.lblTOTAL.UseWaitCursor = true;
            this.lblTOTAL.Click += new System.EventHandler(this.lblTOTAL_Click);
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(170, 494);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(153, 13);
            this.lblPromedioDeuda.TabIndex = 12;
            this.lblPromedioDeuda.Text = "El promedio de la deuda es de ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(174, 453);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(149, 13);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "La cantidad de clientes es de ";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Location = new System.Drawing.Point(193, 414);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(130, 13);
            this.lblTotalDeuda.TabIndex = 8;
            this.lblTotalDeuda.Text = "El total de la deuda es de ";
            // 
            // dvgDeudores
            // 
            this.dvgDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Deuda,
            this.Limite});
            this.dvgDeudores.Location = new System.Drawing.Point(17, 20);
            this.dvgDeudores.Name = "dvgDeudores";
            this.dvgDeudores.Size = new System.Drawing.Size(446, 349);
            this.dvgDeudores.TabIndex = 0;
            this.dvgDeudores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
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
            // frmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 826);
            this.Controls.Add(this.grbConsultadedatos);
            this.Name = "frmClientesDeudores";
            this.Text = "frmClientesDeudores";
            this.Load += new System.EventHandler(this.frmClientesDeudores_Load);
            this.grbConsultadedatos.ResumeLayout(false);
            this.grbConsultadedatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDeudores)).EndInit();
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
        private System.Windows.Forms.DataGridView dvgDeudores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
    }
}