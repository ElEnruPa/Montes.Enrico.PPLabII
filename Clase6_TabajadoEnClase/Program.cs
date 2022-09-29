namespace Clase6_TabajadoEnClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Matrices/ArrayBidimensionales

            int[,] arrayBidimensional = new int[2, 2];
            arrayBidimensional[0, 0] = 1;
            arrayBidimensional[0, 1] = 2;
            arrayBidimensional[1, 0] = 3;
            arrayBidimensional[1, 1] = 4;

            foreach(int i in arrayBidimensional)
            {
                Console.WriteLine(i);
            }

            #endregion

            #region Lista

            List<int> listaEnteros;
            //List<string> listaString;

            listaEnteros = new List<int>();

            listaEnteros.Add(5);
            listaEnteros.Add(5);
            listaEnteros.Add(6);
            listaEnteros.Add(7);
            listaEnteros.Remove(5); //Elimina el PRIMER encuentro de este numero
            listaEnteros.RemoveAll(numero => numero == 7); //Elimina TODOS los 7
            //listaEnteros.Clear(); //Elimina TODA la lista

            foreach(int numeros in listaEnteros) //No modificar el tamaño de la lista dentro del foreach (NO eliminar ni agregar nada adentro del foreach)
            {
                Console.WriteLine(numeros);
            }

            #endregion

            #region Diccionario

            Dictionary<int, string> diccionario = new Dictionary<int, string>(); //<valor que tiene cada celda(key), objecto que tiene cada celda(value)>

            diccionario.Add(1, "Hola");
            diccionario.Add(2, "Como");
            diccionario.Add(3, "Estas");

            foreach(var item in diccionario)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            #endregion

            #region Queue/Cola

            Queue<int> colaNumeros = new Queue<int>();

            colaNumeros.Enqueue(5); //Agrega un numero
            colaNumeros.Enqueue(6); //Agrega un numero
            int numero = colaNumeros.Dequeue(); //Saca el primero y te lo muestra, pero no esta mas en la queue
            int ultimoNumero = colaNumeros.Last();//Saca el ultimo y te lo muestra, pero no esta mas en la queue
            Console.WriteLine(numero + ultimoNumero);

            #endregion

            #region Stack/Pila

            Stack<int> miStack = new Stack<int>();
            
            miStack.Push(5); //Empuja un elemento al final
            int ultimo = miStack.Pop(); //Devuelve el ultimo elemento ingresado

            #endregion

            #region SortedList/ListasOrdenadas

            SortedList<int, string> miSorted = new SortedList<int, string>(); //Es una lista pero te la ordena dependiendo de la key, si es un string te los muestra ordenados alfabeticamnete, si es por numero te lo ordena de manera creciente

            miSorted.Add(3, "Hola1");
            miSorted.Add(43, "Hola2");
            miSorted.Add(76, "Hola3");
            miSorted.Add(1, "Hola4");

            foreach(var item in miSorted)
            {
                Console.WriteLine(item.Value);
            }

            #endregion

            Console.ReadKey();
        }
    }
}