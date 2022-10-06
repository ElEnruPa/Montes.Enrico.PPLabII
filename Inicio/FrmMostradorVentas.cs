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
    public partial class FrmMostradorVentas : Form
    {
        private Usuario usuarioVentas = new Usuario();

        public FrmMostradorVentas(Usuario usuarioVentas)
        {
            InitializeComponent();
            this.usuarioVentas = usuarioVentas;
            dgvMostradorVentas.DataSource = null;
            dgvMostradorVentas.DataSource = this.usuarioVentas.listaProductos;
        }
    }
}
