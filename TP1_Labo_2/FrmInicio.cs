using Clases;
using System.Security.Cryptography.X509Certificates;

namespace TP1_Labo_2
{
    public partial class FrmInicio : Form
    {
        private Dueño dueñoForm = new Dueño();
        private Vendedor vendedorForm = new Vendedor();

        public FrmInicio()
        {
            InitializeComponent();
            List<Producto> listaProductos = ListaDefault();
            Dueño dueño = new Dueño("dueño@gmail.com", "Dueño123", listaProductos);
            Vendedor vendedor = new Vendedor("vendedor@gmail.com", "Vendedor123", listaProductos);
            this.dueñoForm = dueño;
            this.vendedorForm = vendedor;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string email;
            string contraseña;

            email = txtEmail.Text;
            contraseña = txtContraseña.Text;

            if (email == dueñoForm.Email && contraseña == dueñoForm.Contraseña)
            {
                FrmMenuDueño frmMenuDueño = new FrmMenuDueño(dueñoForm, vendedorForm);
                frmMenuDueño.ShowDialog();
                //this.Close();
            }
            else
            {
                if (email == vendedorForm.Email && contraseña == vendedorForm.Contraseña)
                {
                    FrmAdministracionDeVentas frmAdministracionDeVentas = new FrmAdministracionDeVentas(vendedorForm);
                    frmAdministracionDeVentas.ShowDialog();
                    //this.Close();
                }
                else
                {
                    if (email == "3" && contraseña == "3")
                    {
                        FrmMostradorVentas frmMostradorVentas = new FrmMostradorVentas(vendedorForm);
                        frmMostradorVentas.ShowDialog();
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

        private void btnDueño_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "dueño@gmail.com";
            txtContraseña.Text = "Dueño123";
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "vendedor@gmail.com";
            txtContraseña.Text = "Vendedor123";
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmMostradorVentas frmMostradorVentas = new FrmMostradorVentas(vendedorForm);
            frmMostradorVentas.ShowDialog();
        }

        private List<Producto> ListaDefault()
        {
            List<Producto> listaDefa = new List<Producto>();

            Producto p1 = new Producto("Computadora Escritorio", "Computadora Oficina", 70000, 50);
            Producto p2 = new Producto("Notebook", "Lenovo 22'", 48000, 100);
            Producto p3 = new Producto("Monitor", "LG 24'", 22000, 40);
            Producto p4 = new Producto("Perifericos", "Mouse Logitech", 3000, 200);
            Producto p5 = new Producto("Silla", "De Oficina", 18000, 70);
            Producto p6 = new Producto("Otros", "Pasta Termica", 800, 1500);
            listaDefa.Add(p1);
            listaDefa.Add(p2);
            listaDefa.Add(p3);
            listaDefa.Add(p4);
            listaDefa.Add(p5);
            listaDefa.Add(p6);

            return listaDefa;
        }

    }
}