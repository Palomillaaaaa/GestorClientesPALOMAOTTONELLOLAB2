using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorClientesPALOMAOTTONELLOLAB2
{
    public partial class frmLimiteClientes : Form
    {
        public frmLimiteClientes()
        {
            InitializeComponent();
        }

        ArchivoClientes x = new ArchivoClientes();
        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void grbConsultadedatos_Enter(object sender, EventArgs e)
        {

        }

        private void frmLimiteClientes_Load(object sender, EventArgs e)
        {

            x.Listar(dgvClientes);
        }

        private void lblCantidadDeClientes_Click(object sender, EventArgs e)
        {

        }

        private void lblPromedioDeuda_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            x.GenerarReporte();
            MessageBox.Show("Reporte Generado Correctamente"); 
        }
    }
}
