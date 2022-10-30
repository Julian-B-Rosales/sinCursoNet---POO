using Practica3.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class FormCrear : Form
    {
        public FormCrear()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Autor autor1 = new Autor("Jorge Luis", "Borges", DateTime.Parse("24/08/1899"), "Buenos Aires", "Argentina");

            Titulo titulo1 = new Titulo("Borges, Jorge Luis", "Ficciones", "Literatura Fantastica", 4599.99, "Tapa Dura");

            MessageBox.Show(autor1.ToString());
            MessageBox.Show(titulo1.ToString());
        }
    }
}
