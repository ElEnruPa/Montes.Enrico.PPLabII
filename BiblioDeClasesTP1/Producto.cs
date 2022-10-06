using System.ComponentModel;

namespace BiblioDeClasesTP1
{
    public class Producto
    {
        private string tag;
        private string nombre;
        private int precio;
        private int stock;

        public Producto()
        {
        }

        public Producto(string tag, string nombre, int precio, int stock) : this()
        {
            this.tag = tag;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }

        #region Propiedades

        public string Tag
        {
            get { return this.tag; }
            set { this.tag = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }
        #endregion

        public int DisminucionStock(int cantidadVendida)
        {
            int cantidadActual = Stock;
            Stock = cantidadActual - cantidadVendida;

            return Stock;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool result = false;

            if (p1.Tag == p2.Tag && p1.Nombre == p2.Nombre)
            {
                result = true;
            }

            return result;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}