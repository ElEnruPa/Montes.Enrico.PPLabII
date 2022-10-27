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
    public partial class FrmAdministracionDeInventario : Form
    {
        private Dueño dueñoForm = new Dueño();

        public FrmAdministracionDeInventario(Dueño dueño)
        {
            InitializeComponent();
            dueñoForm = dueño;
            dgvInventario.DataSource = null; //Limpio la lista q tenia antes
            dgvInventario.DataSource = this.dueñoForm.ListaProductos; //Agrego la lista nuevamente
        }

        private void btnFiltarYVer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbxTag.Text) && String.IsNullOrEmpty(txtProducto.Text))
            {
                MessageBox.Show("No se ingreso el tag o el nombre del producto.", "DATON SIN INGRESAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvInventario.DataSource = null; //Limpio la lista q tenia antes
                dgvInventario.DataSource = this.dueñoForm.ListaProductos; //Agrego la lista nuevamente
            }
            else
            {
                List<Producto> listaProductosVacia = new List<Producto>();

                string tag;
                string nombre;

                tag = cbxTag.Text;
                nombre = txtProducto.Text;

                foreach (Producto p in dueñoForm.ListaProductos)
                {
                    if (p.Tag == tag || p.Nombre == nombre)
                    {
                        listaProductosVacia.Add(p);
                    }
                }

                dgvInventario.DataSource = null; //Limpio la lista q tenia antes
                dgvInventario.DataSource = listaProductosVacia; //Agrego la lista nuevamente
                LimpiarControles();
            }
        }

        private void LimpiarControles()
        {
            cbxTag.SelectedIndex = -1;
            txtProducto.Clear();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            FrmAñadirProducto frmAñadirProducto = new FrmAñadirProducto(dueñoForm);
            frmAñadirProducto.ShowDialog();
        }
    }
}
