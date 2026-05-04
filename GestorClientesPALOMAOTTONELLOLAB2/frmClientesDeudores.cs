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
              lblCantidadDeClientes.Text = Convert.ToString(x.CantidadClientes());
                lblTOTAL.Text = Convert.ToString(x.SumarDeuda());
                lblPromedio.Text = Convert.ToString(x.PromedioDeuda());
        }

        private void lblTOTAL_Click(object sender, EventArgs e)
        {

        }
    }
}
