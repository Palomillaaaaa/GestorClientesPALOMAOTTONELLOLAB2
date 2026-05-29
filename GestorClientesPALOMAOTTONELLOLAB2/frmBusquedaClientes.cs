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
    public partial class frmBusquedaClientes : Form
    {
        public frmBusquedaClientes()
        {
            InitializeComponent();
        }

        ArchivoClientes bsq = new ArchivoClientes();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArchivoClientes bsq = new ArchivoClientes();
            Int32 idClie = Convert.ToInt32(txtCodigo.Text);
            bsq.Buscar(idClie);
            if (bsq.idCliente != 0)
            {
                lblNombres.Text = bsq.Nombre;
                lblTotDeuda.Text = bsq.Deuda.ToString();
                lblLimiteCto.Text = bsq.Limite.ToString();
            }
            else
            {
                lblNombres.Text = "";
                lblTotDeuda.Text = "";
                lblLimiteCto.Text = "";
                MessageBox.Show("EL codigo del Cliente no existe", "Cliente inexistente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmBusquedaClientes_Load(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "") btnBuscar.Enabled = true;
            else btnBuscar.Enabled = false;

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números (char.IsDigit) y la tecla de borrar (char.IsControl)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otro caracter
            }
        }

        private void frmBusquedaClientes_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
