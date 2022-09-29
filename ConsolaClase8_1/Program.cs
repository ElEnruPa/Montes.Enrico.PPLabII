using BiblioDeClases8;
using ClassLibrary1;

namespace ConsolaClase8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota = new Mascota("Mascota", 1, "Femenino");

            Perro cusco = new Perro("Coco", 3, "Masculino");
            Perro deRaza = new Perro("Razin", 5, "Femenino", "Caniche");

            Console.WriteLine(mascota.Saludar());

            Console.WriteLine(cusco.Saludar());
            Console.WriteLine(cusco.Ladrar());


            Console.ReadKey();
        }
    }
}