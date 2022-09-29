namespace Clase1_Ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumero = new int[5]; //asi se declara un array // reserva memoria en "new (tipo)[cantidad a reservar]"
            int maximo = 0;
            int minimo = 0;
            float promedio = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Escribe un numero: ");
                arrayNumero[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    maximo = arrayNumero[i];
                    minimo = arrayNumero[i];
                }
                else
                {
                    if (arrayNumero[i] < minimo)
                    {
                        minimo = arrayNumero[i];
                    }
                    if (arrayNumero[i] > maximo)
                    {
                        maximo = arrayNumero[i];
                    }
                }

                promedio += arrayNumero[i];
            }

            Console.WriteLine("El numero minimo es: {0}", minimo);
            Console.WriteLine("El numero maximo es: {0}", maximo);
            Console.WriteLine("El promedio es: {0}", promedio / 5);

            Console.ReadKey();
        }
    }
}