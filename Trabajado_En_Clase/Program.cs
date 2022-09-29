namespace Trabajado_En_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1; //(Como si fuese un string, int
            animal1 = new Animal("Pepe", 10, "Rope"); //Reserva espacio en memoria, del tamaño animal (Constructor)

            Animal animal2;
            animal2 = new Animal();

            Console.WriteLine(animal1.Hablar() + "\n");
            Console.WriteLine(animal2.Hablar() + "\n");
            Console.WriteLine(Animal.contadorDeAnimales);

            Console.ReadKey();
        }
    }
}