using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Proveedor
    {
        
        private string nombre;
        private int cuil;
        private List<Producto> listaProductos;

        public Proveedor()
        {
            this.nombre = "";
            this.cuil = 0;
            this.listaProductos = new List<Producto>();
        }

        public Proveedor(string nombre, int cuil, List<Producto> listaProductos) : this()
        {
            this.nombre = nombre;
            this.cuil = cuil;
            this.listaProductos = listaProductos;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Cuil
        {
            get { return cuil; }
            set { cuil = value; }
        }

        public List<Producto> ListaProductos
        {
            get { return this.listaProductos; }
            set { this.listaProductos = value; }
        }

        public int Vender(string nombre, string tag, int cantidad)
        {
            int stockDisminuido = -1;
            Producto p1 = new Producto();

            foreach (Producto p in ListaProductos)
            {
                if (p.Tag == tag && p.Nombre == nombre)
                {
                    stockDisminuido = p.DisminucionStock(cantidad);
                    p1 = ProductoSinStock();
                }
            }
            ListaProductos.Remove(p1);

            return stockDisminuido;
        }

        private Producto ProductoSinStock()
        {
            Producto p1 = new Producto();

            foreach (Producto p in ListaProductos)
            {
                if (p.Stock <= 0)
                {
                    p1 = p;
                }
            }

            return p1;
        }
    }
}
