using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ej1
{
    internal class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool validacion = false;

            if(valor >= min && valor <= max)
            {
                validacion = true;
            }

            return validacion;

            //return valor >= min && valor <= max;
        }
    }
}
