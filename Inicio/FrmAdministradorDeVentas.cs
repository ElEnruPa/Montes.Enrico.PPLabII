using BiblioDeClasesTP1;
using Inicio;
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
    public partial class FrmAdministradorDeVentas : Form
    {
        private Dueño dueñoLocal = new Dueño();
        private Usuario usuarioLocal = new Usuario();
        private Usuario usuarioVentas = new Usuario();

        public FrmAdministradorDeVentas(Dueño dueñoGlobal, Usuario usuarioVentas)
        {
            InitializeComponent();
            this.dueñoLocal = dueñoGlobal;
            this.usuarioLocal = dueñoGlobal;
            this.usuarioVentas = usuarioVentas;
            dgvInventario.DataSource = null; 
            dgvInventario.DataSource = this.dueñoLocal.listaProductos; 
        }

        private void btnVender_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("¿Estas seguro que quiere realizar esta venta?", "VENTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Producto p1 = new Producto();
                Producto pVenta = new Producto();

                int dineroCliente = (int)numUD_DineroCliente.Value;
                string nombre = txtProducto.Text;
                string tag = cbxTag.Text;
                int cantidad = (int)numUD_Cantidad.Value;
                int cantidadDisminuida;

                p1 = usuarioLocal.EncontrarProducto(nombre, tag);

                pVenta.Tag = tag;
                pVenta.Nombre = nombre;
                pVenta.Stock = cantidad;
                pVenta.Precio = p1.Precio;

                if (String.IsNullOrEmpty(p1.Tag) || String.IsNullOrEmpty(p1.Nombre))
                {
                    MessageBox.Show("El Tag y/o el nombre del producto son incorrectos.", "DATOS INCORRECTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(cantidad > p1.Stock || cantidad == 0)
                    {
                        MessageBox.Show("El stock que el cliente quiere no esta disponible.", "STOCK INSUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (rbdDebito.Checked == false && rbdCredito.Checked == false && rbdEfectivo.Checked == false)
                        {
                            MessageBox.Show("Porfavor seleccione un metodo de pago.", "SELECCION DE PAGO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (ValidarDinero(dineroCliente, p1.Precio, cantidad) || rbdCredito.Checked || rbdDebito.Checked)
                            {
                                double precio = p1.Precio;
                                double vuelto;

                                if (rbdCredito.Checked)
                                {
                                    precio *= 1.1;
                                    vuelto = 0;
                                }
                                else
                                {
                                    vuelto = dineroCliente - (precio * cantidad);
                                }

                                precio = Math.Round(precio);
                                vuelto = Math.Round(vuelto);
                                cantidadDisminuida = usuarioLocal.Vender(nombre, tag, cantidad);
                                dgvInventario.DataSource = null;
                                dgvInventario.DataSource = this.usuarioLocal.listaProductos;
                                usuarioVentas.listaProductos.Add(pVenta);
                                GenerarTicket(precio, vuelto, cantidad);
                                LimpiarControles();
                            }
                            else
                            {
                                MessageBox.Show("El dinero del cliente no es suficiente para comprar el producto.", "DINERO INSUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                    }
                }
            }
        }

        private void GenerarTicket(double dineroProducto, double vuelto, int cantidad)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tag: {cbxTag.Text}");
            sb.AppendLine($"Producto: {txtProducto.Text}");
            sb.AppendLine($"Cantidad: {numUD_Cantidad.Value}");

            if(rbdDebito.Checked)
            {
                sb.AppendLine($"Pago: {rbdDebito.Text}");
                sb.AppendLine($"Dinero cliente: {dineroProducto * cantidad}");
            }
            else
            {
                if(rbdCredito.Checked)
                {
                    sb.AppendLine($"Pago: {rbdCredito.Text}");
                    sb.AppendLine($"Dinero cliente: {dineroProducto * cantidad}");
                }
                else
                {
                    sb.AppendLine($"Pago: {rbdEfectivo.Text}");
                    sb.AppendLine($"Dinero cliente: {numUD_DineroCliente.Value}");
                }
            }

            sb.AppendLine($"Costo del producto: {dineroProducto * cantidad}");
            sb.AppendLine($"Vuelto: {vuelto}");

            MessageBox.Show(sb.ToString(),"TICKET",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void LimpiarControles()
        {
            numUD_DineroCliente.Value = 0;
            cbxTag.SelectedIndex = -1;
            txtProducto.Clear();
            numUD_Cantidad.Value = 0;
            rbdDebito.Checked = false;
            rbdCredito.Checked = false;
            rbdEfectivo.Checked = false;
        }

        private bool ValidarDinero(int dineroCliente, int precioProducto, int cantidad)
        {
            bool retorno = false;

            if(dineroCliente >= (precioProducto*cantidad))
            {
                retorno = true;
            }

            return retorno;
        }

        private void btnMostrarVentas_Click(object sender, EventArgs e)
        {
            FrmMostradorVentas frmMostradorVentas = new FrmMostradorVentas(usuarioVentas);
            frmMostradorVentas.ShowDialog();
            //this.Close();
        }
    }
}
