using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Labo_2
{
    public partial class FrmMenuDueño : Form
    {
        private Dueño dueñoForm = new Dueño();
        private Vendedor vendedorForm = new Vendedor();
        private Cliente clienteForm = new Cliente();

        public FrmMenuDueño(Dueño dueño, Vendedor vendedor, Cliente clienteForm)
        {
            InitializeComponent();
            this.dueñoForm = dueño;
            this.vendedorForm = vendedor;
            this.clienteForm = clienteForm;
        }

        private void btnAdministradorInventario_Click(object sender, EventArgs e)
        {
            FrmAdministracionDeInventario frmAdministracionDeInventario = new FrmAdministracionDeInventario(dueñoForm);
            frmAdministracionDeInventario.ShowDialog();
        }

        private void btnAdministracionVenta_Click(object sender, EventArgs e)
        {
            FrmAdministracionDeVentas frmAdministracionDeVenta = new FrmAdministracionDeVentas(vendedorForm, clienteForm);
            frmAdministracionDeVenta.ShowDialog();
        }

        private void btnComprarProductos_Click(object sender, EventArgs e)
        {
            FrmCatalogoProveedor frmCatalogoProveedor = new FrmCatalogoProveedor(dueñoForm);
            frmCatalogoProveedor.ShowDialog();
        }
    }
}
