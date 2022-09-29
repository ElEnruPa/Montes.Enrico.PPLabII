namespace Clase1_Ej7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadEmpleados;
            bool flag;
            string nombre;
            int valorHora;
            int antiguedad;
            int horasTrabajadas;

            Console.Write("Cuantos empleados desea ingresar?: ");
            flag = int.TryParse(Console.ReadLine(), out cantidadEmpleados);

            while (!flag || cantidadEmpleados < 1)
            {
                Console.Write("Ingrese BIEN la cantidad de empleados que desea ingresar?: ");
                flag = int.TryParse(Console.ReadLine(), out cantidadEmpleados);
            }

            for (int i = 1; i <= cantidadEmpleados; i++)
            {
                Console.Write("Ingrese el nombre del empleado n°{0}", i);

            }

            Console.ReadKey();
        }
    }
}