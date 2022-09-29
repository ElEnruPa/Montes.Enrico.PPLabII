using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase5_Form
{
    public partial class FrmSaludar : Form
    {
        public FrmSaludar()
        {
            InitializeComponent();
        }

        public FrmSaludar(string nombre) : this()
        {
            this.lblSaludo.Text = $"Hola {nombre} como tas";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string equipo;
            equipo = this.cboEquipo.Text;
            MessageBox.Show($"Usted es hincha de {equipo}");
            //DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
