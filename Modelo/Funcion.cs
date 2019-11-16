using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class Funcion
    {
        public int IdPelicula{ get; set; }
        public int IdSala { get; set; }
        public int IdIdioma { get; set; }
        public DateTime FechaProy { get; set; }

        public static string Agregar(Funcion funcion)
        {
            bool ok = DatosFuncion.Agregar(funcion.IdPelicula, funcion.IdSala, funcion.IdIdioma, funcion.FechaProy);

            if (ok)
                return "Se ha dado de alta la funcion";
            else
                return "No se ha podido dar de alta la funcion";
        }
    }
}
