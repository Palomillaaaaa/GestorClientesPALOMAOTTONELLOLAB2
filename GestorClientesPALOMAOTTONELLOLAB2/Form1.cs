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

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarNuevosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmCargaClientes();
            formulario.MdiParent = this;    
            formulario.Show();    
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmLimiteClientes();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
