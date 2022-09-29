namespace Clase1_Ej6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFinal;
            bool validar;

            Console.Write("Ingrese un anio de inicio: ");
            validar = int.TryParse(Console.ReadLine(), out anioInicio);

            while (!validar || anioInicio < 0)
            {
                Console.Write("Ingrese BIEN un anio de inicio: ");
                validar = int.TryParse(Console.ReadLine(), out anioInicio);
            }

            Console.Write("Ingrese un anio final: ");
            validar = int.TryParse(Console.ReadLine(), out anioFinal);

            while (!validar || anioFinal < anioInicio)
            {
                Console.Write("Ingrese BIEN un anio final: ");
                validar = int.TryParse(Console.ReadLine(), out anioFinal);
            }

            while (anioInicio <= anioFinal)
            {
                if ((anioInicio % 4 == 0 && anioInicio % 100 != 0) || (anioInicio % 400 == 0))
                {
                    Console.Write("{0}||", anioInicio);
                }
                anioInicio++;
            }

            Console.ReadKey();
        }
    }
}