using BiblioDeClasesTP1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmAdministradorDeInventario : Form
    {
        private Dueño dueñoLocal = new Dueño();

        public FrmAdministradorDeInventario(Dueño dueñoGlobal)
        {
            InitializeComponent();
            this.dueñoLocal = dueñoGlobal;
            dgvInventario.DataSource = null; //Limpio la lista q tenia antes
            dgvInventario.DataSource = this.dueñoLocal.listaProductos; //Agrego la lista nuevamente
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            FrmAñadirProducto frmAñadirProducto = new FrmAñadirProducto(dueñoLocal);
            frmAñadirProducto.ShowDialog();
            //this.Close();
        }

        private void btnFiltrarVer_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(cbxTag.Text) && String.IsNullOrEmpty(txtProducto.Text))
            {
                MessageBox.Show("No se ingreso el tag o el nombre del producto.", "DATON SIN INGRESAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvInventario.DataSource = null; //Limpio la lista q tenia antes
                dgvInventario.DataSource = this.dueñoLocal.listaProductos; //Agrego la lista nuevamente
            }
            else
            {
                Dueño dueñoFiltro = new Dueño();

                string tag;
                string nombre;

                tag = cbxTag.Text;
                nombre = txtProducto.Text;

                foreach (Producto p in dueñoLocal.listaProductos)
                {
                    if (p.Tag == tag || p.Nombre == nombre)
                    {
                        dueñoFiltro.AgregarProducto(p);
                    }
                }

                dgvInventario.DataSource = null; //Limpio la lista q tenia antes
                dgvInventario.DataSource = dueñoFiltro.listaProductos; //Agrego la lista nuevamente
                LimpiarHerramientas();
            }
        }

        private void LimpiarHerramientas()
        {
            cbxTag.SelectedIndex = -1;
            txtProducto.Clear();
        }
    }
}
