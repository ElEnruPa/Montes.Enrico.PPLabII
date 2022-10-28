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
    public partial class FrmCatalogoProveedor : Form
    {
        private Dueño dueñoForm;
        private List<Proveedor> listaProveedoresForm;

        public FrmCatalogoProveedor(Dueño dueño, List<Proveedor> listaProveedores)
        {
            InitializeComponent();
            dueñoForm = dueño;
            this.listaProveedoresForm = listaProveedores;
            dgvProveedores.DataSource = null; //Limpio la lista q tenia antes
            dgvProveedores.DataSource = this.listaProveedoresForm; //Agrego la lista nuevamente
        }

        private void btnVerCatalogo_Click(object sender, EventArgs e)
        {
            string nombre = dgvProveedores.SelectedRows[0].Cells[0].Value.ToString();
            int cuil = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells[1].Value);

            Proveedor p = EncontrarProveedor(nombre, cuil);

            dgvInventario.DataSource = null; //Limpio la lista q tenia antes
            dgvInventario.DataSource = p.ListaProductos; //Agrego la lista nuevamente
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string tag = dgvInventario.SelectedRows[0].Cells[0].Value.ToString();
            string nombre = dgvInventario.SelectedRows[0].Cells[1].Value.ToString();
            int precio = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells[2].Value);
            int stock = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells[3].Value);
            int cantidadCompra = (int)numUD_Cantidad.Value;

            Producto producto = new Producto(tag, nombre, precio, cantidadCompra);

            if (cantidadCompra > stock || cantidadCompra <= 0)
            {
                MessageBox.Show("El stock que el cliente quiere no esta disponible.", "STOCK INSUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Proveedor proveedor = BuscarProveedorPorProducto(producto);

                proveedor.Vender(nombre, tag, cantidadCompra);

                dgvInventario.DataSource = null;
                dgvInventario.DataSource = proveedor.ListaProductos;

                MessageBox.Show("La compra fue realizada exitosamente.", "COMPRA REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (ProductosIguales(producto))
                {
                    dueñoForm.AgregarStock(producto);
                }
                else
                {
                    dueñoForm.AgregarProducto(producto);
                }
                numUD_Cantidad.Value = 0;
            }
        }

        private Proveedor EncontrarProveedor(string nombre, int cuil)
        {
            Proveedor proveedorEncontrado = new Proveedor();

            foreach (Proveedor p in this.listaProveedoresForm)
            {
                if(p.Nombre == nombre && p.Cuil == cuil)
                {
                    proveedorEncontrado = p;
                }
            }
            return proveedorEncontrado;
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

        private Proveedor BuscarProveedorPorProducto(Producto p)
        {
            Proveedor proveedorEncontrado = new Proveedor();

            foreach(Proveedor proveedor in this.listaProveedoresForm)
            {
                foreach(Producto producto in proveedor.ListaProductos)
                {
                    if(producto == p)
                    {
                        proveedorEncontrado = proveedor;
                    }
                }
            }
            return proveedorEncontrado;
        }
    }
}
