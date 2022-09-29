using System.Text;

namespace Clase5_Ej1
{
    public partial class FormsHola : Form
    {
        public FormsHola()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string materia;
            nombre = this.txtNombre.Text;
            apellido = this.txtApellido.Text;
            materia = this.cboMateria.Text;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Se deben completar los siguientes campos:");

            if(string.IsNullOrEmpty(nombre))
            {
                sb.AppendLine("Nombre");
            }

            if(string.IsNullOrEmpty(apellido))
            {
                sb.AppendLine("Apellido");
            }

            if(string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmSaludarEj1 frmSaludarEj1 = new FrmSaludarEj1(nombre, apellido, materia); //Instancia el objeto
                frmSaludarEj1.ShowDialog(); //Lo muestra
            }
        }
    }
}