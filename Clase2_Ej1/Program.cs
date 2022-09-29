namespace Clase2_Ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            int numero;
            int minimo = 0;
            int maximo = 0;
            float promedio = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero entre -100 y 100: ");
                flag = int.TryParse(Console.ReadLine(), out numero);

                while (!flag || !Validador.Validar(numero, -100, 100))
                {
                    Console.Write("Ingrese BIEN un numero entre -100 y 100: ");
                    flag = int.TryParse(Console.ReadLine(), out numero);
                }

                if (i == 0)
                {
                    minimo = numero;
                    maximo = numero;
                    promedio += numero;
                }
                else
                {
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    
                    if(numero > maximo)
                    {
                        maximo = numero;
                    }

                    promedio += numero;
                }
            }

            Console.WriteLine("El numero minimo es: {0}", minimo);
            Console.WriteLine("El numero maximo es: {0}", maximo);
            Console.WriteLine("El promedio es: {0}", promedio / 10);

            Console.ReadKey();

        }
    }
}