namespace Biblio_Clases_Clase5
{
    public class Empleado
    {
        #region Atributos

        private string nombre;
        private int legajo;
        private float sueldo;

        #endregion

        #region Constructores
        public Empleado()
        {
            this.nombre = "NN";
            this.legajo = 0;
            this.sueldo = 0;
        }

        public Empleado(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Empleado(string nombre, int legajo, float sueldo) : this(nombre)
        {
            this.legajo = legajo;
            this.sueldo = sueldo;
        }

        #endregion

        #region Propiedades

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Legajo
        {
            get { return this.legajo; }
            set { this.Legajo = value; }
        }

        public float Sueldo
        {
            get { return this.sueldo; }
            set { this.Sueldo = value; }
        }

        #endregion

        #region Metodos

        public string Saludar()
        {
            return $"Hola soy {this.nombre} y mi legajo es {this.Legajo} y estoy saludando a todos";
        }

        public string Saludar(string nombre)
        {
            return $"Hola soy {this.nombre} y mi legajo es {this.Legajo} y estoy saludando a {nombre}";
        }

        public string Saludar(int veces)
        {
            string cadena = "";

            for(int i=0; i < veces; i++)
            {
                cadena += $"{this.nombre} ";
            }

            return cadena;
        }

        #endregion

        #region Operadores

        public static bool operator ==(Empleado e1, Empleado e2)
        {
            bool result = false;

            if(e1.nombre == e2.nombre && e1.legajo == e2.legajo)
            {
                result = true;
            }

            return result;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        #endregion
    }
}