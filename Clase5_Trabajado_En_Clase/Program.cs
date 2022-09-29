using Biblio_Clases_Clase5;

namespace Clase5_Trabajado_En_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new Empleado();
            Empleado e2 = new Empleado("Pepe");
            Empleado e3 = new Empleado("Juan", 125, 40000);


            Console.ReadKey();
        }
    }
}