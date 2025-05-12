using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using baseDatos;
using dominio;

namespace baseDatos
{
    public class ConsultaDB : ConexionDB
    {

        public List<Articulo> EjecutarConsulta(string consulta)
        {
            List<Articulo> articulosLista = new List<Articulo>();

            ConexionDB conexion = new ConexionDB();
            
            try
            {
                SqlDataReader lector = EjecutarLectura(consulta);

                while (lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Nombre = lector["Nombre"].ToString();
                    //articulo.IdArticulo = Convert.ToInt32(lector["IdArticulo"]);
                    articulo.Codigo = lector["Codigo"].ToString();
                    articulo.ImagenUrl = lector["ImagenUrl"].ToString();
                    articulosLista.Add(articulo);
                }

                return articulosLista;
            }
            catch ( Exception ex)
            {

                throw new Exception("Error en la consulta", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }
    }
}
