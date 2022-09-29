namespace Clase2_Ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primerOperando;
            int segundoOperando;
            float resultado;
            string operador;
            bool flag;

            Console.Write("Elija el primer operando: ");
            flag = int.TryParse(Console.ReadLine(), out primerOperando);
            while (!flag)
            {
                Console.Write("Ingrese BIEN el numero: ");
                flag = int.TryParse(Console.ReadLine(), out primerOperando);
            }

            Console.Write("Elija el segundo operando: ");
            flag = int.TryParse(Console.ReadLine(), out segundoOperando);
            while (!flag)
            {
                Console.Write("Ingrese BIEN el numero: ");
                flag = int.TryParse(Console.ReadLine(), out segundoOperando);
            }

            Console.Write("Ingrese el operador (+,-,*,/): ");
            operador = Console.ReadLine();
            while (operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                Console.WriteLine("Ingrese un operador VALIDO (+,-,*,/): ");
                operador = Console.ReadLine();
            }
            resultado = Calculadora.Calcular(primerOperando, segundoOperando, operador); //Me falto hacer el puntero del segundo numero cuando es 0 asi cambia

            Console.WriteLine($"{primerOperando} {operador} {segundoOperando} = {resultado}");

            Console.ReadKey();
        }
    }
}