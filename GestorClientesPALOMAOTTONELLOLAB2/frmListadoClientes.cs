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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
            private void btnListar_Click(object sender, EventArgs e)
            {
                ArchivoClientes objClientes = new ArchivoClientes();
                objClientes.Listar(dgvConsulta);
            }

    }
}

