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
    public partial class FrmContadorVentas : Form
    {
        private Usuario usuarioVentas = new Usuario();

        public FrmContadorVentas(Usuario usuarioVentas)
        {
            InitializeComponent();
            this.usuarioVentas = usuarioVentas;
            dgvContadorVentas.DataSource = null;
            dgvContadorVentas.DataSource = this.usuarioVentas.listaProductos;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!rbdGananciaTotal.Checked && !rbdProductoMasVendidoPorTag.Checked && !rbdPromedioGanancias.Checked) 
            {
                MessageBox.Show("Ninguna opcion esta marcada", "OPCION SIN MARCAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(rbdGananciaTotal.Checked)
                {
                    int gananciaTotal = GananciaTotal(usuarioVentas.listaProductos);
                    MessageBox.Show($"Ganancia total: {gananciaTotal}", "GANANCIA TOTAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(rbdProductoMasVendidoPorTag.Checked)
                    {
                        MessageBox.Show($"{SBProductoMasVendido()}", "PRODUCTOS MAS VENDIDOS POR TAG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if(rbdPromedioGanancias.Checked)
                        {
                            MessageBox.Show($"{SBPromedioGananciasPorTag()}", "PRODUCTOS GANANCIAS POR TAG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private int GananciaTotal(List<Producto> listaVendidos)
        {
            int ganancias = 0;

            foreach(Producto p in listaVendidos)
            {
                ganancias += (p.Precio * p.Stock);
            }
            return ganancias;
        }

        private string ProductoMasVendidoPorTag(string tag)
        {
            string nombre = "No se vendio ningun producto.";
            int vendidos = 0;
            bool flag = false;

            foreach(Producto p1 in usuarioVentas.listaProductos)
            {
                if(p1.Tag == tag)
                {
                    if(!flag)
                    {
                        nombre = p1.Nombre;
                        vendidos = p1.Stock;
                        flag = true;
                    }
                    else
                    {
                        if(p1.Stock > vendidos)
                        {
                            nombre = p1.Nombre;
                            vendidos = p1.Stock;
                        }
                    }
                }
            }

            return nombre;
        }

        private string SBProductoMasVendido()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Computadora Escritorio: {ProductoMasVendidoPorTag("Computadora Escritorio")}");
            sb.AppendLine($"Notebook: {ProductoMasVendidoPorTag("Notebook")}");
            sb.AppendLine($"Monitor: {ProductoMasVendidoPorTag("Monitor")}");
            sb.AppendLine($"Perifericos: {ProductoMasVendidoPorTag("Perifericos")}");
            sb.AppendLine($"Silla: {ProductoMasVendidoPorTag("Silla")}");
            sb.AppendLine($"Otros: {ProductoMasVendidoPorTag("Otros")}");

            return sb.ToString();
        }

        private float PromedioGananciaPorTag(string tag)
        {
            float sumador = 0;
            float promedio = 0;
            int cantidad = 0;

            foreach (Producto p1 in usuarioVentas.listaProductos)
            {
                if (p1.Tag == tag)
                {
                    sumador += p1.Precio;
                    cantidad += p1.Stock;
                }
            }

            if(cantidad != 0)
            {
                promedio = sumador / cantidad;
            }

            return promedio;
        }

        private string SBPromedioGananciasPorTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Computadora Escritorio: {PromedioGananciaPorTag("Computadora Escritorio")}");
            sb.AppendLine($"Notebook: {PromedioGananciaPorTag("Notebook")}");
            sb.AppendLine($"Monitor: {PromedioGananciaPorTag("Monitor")}");
            sb.AppendLine($"Perifericos: {PromedioGananciaPorTag("Perifericos")}");
            sb.AppendLine($"Silla: {PromedioGananciaPorTag("Silla")}");
            sb.AppendLine($"Otros: {PromedioGananciaPorTag("Otros")}");

            return sb.ToString();
        }

    }
}
