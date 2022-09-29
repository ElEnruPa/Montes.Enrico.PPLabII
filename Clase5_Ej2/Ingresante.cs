using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5_Ej2
{
    internal class Ingresante
    {
        private string nombre;
        private string direccion;
        private string genero;
        private string pais;
        private string[] cursos;
        private int edad;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        public string Saludar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Genero: {this.genero}");
            sb.AppendLine($"Pais: {this.pais}");
            sb.AppendLine($"Cursos:");
            
            foreach(var item in this.cursos)
            {
                if(item != null)
                {
                    sb.AppendLine($"{item}");
                }
            }

            return sb.ToString();
        }

    }
}
