using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    public class DatosFuncion
    {
        public static bool Agregar(int idPelicula, int idSala, int idIdioma, DateTime? fechaProy)
        {            
            Conexion con = new Conexion();
            string query = "INSERT INTO FUNCION (FK_Pelicula, Fk_Sala,Fk_Idioma,fechaProyeccion) ";
            query = query + "VALUES ('" + idPelicula + "', '" + idSala + "', '"+ idIdioma + "', '"+ fechaProy.Value.ToString("yyyy-MM-dd HH:mm:00") + "')";
            return con.ExecuteComand(query);
        }

        public static DataTable Consultar(int idPelicula, int idTipoSala, DateTime? fecha)
        {
            Conexion con = new Conexion();
            string query = "SELECT 0 comprar, p.nombre nombrePelicula, ts.descripcion tipoSala, ts.costo costo, i.descripcion idioma, f.fechaProyeccion fechaProy, s.capacidad - IFNULL(f.entradasVendidas, 0) asientosDisp ";
            query += "FROM peliculas p ";
            query += "INNER JOIN funcion f on p.idPelicula = f.FK_Pelicula ";
            query += "INNER JOIN salas s on s.idSalas = f.FK_Sala ";
            query += "INNER JOIN tipos_salas ts on ts.idTipos_Salas = s.FK_Tipo_Salas ";
            query += "INNER JOIN idiomas i on i.idIdioma = FK_Idioma ";
            query += "WHERE p.fechaHasta >= f.fechaProyeccion ";
            query += "AND (0 = " + idPelicula + " or p.idPelicula = " + idPelicula + ") ";
            query += "AND (0 = " + idTipoSala + " or ts.idTipos_Salas = " + idTipoSala + ") ";

            if (fecha != null)
                query += "AND f.fechaProyeccion >= '" + fecha.Value.ToString("yyyy-MM-dd HH:mm:00") + "' ";

            query += "order by p.nombre, f.fechaProyeccion ";
            return con.SelectDataTable(query);
        }
    }
}
