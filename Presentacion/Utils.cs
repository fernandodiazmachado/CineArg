using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Negocio;

namespace Presentacion
{
    public class Utils
    {
        public static void CargarCombo(ComboBox comboBox, string clase)
        {
            DataTable dt = new DataTable();

            Type t = clase.GetType();
            if (clase == "Pelicula")
                CargarComboPelicula(comboBox);
            else if (clase == "Descuento")
                dt = Descuento.Consultar();
            else if (clase == "Idioma")
                dt = Idioma.Consultar();
            else if (clase == "Sala")
                dt = Sala.Consultar();
            else if (clase == "TipoSala")
                CargarComboTipoSala(comboBox);
            else
                dt = null;
        }

        private static void CargarComboPelicula(ComboBox comboBox)
        {
            DataTable dt = new DataTable();
            dt = Pelicula.CargarComboPelicula();

            comboBox.DisplayMember = "nombre";
            comboBox.ValueMember = "idPelicula";
            comboBox.DataSource = dt;
        }

        private static void CargarComboTipoSala(ComboBox comboBox)
        {
            DataTable dt = new DataTable();
            dt = TipoSala.Consultar();

            comboBox.DisplayMember = "descripcion";
            comboBox.ValueMember = "idTipos_salas";
            comboBox.DataSource = dt;
        }
    }
}
