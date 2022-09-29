namespace Clase1_Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;
            bool validacion;
            string estrellita = "*";

            Console.Write("Ingrese la altura del triangulo: ");
            validacion = int.TryParse(Console.ReadLine(), out altura);

            while (!validacion || altura < 1)
            {
                Console.Write("Ingrese BIEN la altura del triangulo");
                validacion = int.TryParse(Console.ReadLine(), out altura);
            }

            for (int i = 0; i < altura; i++)
            {
                Console.Write(estrellita);
                for (int j = 0; j < i; j++)
                {
                    Console.Write(estrellita + estrellita);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}