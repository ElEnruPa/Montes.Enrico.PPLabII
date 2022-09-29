using ClassLibrary1;

namespace ConsolaClase8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota = new Mascota("Mascota", 8, "Feminino");

            //Perro cusco = new Perro("Juan", 3, "Masculino");
            //Perro deRaza = new Perro("Pepe", 7, "Femenino", "Caniche");

            mascota.Saludar();

            cusco.Saludar();
            cusco.Ladrar();

            Console.ReadKey();
        }
    }
}