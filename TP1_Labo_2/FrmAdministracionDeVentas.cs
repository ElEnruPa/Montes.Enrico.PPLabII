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
    public partial class FrmAdministracionDeVentas : Form
    {
        private Vendedor vendedorForm = new Vendedor();

        public FrmAdministracionDeVentas(Vendedor vendedor)
        {
            InitializeComponent();
            this.vendedorForm = vendedor;
            dgvInventario.DataSource = null; //Limpio la lista q tenia antes
            dgvInventario.DataSource = this.vendedorForm.ListaProductos; //Agrego la lista nuevamente
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbxTag.Text) && String.IsNullOrEmpty(txtProducto.Text))
            {
                MessageBox.Show("No se ingreso el tag o el nombre del producto.", "DATON SIN INGRESAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvInventario.DataSource = null; //Limpio la lista q tenia antes
                dgvInventario.DataSource = this.vendedorForm.ListaProductos; //Agrego la lista nuevamente
            }
            else
            {
                List<Producto> listaProductosVacia = new List<Producto>();

                string tag = cbxTag.Text;
                string nombre = txtProducto.Text;

                foreach (Producto p in vendedorForm.ListaProductos)
                {
                    if (p.Tag == tag || p.Nombre == nombre)
                    {
                        listaProductosVacia.Add(p);
                    }
                }

                dgvInventario.DataSource = null; //Limpio la lista q tenia antes
                dgvInventario.DataSource = listaProductosVacia; //Agrego la lista nuevamente
                cbxTag.SelectedIndex = -1;
                txtProducto.Clear();
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            string tag = dgvInventario.SelectedRows[0].Cells[0].Value.ToString();
            string nombre = dgvInventario.SelectedRows[0].Cells[1].Value.ToString();
            int precio = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells[2].Value);
            int stock = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells[3].Value);
            int dineroCliente = (int)numUD_DineroCliente.Value;
            int cantidadCompra = (int)numUD_Cantidad.Value;
            double precioFinal = precio * cantidadCompra;
            bool debito = rbdDebito.Checked;
            bool credito = rbdCredito.Checked;
            bool efectivo = rbdEfectivo.Checked;

            if (cantidadCompra > stock || cantidadCompra <= 0)
            {
                MessageBox.Show("El stock que el cliente quiere no esta disponible.", "STOCK INSUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!debito && !credito && !efectivo)
                {
                    MessageBox.Show("Porfavor seleccione un metodo de pago.", "SELECCION DE PAGO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(ValidarDinero(dineroCliente, precioFinal) || debito || credito)
                    {
                        double vuelto = 0;

                        if (credito)
                        {
                            precioFinal *= 1.1;
                        }
                        else
                        {
                            if(efectivo)
                            {
                                vuelto = dineroCliente - precioFinal;
                            }
                        }

                        precioFinal = Math.Round(precioFinal);
                        vuelto = Math.Round(vuelto);
                        this.vendedorForm.Vender(nombre, tag, cantidadCompra);

                        dgvInventario.DataSource = null;
                        dgvInventario.DataSource = this.vendedorForm.ListaProductos;

                        string ticket = GenerarTicket(precioFinal, vuelto);
                        MessageBox.Show(ticket, "TICKET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("El dinero del cliente no es suficiente para comprar el producto.", "DINERO INSUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }

        }

        private bool ValidarDinero(int dineroCliente, double precioFinal)
        {
            bool retorno = false;

            if (dineroCliente >= precioFinal)
            {
                retorno = true;
            }

            return retorno;
        }

        private string GenerarTicket(double precioFinal, double vuelto)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tag: {dgvInventario.SelectedRows[0].Cells[0].Value.ToString()}");
            sb.AppendLine($"Producto: {dgvInventario.SelectedRows[0].Cells[1].Value.ToString()}");
            sb.AppendLine($"Cantidad: {numUD_Cantidad.Value}");

            if (rbdDebito.Checked)
            {
                sb.AppendLine($"Pago: {rbdDebito.Text}");
                sb.AppendLine($"Dinero cliente: {precioFinal}");
            }
            else
            {
                if (rbdCredito.Checked)
                {
                    sb.AppendLine($"Pago: {rbdCredito.Text}");
                    sb.AppendLine($"Dinero cliente: {precioFinal}");
                }
                else
                {
                    sb.AppendLine($"Pago: {rbdEfectivo.Text}");
                    sb.AppendLine($"Dinero cliente: {numUD_DineroCliente.Value}");
                }
            }

            sb.AppendLine($"Costo del producto: {Convert.ToInt32(dgvInventario.SelectedRows[0].Cells[2].Value)}");
            sb.AppendLine($"Costo total: {precioFinal}");
            sb.AppendLine($"Vuelto: {vuelto}");

            return sb.ToString();
        }

        private void LimpiarControles()
        {
            cbxTag.SelectedIndex = -1;
            txtProducto.Clear();
            numUD_DineroCliente.Value = 0;
            numUD_Cantidad.Value = 0;
            rbdDebito.Checked = false;
            rbdCredito.Checked = false;
            rbdEfectivo.Checked = false;
        }

        private void btnVentasHechas_Click(object sender, EventArgs e)
        {
            FrmMostradorVentas frmMostradorVentas = new FrmMostradorVentas(vendedorForm);
            frmMostradorVentas.ShowDialog();
        }
    }
}
