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
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        ArchivoClientes x = new ArchivoClientes();

        private void frmClientesDeudores_Load(object sender, EventArgs e)
        {
            x.ListarDeudores(dgvDeudores);
            lblCantidadDeClientes.Text = x.CantidadDeudores.ToString();
            lblTOTAL.Text = "$" + x.TotalDeuda.ToString();
            lblPromedio.Text = x.PromDeuda.ToString("0.00");
        }

        private void lblTOTAL_Click(object sender, EventArgs e)
        {
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            x.ListarDeudores(dgvDeudores);
            lblCantidadDeClientes.Text = x.CantidadDeudores.ToString();
            lblTOTAL.Text = "$" + x.TotalDeuda.ToString();
            lblPromedio.Text = x.PromDeuda.ToString("0.00");
        }

        private void lblCantidadDeClientes_Click(object sender, EventArgs e)
        {
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ArchivoClientes objClientes = new ArchivoClientes();
            objClientes.GenerarReporte();
        }
    }
}
