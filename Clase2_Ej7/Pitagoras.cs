using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ej7
{
    internal class Pitagoras
    {
        public static double Hipotenusa(double basee, double altura)
        {
            double resultado;
            
            basee = Math.Pow(basee, 2);
            altura = Math.Pow(altura, 2);

            resultado = Math.Sqrt(basee + altura);
            return resultado;
        }
    }
}
