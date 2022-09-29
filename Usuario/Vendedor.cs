using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioDeClases
{
    internal class Vendedor : Usuario
    {
        private int salario;

        public Vendedor(string email, string contraseña, int id, int salario) : base(email, contraseña, id)
        {
            this.salario = salario;
        }
    }
}
