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
    public partial class Ej3 : Form
    {
        public Ej3()
        {
            InitializeComponent();
        }

        private void cb5_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void btnMostrarSeleccion_Click(object sender, EventArgs e)
        {
            string Salida;
            string checkbox;
            Salida = "Sexo: " + (string)(rbFemenino.Checked ? "Femenino" : "Masculino") + "\r\n";
            Salida += "Estado Civil: " + (string)(rbCasado.Checked ? "Casado" : "Soltero") + "\r\n";
            Salida += "Profesion: ";
            foreach (var li in clbProfesion.CheckedItems)
            {
                checkbox = li.ToString();
                Salida += "\r\n";
                Salida += checkbox;
                lblResultado.Text = Salida;
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
