using BiblioDeClasesTP1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmMostradorVentas : Form
    {
        private Dueño dueñoLocal = new Dueño();

        public FrmMostradorVentas(Dueño dueñoGlobal)
        {
            InitializeComponent();
            dueñoLocal = dueñoGlobal;
        }
    }
}
