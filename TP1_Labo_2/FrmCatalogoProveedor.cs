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
        private bool flag = false;
        private Dueño dueñoForm = new Dueño();
        private Proveedor p1 = new Proveedor();
        private Proveedor p2 = new Proveedor();
        private List<Proveedor> listaProveedores = new List<Proveedor>();

        public FrmCatalogoProveedor(Dueño dueño)
        {
            InitializeComponent();
            dueñoForm = dueño;
            Proveedor p11 = new Proveedor("Enrico Inc.", 12345, Listap1());
            Proveedor p22 = new Proveedor("Carlos Inc.", 67890, Listap2());
            p1 = p11;
            p2 = p22;
            List<Proveedor> listaProveedoresNueva = new List<Proveedor>();
            listaProveedores = listaProveedoresNueva;
            listaProveedores.Add(p1);
            listaProveedores.Add(p2);
            dgvProveedores.DataSource = null; //Limpio la lista q tenia antes
            dgvProveedores.DataSource = this.listaProveedores; //Agrego la lista nuevamente
        }

        private void btnVerCatalogo_Click(object sender, EventArgs e)
        {
            string nombre = dgvProveedores.SelectedRows[0].Cells[0].Value.ToString();
            int cuil = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells[1].Value);

            if(nombre == "Enrico Inc." && cuil == 12345)
            {
                dgvInventario.DataSource = null; //Limpio la lista q tenia antes
                dgvInventario.DataSource = this.p1.ListaProductos; //Agrego la lista nuevamente
                flag = false;
            }
            else
            {
                if(nombre == "Carlos Inc." && cuil == 67890)
                {
                    dgvInventario.DataSource = null; //Limpio la lista q tenia antes
                    dgvInventario.DataSource = this.p2.ListaProductos; //Agrego la lista nuevamente
                    flag = true;
                }
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string tag = dgvInventario.SelectedRows[0].Cells[0].Value.ToString();
            string nombre = dgvInventario.SelectedRows[0].Cells[1].Value.ToString();
            int precio = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells[2].Value);
            int stock = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells[3].Value);
            int cantidadCompra = (int)numUD_Cantidad.Value;

            Producto producto = new Producto(tag, nombre, precio, cantidadCompra);
            Proveedor proveedor = new Proveedor();

            if (cantidadCompra > stock || cantidadCompra <= 0)
            {
                MessageBox.Show("El stock que el cliente quiere no esta disponible.", "STOCK INSUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                proveedor = BuscarProveedor(producto);

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

        private Proveedor BuscarProveedor(Producto p)
        {
            Proveedor proveedorEncontrado = new Proveedor();

            foreach(Proveedor proveedor in this.listaProveedores)
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

        private List<Producto> Listap1()
        {
            List<Producto> listaDefa = new List<Producto>();

            Producto p1 = new Producto("Computadora Escritorio", "Computadora Gamer", 170000, 20);
            Producto p2 = new Producto("Notebook", "HP 24'", 58000, 120);
            Producto p3 = new Producto("Monitor", "Samsung 28'", 62000, 90);
            Producto p4 = new Producto("Perifericos", "Mouse Logitech", 3000, 100);
            Producto p5 = new Producto("Silla", "Gamer", 88000, 160);
            Producto p6 = new Producto("Otros", "Pasta Termica", 800, 700);
            listaDefa.Add(p1);
            listaDefa.Add(p2);
            listaDefa.Add(p3);
            listaDefa.Add(p4);
            listaDefa.Add(p5);
            listaDefa.Add(p6);

            return listaDefa;
        }

        private List<Producto> Listap2()
        {
            List<Producto> listaDefa = new List<Producto>();

            Producto p1 = new Producto("Notebook", "Razer Ultra", 248000, 30);
            Producto p2 = new Producto("Monitor", "Zowie 240hz", 262000, 80);
            Producto p3 = new Producto("Perifericos", "Mouse Normal", 3000, 600);
            Producto p4 = new Producto("Otros", "Cable USB", 1700, 1000);
            listaDefa.Add(p1);
            listaDefa.Add(p2);
            listaDefa.Add(p3);
            listaDefa.Add(p4);

            return listaDefa;
        }
    }
}
