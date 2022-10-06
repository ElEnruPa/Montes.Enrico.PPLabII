using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioDeClasesTP1
{
    public class Usuario
    {
        public string email;
        public string contraseña;
        public List<Producto> listaProductos = new List<Producto>();

        public Usuario()
        {
        }

        public Usuario(string email, string contraseña, List<Producto> listaProductos)
        {
            this.email = email;
            this.contraseña = contraseña;
            this.listaProductos = listaProductos;
        }

        public int Vender(string nombre, string tag, int cantidad)
        {
            int stockDisminuido = -1;

            foreach (Producto p in this.listaProductos)
            {
                if (p.Tag == tag && p.Nombre == nombre)
                {
                    stockDisminuido = p.DisminucionStock(cantidad);
                }
            }

            return stockDisminuido;
        }

        public Producto EncontrarProducto(string nombre, string tag)
        {
            Producto p1 = new Producto();

            foreach (Producto p in this.listaProductos)
            {
                if (p.Tag == tag && p.Nombre == nombre)
                {
                    p1 = p;
                }
            }

            return p1;
        }
    }


    public class Dueño : Usuario
    {
        public Dueño()
        { 
        }

        public List<Producto> ListaDefault()
        {
            Producto p1 = new Producto("Computadora Escritorio", "Computadora Oficina", 70000, 50);
            Producto p2 = new Producto("Notebook", "Lenovo 22'", 48000, 100);
            Producto p3 = new Producto("Monitor", "LG 24'", 22000, 40);
            Producto p4 = new Producto("Perifericos", "Mouse Logitech", 3000, 200);
            Producto p5 = new Producto("Silla", "De Oficina", 18000, 70);
            Producto p6 = new Producto("Otros", "Pasta Termica", 800, 1500);
            listaProductos.Add(p1);
            listaProductos.Add(p2);
            listaProductos.Add(p3);
            listaProductos.Add(p4);
            listaProductos.Add(p5);
            listaProductos.Add(p6);

            return listaProductos;
        }

        public void AgregarProducto(Producto p1)
        {
            listaProductos.Add(p1);
        }
    }
}
