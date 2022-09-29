using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ej4
{
    internal class Calculadora
    {
        public static float Calcular(int primerNumero, int segundoNumero, string operador)
        {
            float numero = 0;
            bool flag;
            switch(operador)
            {
                case "+":
                    numero = primerNumero + segundoNumero;
                    break;

                case "-":
                    numero = primerNumero - segundoNumero;
                    break;

                case "*":
                    numero = primerNumero * segundoNumero;
                    break;

                case "/":
                    while(!Validar(segundoNumero))
                    {
                        Console.Write("No se puede divir por 0, elija otro numero: ");
                        flag = int.TryParse(Console.ReadLine(), out segundoNumero);
                    }
                    numero = primerNumero / (float)segundoNumero;
                    break;
            }

            return numero;
        }

        private static bool Validar(int segundoNumero)
        {
            bool validar = false;

            if (segundoNumero != 0)
            {
                validar = true;
            }
            return validar;
        }
    }
}
