using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioDeClases
{
    internal class Dueño : Usuario
    {
        private int ganancias;

        public Dueño(string email, string contraseña, int id, int ganancias) : base(email, contraseña, id)
        {
            this.ganancias = ganancias;
        }
    }
}
