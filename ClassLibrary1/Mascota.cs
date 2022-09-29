namespace ClassLibrary1
{
    public class Mascota
    {
        protected string nombre; //protected las heredan los hijos las variables 
        protected int patas;
        protected string sexo;

        public string Nombre
        {
            get { return nombre; }
            set { this.Nombre = value; }
        }

        public Mascota(string nombre, int patas, string sexo)
        {
            this.nombre = nombre;
            this.patas = patas;
            this.sexo = sexo;
        }

        public string Saludar()
        {
            return "Hola soy " + this.nombre;
        }
    }
}