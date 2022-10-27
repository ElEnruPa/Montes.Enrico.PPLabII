namespace Clases
{
    public class Producto
    {
        #region Atributos

        private string tag;
        private string nombre;
        private int precio;
        private int stock;
        private static List<string> tags;

        #endregion

        #region Constructores

        static Producto()
        {
            tags = new List<string>();
            tags.Add("Computadora Escritorio");
            tags.Add("Notebook");
            tags.Add("Monitor");
            tags.Add("Perifericos");
            tags.Add("Silla");
            tags.Add("Otros");
        }

        public Producto ()
        { 
        }

        public Producto(string tag, string nombre, int precio, int stock) : this ()
        {
            this.tag = tag;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }

        #endregion

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

        #region Metodos

        public int DisminucionStock(int cantidadVendida)
        {
            int cantidadActual = Stock;
            Stock = cantidadActual - cantidadVendida;

            return Stock;
        }

        #endregion

        #region Operadores

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

        #endregion

    }
}