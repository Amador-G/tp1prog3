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
                string ApellidoNombre = txtApellido.Text + " " + txtNombre.Text;
                string aux = ApellidoNombre.ToUpper();

                if (verificacionNombreAp(aux) == true)
                {
                    lbApNom.Items.Add(ApellidoNombre);
                }


                txtApellido.Clear();
                txtNombre.Clear();
                txtNombre.Focus();
                lbApNom.Sorted = true;
            }
            else
            {
                MessageBox.Show("Debe completar ambos campos para añadir.");
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bool estado;
            estado = ValidacionBorrar();

            if (estado)
            {
                MessageBox.Show("Elemento borrado exitosamente", "atencion");
            }
            
        }

        private bool ValidacionBorrar()
        {
            bool estado = true;

            try
            {
                lbApNom.Items.RemoveAt(lbApNom.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException fe)
            {
                MessageBox.Show(fe.Message);
                //  throw;
                estado = false;
            }

            return estado;
        }


        private bool verificacionNombreAp(string aux)
        {
            bool Existe = false;
            for (int i = 0; i < lbApNom.Items.Count; i++)
            {
                if (aux == lbApNom.Items[i].ToString().ToUpper())
                {
                    Existe = true;
                }


            }
            if (Existe == true)
            {
                MessageBox.Show("Esa persona ya fue ingresada anteriormente, por favor ingrese una nueva persona", "Atencion");
                txtApellido.Clear();
                txtNombre.Clear();
                txtNombre.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Formulario;
            Formulario = new frmPrincipal();
            Formulario.Show();
        }
    }
}
