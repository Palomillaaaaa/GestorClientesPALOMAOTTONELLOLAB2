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
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }
        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientes ven = new frmListadoClientes();
            ven.ShowDialog();
        }

        private void listadoDeClientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesDeudores ven = new frmClientesDeudores();
            ven.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaClientes ven = new frmBusquedaClientes();
            ven.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCargaClientes ven = new frmCargaClientes();
            ven.ShowDialog();
        }

        private void listadoOrdenadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoOrdenado ven = new frmListadoOrdenado();
            ven.ShowDialog();
        }

        private void limiteClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLimiteClientes ven = new frmLimiteClientes();
            ven.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
