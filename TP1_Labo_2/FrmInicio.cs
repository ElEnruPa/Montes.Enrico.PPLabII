using Clases;
using System.Security.Cryptography.X509Certificates;

namespace TP1_Labo_2
{
    public partial class FrmInicio : Form
    {
        private Dueño dueñoForm;
        private Vendedor vendedorForm;
        private Contador contadorForm;
        private List<Proveedor> listaProveedoresForm = new List<Proveedor>();

        public FrmInicio()
        {
            InitializeComponent();
            List<Producto> listaProductos = ListaDefault();
            List<Producto> listaVentas = new List<Producto>();
            Dueño dueño = new Dueño("dueño@gmail.com", "Dueño123", listaProductos);
            Vendedor vendedor = new Vendedor("vendedor@gmail.com", "Vendedor123", listaProductos);
            Contador contador = new Contador("contador@gmail.com", "Contador123", listaVentas);
            Proveedor p1 = new Proveedor("Enrico Inc.", 12345, ListaProveedor1());
            Proveedor p2 = new Proveedor("Carlos Inc.", 67890, ListaProveedor2());
            this.dueñoForm = dueño;
            this.vendedorForm = vendedor;
            this.contadorForm = contador;
            listaProveedoresForm.Add(p1);
            listaProveedoresForm.Add(p2);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string email;
            string contraseña;

            email = txtEmail.Text;
            contraseña = txtContraseña.Text;

            if (email == dueñoForm.Email && contraseña == dueñoForm.Contraseña)
            {
                FrmMenuDueño frmMenuDueño = new FrmMenuDueño(dueñoForm, vendedorForm, contadorForm, listaProveedoresForm);
                frmMenuDueño.ShowDialog();
                //this.Close();
            }
            else
            {
                if (email == vendedorForm.Email && contraseña == vendedorForm.Contraseña)
                {
                    FrmAdministracionDeVentas frmAdministracionDeVentas = new FrmAdministracionDeVentas(vendedorForm, contadorForm);
                    frmAdministracionDeVentas.ShowDialog();
                    //this.Close();
                }
                else
                {
                    if (email == contadorForm.Email && contraseña == contadorForm.Contraseña)
                    {
                        FrmMostradorVentas frmMostradorVentas = new FrmMostradorVentas(contadorForm);
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

        private void btnContador_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "contador@gmail.com";
            txtContraseña.Text = "Contador123";
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

        private List<Producto> ListaProveedor1()
        {
            List<Producto> listaDefa = new List<Producto>();

            Producto p1 = new Producto("Computadora Escritorio", "Computadora Gamer", 170000, 20);
            Producto p2 = new Producto("Notebook", "HP 24'", 58000, 120);
            Producto p3 = new Producto("Monitor", "Samsung 28'", 62000, 90);
            Producto p4 = new Producto("Perifericos", "Mouse Logitech", 3000, 100);
            Producto p5 = new Producto("Silla", "Gamer", 88000, 160);
            Producto p6 = new Producto("Otros", "Pasta Termica", 800, 700);
            listaDefa.Add(p1);
            listaDefa.Add(p2);
            listaDefa.Add(p3);
            listaDefa.Add(p4);
            listaDefa.Add(p5);
            listaDefa.Add(p6);

            return listaDefa;
        }

        private List<Producto> ListaProveedor2()
        {
            List<Producto> listaDefa = new List<Producto>();

            Producto p1 = new Producto("Notebook", "Razer Ultra", 248000, 30);
            Producto p2 = new Producto("Monitor", "Zowie 240hz", 262000, 80);
            Producto p3 = new Producto("Perifericos", "Mouse Normal", 3000, 600);
            Producto p4 = new Producto("Otros", "Cable USB", 1700, 1000);
            listaDefa.Add(p1);
            listaDefa.Add(p2);
            listaDefa.Add(p3);
            listaDefa.Add(p4);

            return listaDefa;
        }
    }
}