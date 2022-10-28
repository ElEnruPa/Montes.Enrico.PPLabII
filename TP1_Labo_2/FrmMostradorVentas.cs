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
    public partial class FrmMostradorVentas : Form
    {
        private Contador contadorForm;

        public FrmMostradorVentas(Contador contador)
        {
            InitializeComponent();
            this.contadorForm = contador;
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = this.contadorForm.ListaProductos;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool productoMasVendidoPorTag = rbdProductoMasVendidoPorTag.Checked;
            bool promedioGananciaPorTag = rbdPromedioGanancia.Checked;
            bool gananciaTotal = rbdGananciaTotal.Checked;

            if (!productoMasVendidoPorTag && !promedioGananciaPorTag && !gananciaTotal)
            {
                MessageBox.Show("Ninguna opcion esta marcada", "OPCION SIN MARCAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (productoMasVendidoPorTag)
                {
                    MessageBox.Show($"{SBProductoMasVendidoPorTag()}", "PRODUCTOS MAS VENDIDOS POR TAG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (promedioGananciaPorTag)
                    {
                        MessageBox.Show($"{SBPromedioGananciaPorTag()}", "PROMEDIO GANANCIA POR TAG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int gananciaDeTodo = GananciaTotal();
                        MessageBox.Show($"Ganancia total: {gananciaDeTodo}", "GANANCIA TOTAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            LimpiarControles();
        }

        private string SBProductoMasVendidoPorTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Computadora Escritorio: {ProductoMasVendido("Computadora Escritorio")}");
            sb.AppendLine($"Notebook: {ProductoMasVendido("Notebook")}");
            sb.AppendLine($"Monitor: {ProductoMasVendido("Monitor")}");
            sb.AppendLine($"Perifericos: {ProductoMasVendido("Perifericos")}");
            sb.AppendLine($"Silla: {ProductoMasVendido("Silla")}");
            sb.AppendLine($"Otros: {ProductoMasVendido("Otros")}");

            return sb.ToString();
        }

        private string ProductoMasVendido(string tag)
        {
            string nombre = "No se vendio ningun producto.";
            int vendidos = 0;
            bool flag = false;

            foreach (Producto p1 in contadorForm.ListaProductos)
            {
                if (p1.Tag == tag)
                {
                    if (!flag)
                    {
                        nombre = p1.Nombre;
                        vendidos = p1.Stock;
                        flag = true;
                    }
                    else
                    {
                        if (p1.Stock > vendidos)
                        {
                            nombre = p1.Nombre;
                            vendidos = p1.Stock;
                        }
                    }
                }
            }
            return nombre;
        }

        private string SBPromedioGananciaPorTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Computadora Escritorio: {PromedioGanancia("Computadora Escritorio")}");
            sb.AppendLine($"Notebook: {PromedioGanancia("Notebook")}");
            sb.AppendLine($"Monitor: {PromedioGanancia("Monitor")}");
            sb.AppendLine($"Perifericos: {PromedioGanancia("Perifericos")}");
            sb.AppendLine($"Silla: {PromedioGanancia("Silla")}");
            sb.AppendLine($"Otros: {PromedioGanancia("Otros")}");

            return sb.ToString();
        }

        private float PromedioGanancia(string tag)
        {
            float sumador = 0;
            float promedio = 0;
            int cantidad = 0;

            foreach (Producto p1 in contadorForm.ListaProductos)
            {
                if (p1.Tag == tag)
                {
                    sumador += (p1.Precio * p1.Stock);
                    cantidad += p1.Stock;
                }
            }

            if (cantidad != 0)
            {
                promedio = sumador / cantidad;
            }

            return promedio;
        }

        private int GananciaTotal()
        {
            int ganancias = 0;

            foreach (Producto p in contadorForm.ListaProductos)
            {
                ganancias += (p.Precio * p.Stock);
            }
            return ganancias;
        }

        private void LimpiarControles()
        {
            this.rbdProductoMasVendidoPorTag.Checked = false;
            this.rbdPromedioGanancia.Checked = false;
            this.rbdGananciaTotal.Checked = false;
        }
    }
}
