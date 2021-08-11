using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Nº1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Formulario;
            Formulario = new Ej1();
            Formulario.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Formulario;
            Formulario = new Ej2();
            Formulario.Show();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Formulario;
            Formulario = new Ej3();
            Formulario.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
