using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ej2
{
    internal class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            bool devuelve = false;

            if(respuesta == "S" || respuesta == "s")
            {
                devuelve = true;
            }

            return devuelve;
        }
    }
}
