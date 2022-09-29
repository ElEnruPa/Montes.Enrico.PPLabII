using System;
using Clase2_Ej1;

namespace Clase2_Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int suma = 0;
            do
            {
                int numero;
                bool Flag;

                Console.Write("Ingrese un numero: ");
                Flag = int.TryParse(Console.ReadLine(), out numero);

                while (!Flag || numero <= 0)
                {
                    Console.Write("Ingrese BIEN un numero: ");
                    Flag = int.TryParse(Console.ReadLine(), out numero);
                }

                suma += numero;

                Console.Write("Desea continuar escribiendo un numero? (S/N)");
                respuesta = Console.ReadLine();

            } while (Validador.ValidarRespuesta(respuesta));

            Console.WriteLine("La suma de los numeros es: {0}", suma);

            Console.ReadKey();
        }
    }
}