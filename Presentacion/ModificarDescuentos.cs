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
        private int descuentoMax1;
        private int descuentoMax2;
        private int descuentoMax3;
        private int descuentoMax4;
        public ModificarDescuentos()
        {
            InitializeComponent();
        }

        private void ModificarDescuentos_Load(object sender, EventArgs e)
        {
            CargarComboTipoDescuento();
            ObtenerDescuentosMaximosActuales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Descuento descuento = new Descuento();
            descuento.IdDescuentos = Convert.ToInt32(cboTipoDescuento.SelectedValue);
            descuento.Porcentaje = Convert.ToInt32(txtDescuento.Text);
            
            if (ValidarDescuento(descuento.IdDescuentos))
            {
                string mensaje = Descuento.Modificar(descuento);
                ObtenerDescuentosMaximosActuales();
                MessageBox.Show(mensaje);
            }
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

        private bool ValidarDescuento(int id)
        {
            int descAcual = Descuento.ConsultarPorcentaePorId(id);
            int descValidar;
            bool guardar = true;

            if (id == 1) 
            {
                descValidar = descuentoMax1 - descAcual + Convert.ToInt32(txtDescuento.Text);
                if (descValidar > 99)
                    return MostrarConfirmacion(); 

                descValidar = descuentoMax2 - descAcual + Convert.ToInt32(txtDescuento.Text);
                if (descValidar > 99)
                    return MostrarConfirmacion();

                descValidar = descuentoMax3 - descAcual + Convert.ToInt32(txtDescuento.Text);
                if (descValidar > 99)
                    return MostrarConfirmacion();

                descValidar = descuentoMax4 - descAcual + Convert.ToInt32(txtDescuento.Text);
                if (descValidar > 99)
                    return MostrarConfirmacion();
            }

            return guardar;

        }

        private bool MostrarConfirmacion()
        {
            bool guardar = true;
                DialogResult dialogResult = MessageBox.Show("Confirmar", "La suma de descuentos supera el 100%. Desea continuar?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    guardar = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    guardar = false;
                    this.Close();
                }
            return guardar;
        }

        private void ObtenerDescuentosMaximosActuales()
        {
            descuentoMax1 = Descuento.ObtenerDescuentoMaximo(1);
            descuentoMax2 = Descuento.ObtenerDescuentoMaximo(2);
            descuentoMax3 = Descuento.ObtenerDescuentoMaximo(3);
            descuentoMax4 = Descuento.ObtenerDescuentoMaximo(4);
        }
    }
}
