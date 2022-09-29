namespace Clase1_Ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorNumerosPerfectos = 0;
            int sumaDivisores = 0;

            Console.WriteLine("Los primeros 4 numeros perfectos son: ");

            while (contadorNumerosPerfectos != 4)
            {
                for (int i = 1; contadorNumerosPerfectos != 4; i++)
                {
                    sumaDivisores = 0;
                    for (int j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            sumaDivisores += j;
                        }
                    }

                    if (sumaDivisores == i)
                    {
                        Console.WriteLine("{0}", i);
                        contadorNumerosPerfectos++;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}