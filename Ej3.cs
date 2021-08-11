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

        private void button1_Click(object sender, EventArgs e)
        {
            String Salida;
            Salida = "Sexo: " + (string)(rbFemenino.Checked ? "Femenino" : "Masculino") +"\r\n";
            Salida += "Estado Civil: " + (string)(rbCasado.Checked ? "Casado" : "Soltero") +"\r\n";
            Salida += "Profesion: " + (string)(lbProfesion.SelectedItems.ToString());
            lblresultado.Text = Salida;
        }
    }
}
