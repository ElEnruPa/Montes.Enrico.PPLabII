using BiblioDeClasesTP1;
using Forms;

namespace Inicio
{
    public partial class FrmInicio : Form
    {
        private Dueño dueñoGlobal = new Dueño();
        private Usuario usuarioVentas = new Usuario();

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

            if(email == "Dueño" && contraseña == "Dueño")
            {
                FrmMenuDueño frmMenuDueño = new FrmMenuDueño(dueñoGlobal, usuarioVentas);
                frmMenuDueño.ShowDialog();
                //this.Close();
            }
            else
            {
                if(email == "Vendedor" && contraseña == "Vendedor")
                {
                    FrmAdministradorDeVentas frmAdministradorDeVentas = new FrmAdministradorDeVentas(dueñoGlobal, usuarioVentas);
                    frmAdministradorDeVentas.ShowDialog();
                    //this.Close();
                }
                else
                {
                    if(email == "Cliente" && contraseña == "Cliente")
                    {
                        FrmContadorVentas frmContadorVentas = new FrmContadorVentas(usuarioVentas);
                        frmContadorVentas.ShowDialog();
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
}
