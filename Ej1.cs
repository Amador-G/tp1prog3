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


            if (Existe)
            {
                MessageBox.Show("El nombre ya existe. Ingrese uno nuevo", "Atencion");
                txtNombre.Clear();
                txtNombre.Focus();
            }
            else
            {
                if (aux.Trim().Length == 0)
                {
                    MessageBox.Show("No puede agregar dato en blanco. Ingrese un dato", "Atencion");
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



        }

        private void btnMoverSel_Click(object sender, EventArgs e)
        {
            bool estado;
            estado = ValidacionClick();


            if (estado)
            {
                string Item = lbNombres.SelectedItem.ToString();
                lbNombres.Items.RemoveAt(lbNombres.SelectedIndex);
                lbMovidos.Items.Add(Item);
                txtNombre.Focus();
            }
        }


        private bool ValidacionClick()
        {
            bool estado = true;
            try
            {
                string Item = lbNombres.SelectedItem.ToString();
            }
            catch (NullReferenceException fe)
            {
                DialogResult dialogResult = MessageBox.Show(fe.Message);
                _ = dialogResult;
                estado = false;
                // throw;
                txtNombre.Focus();
            }

            return estado;
        }

        private void btnMoverTodos_Click(object sender, EventArgs e)
        {
            lbMovidos.Items.AddRange(lbNombres.Items);
            lbNombres.Items.Clear();

        }
    }
}
