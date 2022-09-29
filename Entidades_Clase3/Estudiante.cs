using System.Text;

namespace Entidades_Clase3
{
    public class Estudiante
    {
        #region Atributos

        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;

        #endregion

        #region Constructores

        static int RandomGenerador()
        {
            Random generador = new Random();
            int numero = generador.Next(6,11);

            return numero;
        }

        public Estudiante()
        {
            this.apellido = "NN";
            this.legajo = "NN";
            this.nombre = "NN";
            this.notaPrimerParcial = 0;
            this.notaSegundoParcial = 0;
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        #endregion

        #region Propiedades

        public int NotaPrimerParcial
        {
            set { this.notaPrimerParcial = value; }
        }

        public int NotaSegundoParcial
        {
            set { this.notaSegundoParcial = value; }
        }

        #endregion

        #region Metodos

        private float CalcularPromedio()
        {
            return ((float)this.notaPrimerParcial + (float)this.notaSegundoParcial) / 2;
        }

        public float CalcularNotaFinal()
        {
            float final = -1;

            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                final = RandomGenerador();
            }

            return final;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Alumno: {this.nombre}, {this.apellido}, {this.legajo}");
            sb.AppendLine($"Notas: 1er parcial: {this.notaPrimerParcial}, 2do parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"La nota promedio es: {CalcularPromedio()}");
            sb.Append("Nota final: ");

            if(CalcularNotaFinal() == -1)
            {
                sb.Append("Alumno desaprobado.");
            }
            else
            {
                sb.Append($"{CalcularNotaFinal()}");
            }

            return sb.ToString();
        }

        #endregion
    }
}