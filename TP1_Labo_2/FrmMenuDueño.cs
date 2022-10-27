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

        public FrmMenuDueño(Dueño dueño, Vendedor vendedor)
        {
            InitializeComponent();
            this.dueñoForm = dueño;
            this.vendedorForm = vendedor;
        }

        private void btnAdministradorInventario_Click(object sender, EventArgs e)
        {
            FrmAdministracionDeInventario frmAdministracionDeInventario = new FrmAdministracionDeInventario(dueñoForm);
            frmAdministracionDeInventario.ShowDialog();
        }

        private void btnAdministracionVenta_Click(object sender, EventArgs e)
        {
            FrmAdministracionDeVentas frmAdministracionDeVenta = new FrmAdministracionDeVentas(vendedorForm);
            frmAdministracionDeVenta.ShowDialog();
        }
    }
}
