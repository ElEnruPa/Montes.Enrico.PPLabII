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
    public partial class FrmMostradorVentas : Form
    {
        private Vendedor vendedorForm = new Vendedor();

        public FrmMostradorVentas(Vendedor vendedor)
        {
            InitializeComponent();
            this.vendedorForm = vendedor;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
