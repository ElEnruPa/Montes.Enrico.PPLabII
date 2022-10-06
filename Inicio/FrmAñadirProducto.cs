using BiblioDeClasesTP1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    public partial class FrmAñadirProducto : Form
    {
        private Dueño dueñoLocal = new Dueño();

        public FrmAñadirProducto(Dueño dueñoGlobal)
        {
            InitializeComponent();
            this.dueñoLocal = dueñoGlobal;
            dgvInventario.DataSource = null; //Limpio la lista q tenia antes
            dgvInventario.DataSource = this.dueñoLocal.listaProductos; //Agrego la lista nuevamente
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro que quiere agreagar este producto?", "AGREGO DE PRODUCTO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Producto p1 = new Producto(); //Instancio el objeto

                if (String.IsNullOrEmpty(cbxTag.Text) || String.IsNullOrEmpty(txtProducto.Text))
                {
                    MessageBox.Show("No se ingreso el tag y/o el nombre del producto.", "DATON SIN INGRESAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (numUD_Precio.Value <= 0 || numUD_Stock.Value <= 0)
                    {
                        MessageBox.Show("Se ingreso incorrectamente el precio y/o el stock del producto.", "DATON SIN INGRESAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        p1.Tag = cbxTag.Text;
                        p1.Nombre = txtProducto.Text;
                        p1.Precio = (int)numUD_Precio.Value;
                        p1.Stock = (int)numUD_Stock.Value;

                        if(ProductosIguales(p1))
                        {
                            MessageBox.Show("Se quiere ingresar un producto que ya existe.", "PRODUCTOS IGUALES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            dueñoLocal.AgregarProducto(p1); //Agrego el producto a la lista

                            dgvInventario.DataSource = null; //Limpio la lista q tenia antes
                            dgvInventario.DataSource = dueñoLocal.listaProductos; //Agrego la lista nuevamente

                            LimpiarControles();
                        }
                    }
                }
            }
        }

        private bool ProductosIguales(Producto p1)
        {
            bool retorno = false;

            foreach(Producto p2 in this.dueñoLocal.listaProductos)
            {
                if(p2 == p1)
                {
                    retorno = true;
                }
            }
            return retorno;
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
