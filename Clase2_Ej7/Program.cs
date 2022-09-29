namespace Clase2_Ej7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            double basee;
            double altura;

            Console.Write("Ingrese la base del triangulo: ");
            flag = double.TryParse(Console.ReadLine(), out basee);

            while(!flag || basee < 0)
            {
                Console.Write("Ingrese BIEN la base del triangulo: ");
                flag = double.TryParse(Console.ReadLine(), out basee);
            }

            Console.Write("Ingrese la altura del triangulo: ");
            flag = double.TryParse(Console.ReadLine(), out altura);

            while (!flag || altura < 0)
            {
                Console.Write("Ingrese BIEN la altura del triangulo: ");
                flag = double.TryParse(Console.ReadLine(), out altura);
            }

            Console.WriteLine($"La hipotenusa del triangulo es: {Pitagoras.Hipotenusa(basee, altura)} ");

            Console.ReadKey();
        }
    }
}