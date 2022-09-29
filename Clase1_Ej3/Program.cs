namespace Clase1_Ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seguir;
            do
            {
                Console.Clear();
                int numero;
                int contador = 0;
                string msjSalida;
                bool flag;

                Console.Write("Hasta que numero primo quiere ver: ");

                flag = int.TryParse(Console.ReadLine(), out numero);

                while (!flag || numero <= 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número! o ingrese \"salir\"");
                    msjSalida = (Console.ReadLine());

                    if (msjSalida == "salir")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        flag = int.TryParse(msjSalida, out numero);
                    }
                }

                Console.WriteLine("Los numero primos del 0 al {0} son:", numero);

                for (int i = 1; i <= numero; i++)
                {
                    contador = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            contador++;
                        }
                    }
                    if (contador == 2)
                    {
                        Console.WriteLine("{0}", i);
                    }
                }

                Console.Write("Desea hacerlo otra vez? (Si=\"s\")");
                seguir = Console.ReadLine();

            } while (seguir == "s");

            Console.ReadKey();
        }
    }
}