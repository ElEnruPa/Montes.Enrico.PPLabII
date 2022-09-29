namespace BiblioDeClases
{
    public class Usuario
    {
        protected string email;
        protected string contraseña;
        protected int id;

        public Usuario (string mail, string contraseña, int id)
        {
            this.email = mail;
            this.contraseña = contraseña;
            this.id = id;
        }
    }
}