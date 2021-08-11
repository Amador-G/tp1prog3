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
    public partial class Ej1 : Form
    {
        public Ej1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            string Nombre, aux;
            bool Existe = false;
            Nombre = Convert.ToString(txtNombre.Text);
            aux = Nombre.ToUpper();

            for (int i = 0; i < lbNombres.Items.Count; i++)
            {
                if (aux == lbNombres.Items[i].ToString().ToUpper())
                {
                    Existe = true;
                }
            }
        
            
            if (Existe == true)
            {
                MessageBox.Show("El nombre ya existe. Ingrese uno nuevo", "Atencion");
                txtNombre.Clear();
                txtNombre.Focus();
            }
            else
            {
                lbNombres.Items.Add(Nombre);
                txtNombre.Clear();
                txtNombre.Focus();

            }



        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0)
            {
                //saco el color porque se pone en rojo cuando uno selecciona los items para moverlos de un lado a otro y queda feo.
               // txtNombre.BackColor = Color.Red;
                btnAgregar.Enabled = false;
            }
            else
            {
               // txtNombre.BackColor = SystemColors.Window;
                btnAgregar.Enabled = true;
            }
        }

        private void btnMoverSel_Click(object sender, EventArgs e)
        {
            string Item = lbNombres.SelectedItem.ToString();
            lbNombres.Items.RemoveAt(lbNombres.SelectedIndex);
            lbMovidos.Items.Add(Item);
        }

        private void btnMoverTodos_Click(object sender, EventArgs e)
        {

            lbMovidos.Items.AddRange(lbNombres.Items);
            lbNombres.Items.Clear();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Formulario = new frmPrincipal();
            Formulario.Show();
        }
    }
}
