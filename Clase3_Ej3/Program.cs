using Entidades_Clase3;

namespace Clase3_Ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Juan", "Carlos", "LAM123");
            Estudiante e2 = new Estudiante("Pepe", "Montaner", "LAM456");
            Estudiante e3 = new Estudiante("Moño", "Muiños", "LAM789");

            e1.NotaPrimerParcial = 7;
            e1.NotaSegundoParcial = 8;

            e2.NotaPrimerParcial = 3;
            e2.NotaSegundoParcial = 5;

            e3.NotaPrimerParcial = 6;
            e3.NotaSegundoParcial = 4;

            Console.WriteLine($"{e1.Mostrar()}\n");
            Console.WriteLine($"{e2.Mostrar()}\n");
            Console.WriteLine($"{e3.Mostrar()}\n");

            Console.ReadKey();
        }
    }
}