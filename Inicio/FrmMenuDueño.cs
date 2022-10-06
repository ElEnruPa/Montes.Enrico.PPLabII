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
        private Usuario usuarioVentas = new Usuario();

        public FrmMenuDueño(Dueño dueñoGlobal, Usuario usuarioVentas)
        {
            InitializeComponent();
            this.dueñoLocal = dueñoGlobal;
            this.usuarioVentas = usuarioVentas;
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            FrmAdministradorDeInventario frmAdministradorDeInventario = new FrmAdministradorDeInventario(dueñoLocal);
            frmAdministradorDeInventario.ShowDialog();
            //this.Close();
        }

        private void btnAV_Click(object sender, EventArgs e)
        {
            FrmAdministradorDeVentas frmAdministradorDeVentas = new FrmAdministradorDeVentas(dueñoLocal, usuarioVentas);
            frmAdministradorDeVentas.ShowDialog();
            //this.Close();
        }
    }
}
