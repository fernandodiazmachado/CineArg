using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class AltaFuncion : Form
    {
        public AltaFuncion()
        {
            InitializeComponent();
        }
        private void AltaFuncion_Load(object sender, EventArgs e)
        {
            CargarComboPelicula();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarComboPelicula()
        {
            DataTable dt = new DataTable();
            dt = Pelicula.Consultar();

            cboPelicula.DisplayMember = "nombre";
            cboPelicula.ValueMember = "idPelicula";
            cboPelicula.DataSource = dt;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void cboPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
