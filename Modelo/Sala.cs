using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class Sala
    {
        public static DataTable Consultar()
        {
            DataTable dt = new DataTable();
            dt = DatosSala.ConsultarTabla();

            return dt;
        }

    }

    public class TipoSala
    {
        public static DataTable Consultar()
        {
            DataTable dt = new DataTable();
            dt = DatosTipoSala.ConsultarTipoSala();

            return dt;
        }
    }
}
