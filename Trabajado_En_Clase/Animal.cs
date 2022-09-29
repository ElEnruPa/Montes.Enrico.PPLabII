using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajado_En_Clase
{
    internal class Animal
    {
        //ATRIBUTOS (caracteristicas - datos) (lowCammelCase)
        public string nombre;
        public int edad;
        public string tipoDeAnimal;
        public static int contadorDeAnimales;

        static Animal() //Contructor estatico
        {
            Animal.contadorDeAnimales = 0;
        }

        public Animal() //Generico sin parametros
        {
            //this.parametro (this es propia de la clase)
            Animal.contadorDeAnimales++;
            this.nombre = "Sin nombre";
            this.edad = 0;
            this.tipoDeAnimal = "Desconocido";
        }

        public Animal(string nombre, int edad, string tipoDeAnimal) //Contructor
        {
            Animal.contadorDeAnimales++;
            this.nombre = nombre;
            this.edad = edad;
            this.tipoDeAnimal = tipoDeAnimal;
        }


        //METODOS (Comportamientos - Acciones - Funciones) (UpperCammelCase)
        public string Hablar()
        {
            StringBuilder sb = new StringBuilder();

            //sb.Append("Mi nombre es ");
            //sb.AppendLine(this.nombre);
            //sb.Append("Y tengo ");
            //sb.Append(this.edad.ToString());
            //sb.AppendLine(" Años");
            //sb.Append("Y soy un ");
            //sb.Append(this.tipoDeAnimal);

            sb.Append($"Mi nombre es {this.nombre}, tengo {this.edad} años y soy un {this.tipoDeAnimal}");

            return sb.ToString();
        }

    }
}
