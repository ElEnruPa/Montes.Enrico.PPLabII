namespace Clase5_Form
{
    public partial class FrmMiForm : Form
    {
        public FrmMiForm()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = this.txtNombre.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Esta vacio el nombre","ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Hola {nombre} bienvenido", "BIENVENIDOS", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void btmSaludarForm_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = this.txtNombre.Text;

            FrmSaludar frmSaludar = new FrmSaludar(nombre); //Instanciar un objeto
            if(frmSaludar.ShowDialog() == DialogResult.OK) // Muestra el otro formulario, crea un formulario a partir de otro //.Show tmb funca
            {
                MessageBox.Show("Usted acepta su nombre");
            }
            else
            {
                MessageBox.Show("No le gusta su nombre");
            }
        }
    }
}