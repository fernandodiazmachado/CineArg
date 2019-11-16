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
            CargarComboSala();
            CargarComboIdioma();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            private void CargarComboPelicula()
        {
            DataTable dt = new DataTable();
            dt = Pelicula.Consultar();

            cboPelicula.DisplayMember = "nombre";
            cboPelicula.ValueMember = "idPelicula";
            cboPelicula.DataSource = dt;
        }

        private void CargarComboSala()
        {
            DataTable dt = new DataTable();
            dt = Sala.Consultar();

            cboSala.DisplayMember = "descripcion";
            cboSala.ValueMember = "idSalas";
            cboSala.DataSource = dt;
        }

        private void CargarComboIdioma()
        {
            DataTable dt = new DataTable();
            dt = Idioma.Consultar();

            cboIdioma.DisplayMember = "descripcion";
            cboIdioma.ValueMember = "idIdioma";
            cboIdioma.DataSource = dt;
        }

        private void cboPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Funcion funcion = new Funcion();
            funcion.IdPelicula = Convert.ToInt32(cboPelicula.SelectedValue);
            funcion.IdSala = Convert.ToInt32(cboSala.SelectedValue);
            funcion.IdIdioma = Convert.ToInt32(cboIdioma.SelectedValue);
            funcion.FechaProy = fechaYHora();

            string mensaje = Funcion.Agregar(funcion);
            MessageBox.Show(mensaje); 
        }

        private DateTime fechaYHora()
        {
            DateTime fecha = Convert.ToDateTime(dtpFecha.Value.Date);
            DateTime hora = Convert.ToDateTime(dtpHora.Value);
            DateTime fechaConvertida = fecha.AddHours(hora.Hour).AddMinutes(hora.Minute).AddSeconds(hora.Second);
            return fechaConvertida;
        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public bool ShowUpDown { get; set; }
        private void dtpHora_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
