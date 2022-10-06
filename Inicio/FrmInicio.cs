using BiblioDeClasesTP1;
using Forms;

namespace Inicio
{
    public partial class FrmInicio : Form
    {
        private Dueño dueñoGlobal = new Dueño();

        public FrmInicio()
        {
            InitializeComponent();
            dueñoGlobal.ListaDefault();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string email;
            string contraseña;

            email = txtEmail.Text;
            contraseña = txtContraseña.Text;

            if(email == "1" && contraseña == "1")
            {
                FrmMenuDueño frmMenuDueño = new FrmMenuDueño(dueñoGlobal);
                frmMenuDueño.ShowDialog();
                //this.Close();
            }
            else
            {
                if(email == "2" && contraseña == "2")
                {
                    FrmAdministradorDeVentas frmAdministradorDeVentas = new FrmAdministradorDeVentas(dueñoGlobal);
                    frmAdministradorDeVentas.ShowDialog();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Ingreso mal el Email o la Contraseña, intentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
                    txtContraseña.Clear();
                }
            }
        }
    }
}