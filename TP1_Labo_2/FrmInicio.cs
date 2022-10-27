using Clases;
using System.Security.Cryptography.X509Certificates;

namespace TP1_Labo_2
{
    public partial class FrmInicio : Form
    {
        private Due�o due�oForm = new Due�o();
        private Vendedor vendedorForm = new Vendedor();
        private Cliente clienteForm = new Cliente();

        public FrmInicio()
        {
            InitializeComponent();
            List<Producto> listaProductos = ListaDefault();
            List<Producto> listaVentas = new List<Producto>();
            Due�o due�o = new Due�o("due�o@gmail.com", "Due�o123", listaProductos);
            Vendedor vendedor = new Vendedor("vendedor@gmail.com", "Vendedor123", listaProductos);
            Cliente cliente = new Cliente("cliente@gmail.com", "Cliente123", listaVentas);
            this.due�oForm = due�o;
            this.vendedorForm = vendedor;
            this.clienteForm = cliente;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string email;
            string contrase�a;

            email = txtEmail.Text;
            contrase�a = txtContrase�a.Text;

            if (email == due�oForm.Email && contrase�a == due�oForm.Contrase�a)
            {
                FrmMenuDue�o frmMenuDue�o = new FrmMenuDue�o(due�oForm, vendedorForm, clienteForm);
                frmMenuDue�o.ShowDialog();
                //this.Close();
            }
            else
            {
                if (email == vendedorForm.Email && contrase�a == vendedorForm.Contrase�a)
                {
                    FrmAdministracionDeVentas frmAdministracionDeVentas = new FrmAdministracionDeVentas(vendedorForm, clienteForm);
                    frmAdministracionDeVentas.ShowDialog();
                    //this.Close();
                }
                else
                {
                    if (email == clienteForm.Email && contrase�a == clienteForm.Contrase�a)
                    {
                        FrmMostradorVentas frmMostradorVentas = new FrmMostradorVentas(clienteForm);
                        frmMostradorVentas.ShowDialog();
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ingreso mal el Email o la Contrase�a, intentelo nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Clear();
                        txtContrase�a.Clear();
                    }
                }
            }
        }

        private void btnDue�o_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "due�o@gmail.com";
            txtContrase�a.Text = "Due�o123";
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "vendedor@gmail.com";
            txtContrase�a.Text = "Vendedor123";
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "cliente@gmail.com";
            txtContrase�a.Text = "Cliente123";
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