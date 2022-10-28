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
        private Dueño dueñoForm;
        private Vendedor vendedorForm;
        private Contador contadorForm;
        private List<Proveedor> listaProveedoresForm;

        public FrmMenuDueño(Dueño dueño, Vendedor vendedor, Contador contador, List<Proveedor> listaProveedores)
        {
            InitializeComponent();
            this.dueñoForm = dueño;
            this.vendedorForm = vendedor;
            this.contadorForm = contador;
            this.listaProveedoresForm = listaProveedores;
        }

        private void btnAdministradorInventario_Click(object sender, EventArgs e)
        {
            FrmAdministracionDeInventario frmAdministracionDeInventario = new FrmAdministracionDeInventario(dueñoForm);
            frmAdministracionDeInventario.ShowDialog();
        }

        private void btnAdministracionVenta_Click(object sender, EventArgs e)
        {
            FrmAdministracionDeVentas frmAdministracionDeVenta = new FrmAdministracionDeVentas(vendedorForm, contadorForm);
            frmAdministracionDeVenta.ShowDialog();
        }

        private void btnComprarProductos_Click(object sender, EventArgs e)
        {
            FrmCatalogoProveedor frmCatalogoProveedor = new FrmCatalogoProveedor(dueñoForm, listaProveedoresForm);
            frmCatalogoProveedor.ShowDialog();
        }
    }
}
