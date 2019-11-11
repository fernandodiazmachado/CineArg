using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Descuento
    {
        public int IdDescentos { get; }
        public string Detalle { get; set; }
        public int Porcentaje { get; set; }

        public static string ConsultarTabla()
        {
            bool ok = DatosDescuento.ConsultarTabla();

            if (ok)
                return "conexion con tabla descuento exitosa";
            else
                return "fallo la conexion con tabla descuento";
        }

        public static string Modificar(Descuento descuento)
        {
            bool ok = DatosDescuento.Modificar(descuento.IdDescentos, descuento.Detalle, descuento.Porcentaje);

            if (ok)
                return "Se ha modificado el porcentaje " + descuento.Detalle;
            else
                return "No se ha podido modificar el porcentaje " + descuento.Detalle;
        }


    }
}
