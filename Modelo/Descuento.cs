using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class Descuento
    {
        public int IdDescuentos { get; set; }
        public string Detalle { get; set; }
        public int Porcentaje { get; set; }

        public static DataTable Consultar()
        {
            DataTable dt = new DataTable();
            dt = DatosDescuento.ConsultarTabla();

            return dt;
        }

        public static int ConsultarPorcentaePorId(int id)
        {
            int descuento;
            descuento = DatosDescuento.ConsultarPorcentajePorId(id);
            return descuento;
        }

        public static string Modificar(Descuento descuento)
        {
            bool ok = DatosDescuento.Modificar(descuento.IdDescuentos, descuento.Porcentaje);

            if (ok)
                return "Se ha modificado el porcentaje " + descuento.Detalle;
            else
                return "No se ha podido modificar el porcentaje " + descuento.Detalle;
        }


    }
}
