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
        }

        private void ModificarDescuentos_Load(object sender, EventArgs e)
        {
            CargarComboTipoDescuento();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Descuento descuento = new Descuento();
            descuento.IdDescuentos = Convert.ToInt32(cboTipoDescuento.SelectedValue);
            descuento.Porcentaje = Convert.ToInt32(txtDescuento.Text);
            Descuento.Modificar(descuento);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarComboTipoDescuento()
        {
            DataTable dt = new DataTable();
            dt = Descuento.Consultar();

            cboTipoDescuento.DisplayMember = "detalle";
            cboTipoDescuento.ValueMember = "idDescuentos";
            cboTipoDescuento.DataSource = dt;
        }

        private void cboTipoDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idDescuento = Convert.ToInt32(cboTipoDescuento.SelectedValue);
            txtDescuento.Text = Descuento.ConsultarPorcentaePorId(idDescuento).ToString();
        }
    }
}
