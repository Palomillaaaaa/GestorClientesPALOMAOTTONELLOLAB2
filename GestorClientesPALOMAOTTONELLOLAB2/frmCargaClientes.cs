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
    public partial class frmCargaClientes : Form
    {
        public frmCargaClientes()
        {
            InitializeComponent();
        }

        ArchivoClientes x = new ArchivoClientes();
        private void grbCarga_Enter(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            x.Grabar (txtCodigo.Text,txtNombre.Text, txtDeuda.Text, txtLimite.Text);
            MessageBox.Show("Felicitaciones ha cargado un cliente!!!");

        }

        private void frmCargaClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
