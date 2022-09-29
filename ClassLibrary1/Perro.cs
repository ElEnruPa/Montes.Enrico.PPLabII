using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioDeClases8
{
    public class Perro : Mascota
    {
        private string raza;

        public Perro(string nombre, int patas, string sexo) : base(nombre, patas, sexo)
        {
            this.raza = "Desconocida";
        }

        public Perro(string nombre, int patas, string sexo, string raza) : this(nombre, patas, sexo)
        {
            this.raza = raza;
        }

        public string Ladrar()
        {
            //base.Saludar();
            return this.nombre + " GUAG";
        }

        public class Cachorro : Perro
        {
            public Cachorro(string nombre, int patas, string sexo) :base(nombre, patas, sexo)
            {

            }
        }
    }
}
