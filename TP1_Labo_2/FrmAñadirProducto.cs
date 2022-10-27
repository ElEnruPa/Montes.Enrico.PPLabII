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
    public partial class FrmAñadirProducto : Form
    {
        private Dueño dueñoForm = new Dueño();

        public FrmAñadirProducto(Dueño dueño)
        {
            InitializeComponent();
            dueñoForm = dueño;
            dgvInventario.DataSource = null; //Limpio la lista q tenia antes
            dgvInventario.DataSource = this.dueñoForm.ListaProductos; //Agrego la lista nuevamente
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tag = cbxTag.Text;
            string nombre = txtProducto.Text;
            int precio = (int)numUD_Precio.Value;
            int stock = (int)numUD_Stock.Value;

            Producto p1 = new Producto(tag, nombre, precio, stock);

            if(String.IsNullOrEmpty(tag) || String.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("No se ingreso el tag y/o el nombre del producto.", "DATON SIN INGRESAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (precio <= 0 || stock <= 0)
                {
                    MessageBox.Show("Se ingreso incorrectamente el precio y/o el stock del producto.", "DATON SIN INGRESAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ProductosIguales(p1))
                    {
                        AgregarStock(p1);
                        MessageBox.Show("El producto ya existe, se le añadio el stock indicado.", "PRODUCTOS EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgvInventario.DataSource = null; //Limpio la lista q tenia antes
                        dgvInventario.DataSource = dueñoForm.ListaProductos; //Agrego la lista nuevamente

                        LimpiarControles();
                    }
                    else
                    {
                        if (MessageBox.Show("¿Estas seguro que quiere agreagar este producto?", "AGREGO DE PRODUCTO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            dueñoForm.AgregarProducto(p1); //Agrego el producto a la lista

                            dgvInventario.DataSource = null; //Limpio la lista q tenia antes
                            dgvInventario.DataSource = dueñoForm.ListaProductos; //Agrego la lista nuevamente

                            LimpiarControles();
                        }
                    }
                }
            }
        }

        private bool ProductosIguales(Producto p1)
        {
            bool retorno = false;

            foreach (Producto p2 in this.dueñoForm.ListaProductos)
            {
                if (p2 == p1)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        private void AgregarStock(Producto p1)
        {
            foreach (Producto p2 in this.dueñoForm.ListaProductos)
            {
                if (p2 == p1)
                {
                    p2.Stock += p1.Stock;
                }
            }
        }

        private void LimpiarControles()
        {
            txtProducto.Clear();
            numUD_Precio.Value = 0;
            numUD_Stock.Value = 0;
            cbxTag.SelectedIndex = -1;
        }
    }
}
