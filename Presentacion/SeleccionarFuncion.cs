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
    public partial class SeleccionarFuncion : Form
    {
        public SeleccionarFuncion()
        {
            InitializeComponent();
        }

        private void SeleccionarFuncion_Load(object sender, EventArgs e)
        {
            Utils.CargarCombo(cboPelicula, "Pelicula");
            Utils.CargarCombo(cboTipoSala, "TipoSala");
            dgvFunciones.AutoGenerateColumns = false;
            chkFecha.Checked = true;
            ConsultarFuncion();
        }

        private void ConsultarFuncion()
        {
            DataTable dt = new DataTable();
            Funcion funcion = new Funcion();
            funcion.IdPelicula = Convert.ToInt32(cboPelicula.SelectedValue);
            funcion.IdTipoSala = Convert.ToInt32(cboTipoSala.SelectedValue);
            funcion.FechaProy = chkFecha.Checked ? (DateTime?)null : Convert.ToDateTime(dtpFecha.Value.Date);
            dt = Funcion.Consultar(funcion);
            dgvFunciones.DataSource = dt;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarFuncion();
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
                dtpFecha.Enabled = chkFecha.Checked ? false : true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
