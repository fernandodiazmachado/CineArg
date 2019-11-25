using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form pelicula = new AltaPelicula();
            pelicula.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form descuento = new ModificarDescuentos();
            descuento.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form funcion = new AltaFuncion();
            funcion.Show();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Form funcion = new SeleccionarFuncion();
            funcion.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
