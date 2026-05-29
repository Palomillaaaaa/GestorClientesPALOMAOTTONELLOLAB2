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
    public partial class frmListadoOrdenado : Form
    {
        public frmListadoOrdenado()
        {
            InitializeComponent();
        }

        private void frmListadoOrdenado_Load(object sender, EventArgs e)
        {
            cmbCampo.Items.Add("IdCliente");
            cmbCampo.Items.Add("Nombre");
            cmbCampo.Items.Add("Deuda");
            cmbCampo.Items.Add("Limite Crédito");

            cmbModo.Items.Add("Ascendente");
            cmbModo.Items.Add("Descendente");
        }
        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
