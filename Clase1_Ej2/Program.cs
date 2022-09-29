namespace Clase1_Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool flag;

            Console.Write("Ingrese un numero: ");

            flag = int.TryParse(Console.ReadLine(), out numero);

            while (!flag || numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                flag = int.TryParse(Console.ReadLine(), out numero);
            }

            Console.WriteLine("El cuadrado del numero es: {0}", Math.Pow(numero, 2));
            Console.WriteLine("El cubo del numero es: {0}", Math.Pow(numero, 3));

            Console.ReadKey();
        }
    }
}