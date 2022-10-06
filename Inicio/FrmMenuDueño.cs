using BiblioDeClasesTP1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmMenuDueño : Form
    {
        private Dueño dueñoLocal = new Dueño();

        public FrmMenuDueño(Dueño dueñoGlobal)
        {
            InitializeComponent();
            this.dueñoLocal = dueñoGlobal;
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            FrmAdministradorDeInventario frmAdministradorDeInventario = new FrmAdministradorDeInventario(dueñoLocal);
            frmAdministradorDeInventario.ShowDialog();
            //this.Close();
        }

        private void btnAV_Click(object sender, EventArgs e)
        {
            FrmAdministradorDeVentas frmAdministradorDeVentas = new FrmAdministradorDeVentas(dueñoLocal);
            frmAdministradorDeVentas.ShowDialog();
            //this.Close();
        }
    }
}
