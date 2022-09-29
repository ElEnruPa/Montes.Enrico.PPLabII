using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_TrabajoEnClase
{
    public static class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            //Sello.mensaje = "";
            Sello.mensaje = String.Empty;
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color; //cambia el color 
            Console.WriteLine(Sello.Imprimir()); //imprime
            Console.ResetColor(); //resetea el color
        }

        public static string ArmarFormatoMensaje()
        {
            string asterisco = "";
            string mensajeCambiado = "";
            for (int i = 0; i < Sello.mensaje.Length + 2; i++)
            {
                asterisco += "*";
            }
            mensajeCambiado = asterisco + "\n*" + Sello.mensaje + "*\n" + asterisco;
            return mensajeCambiado;
        }
    }
}
