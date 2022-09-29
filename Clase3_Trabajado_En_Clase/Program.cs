using Clase4_Ej1;

namespace Clase3_Trabajado_En_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sumador n1 = new Sumador();
            Sumador n2 = new Sumador();

            Console.WriteLine(n1.Sumar(2, 2)); ////Suma 1 en n2
            Console.WriteLine(n2.Sumar("Hola", "como estas")); //Suma 1 en n2
            Console.WriteLine((int)n1); //No suma nada en n1

            Console.WriteLine(n1 + n2); //n1 + n2
            Console.WriteLine(n1 | n2); //Si son iguales o no

            Console.ReadKey();
        }
    }
}