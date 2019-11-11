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
    public partial class ModificarDescuentos : Form
    {
        public ModificarDescuentos()
        {
            InitializeComponent();
            Descuento descuento = new Descuento();
            String mensaje = Descuento.ConsultarTabla();
            MessageBox.Show(mensaje);
        }

        private void ModificarDescuentos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
