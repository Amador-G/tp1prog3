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
    public partial class Ej2 : Form
    {
        public Ej2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text.Trim().Length > 0 && txtNombre.Text.Trim().Length > 0)
            {
                string aux = txtApellido.Text + " " + txtNombre.Text;
                if (lbApNom.Items.Contains(aux))
                {
                    MessageBox.Show("Duplicado");
                    txtApellido.Clear();
                    txtNombre.Clear();
                    txtNombre.Focus();
                   
                }
                else
                {
                    lbApNom.Items.Add(aux);
                    txtApellido.Clear();
                    txtNombre.Clear();
                    txtNombre.Focus();
                    lbApNom.Sorted = true;
                }

            }
            else
            {
                MessageBox.Show("Debe completar ambos campos para añadir.");
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lbApNom.Items.RemoveAt(lbApNom.SelectedIndex);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Formulario = new frmPrincipal();
            Formulario.Show();
        }
    }
}
