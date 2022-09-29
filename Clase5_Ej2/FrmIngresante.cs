namespace Clase5_Ej2
{
    public partial class FrmIngresante : Form
    {
        public FrmIngresante()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre;
            string direccion;
            string genero;
            string pais;
            string[] cursos;
            int edad;

            nombre = this.txtNombre.Text;
            direccion = this.txtDireccion.Text;
            genero = Genero();
            cursos = Cursos();
            pais = lboxPais.Text;
            edad = (int)nunudEdad.Value;

            Ingresante usuario = new Ingresante(nombre, direccion, genero, pais, cursos, edad);
            MessageBox.Show(usuario.Saludar());
        }

        private string Genero()
        {
            string resultado;

            if(this.rbtnMasculino.Checked)
            {
                resultado = rbtnMasculino.Text;
            }
            else
            {
                if(this.rbtnFemenino.Checked)
                {
                    resultado = rbtnFemenino.Text;
                }
                else
                {
                    resultado = rbtnNoBinario.Text;
                }
            }

            return resultado;
        }

        private string[] Cursos()
        {
            string[] cursos = new string[3];

            if(cboxCSharp.Checked)
            {
                cursos[0] = cboxCSharp.Text;
            }

            if (cboxCMasMas.Checked)
            {
                cursos[1] = cboxCMasMas.Text;
            }

            if(cboxJavaScript.Checked)
            {
                cursos[2] = cboxJavaScript.Text;
            }

            return cursos;
        }
    }
}