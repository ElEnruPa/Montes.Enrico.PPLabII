using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Clase5_Ej1
{
    public partial class FrmSaludarEj1 : Form
    {
        public FrmSaludarEj1()
        {
            InitializeComponent();
        }

        public FrmSaludarEj1(string nombre, string apellido) : this()
        {
            this.lblSaludo.Text = $"Soy {nombre} {apellido}.";
        }
        public FrmSaludarEj1(string nombre, string apellido, string materia) : this(nombre, apellido)
        {
            this.lblSaludo.Text = $"Soy {nombre} {apellido} y mi materia favorita es {materia}.";
        }
    }
}
