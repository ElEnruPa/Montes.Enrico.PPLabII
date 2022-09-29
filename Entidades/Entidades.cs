using System.Text;

namespace Entidades
{
    public class Cuenta //Ejercicio 1 Clase 3
    {
        public string titular;
        public float cantidad;

        public Cuenta() //Constructor default
        {
            this.titular = "Sin titular";
            this.cantidad = 0;
        }
        public Cuenta(string titular, float cantidad) //Constructor pasandole parametros 
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetterTitular //Getter
        {
            get { return this.titular;  }
        }

        public float GetterCantidad //Getter
        {
            get { return this.cantidad; }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Esta es la cuenta del titular: {this.titular}");
            sb.AppendLine($"Con esta cantidad de dinero: {this.cantidad}");

            return sb.ToString();
        }

        public bool Ingresar(int montoIngresar)
        {
            bool retorno = false;
            if(montoIngresar >= 0)
            {
                this.cantidad += montoIngresar;
                retorno = true;
            }
            return retorno;
        }

        public bool Retirar(int montoRetirar)
        {
            bool retorno = false;
            if(montoRetirar >= 0)
            {
                this.cantidad -= montoRetirar;
                retorno = true;
            }
            return retorno;
        }

    }
}