using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Dueño : Usuario
    {
        public Dueño() : base()
        {
        }

        public Dueño(string email, string contraseña, List<Producto> listaProductos) : base(email, contraseña, listaProductos)
        {
        }

        public override string Email 
        {
            get { return this.email;  }
            set { this.email = value; }
        }

        public override string Contraseña
        {
            get { return this.contraseña; }
            set { this.contraseña = value; }
        }

        public override List<Producto> ListaProductos
        {
            get { return this.listaProductos; }
            set { this.listaProductos = value; }
        }

        public override int Vender(string nombre, string tag, int cantidad)
        {
            int stockDisminuido = -1;

            foreach (Producto p in this.listaProductos)
            {
                if (p.Tag == tag && p.Nombre == nombre)
                {
                    stockDisminuido = p.DisminucionStock(cantidad);
                    EliminarProductos();
                }
            }

            return stockDisminuido;
        }

        public void AgregarProducto(Producto p1)
        {
            listaProductos.Add(p1);
        }

        public void EliminarProductos()
        {
            foreach (Producto p in this.listaProductos)
            {
                if (p.Stock <= 0)
                {
                    listaProductos.Remove(p);
                }
            }
        }
    }
}
