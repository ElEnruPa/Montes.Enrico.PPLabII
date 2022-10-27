using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Usuario
    {
        private protected string email;
        private protected string contraseña;
        private protected List<Producto> listaProductos;

        public Usuario()
        {
        }

        public Usuario(string email, string contraseña) : this()
        {
            this.email = email;
            this.contraseña = contraseña;
        }

        public Usuario(string email, string contraseña, List<Producto> listaProductos) : this(email, contraseña)
        {
            this.listaProductos = listaProductos;
        }

        public abstract string Email
        {
            get;
            set;
        }

        public abstract string Contraseña
        {
            get;
            set;
        }

        public abstract List<Producto> ListaProductos
        {
            get;
            set;
        }

    }
}
