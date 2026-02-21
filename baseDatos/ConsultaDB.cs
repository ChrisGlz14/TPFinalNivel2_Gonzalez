using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using baseDatos;
using dominio;

namespace baseDatos
{
    public class ConsultaDB : AccesoDatos
    {

        public List<Articulo> EjecutarConsulta(string consulta)
        {
            List<Articulo> articulosLista = new List<Articulo>();
            
            try
            {
                SetConsulta(consulta);
                ejecutarLectura();

                while (Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.IdArticulo = Convert.ToInt32(Lector["IdArticulo"]);
                    articulo.Nombre = Lector["Nombre"]?.ToString() ?? "";
                    articulo.Codigo = Lector["Codigo"]?.ToString() ?? "";
                    articulo.ImagenUrl = Lector["ImagenUrl"]?.ToString() ?? "";
                    articulo.Descripcion = Lector["DescripcionArticulo"]?.ToString() ?? "";
                    articulo.Categoria = new Categoria
                    {
                        IdCategoria = (int)Lector["IdCategoria"],
                        DescripcionCategoria = Lector["DescripcionCategoria"].ToString() ?? ""
                    };

                    articulo.Marca = new Marca
                    {
                        IdMarca = (int)Lector["IdMarca"],
                        DescripcionMarca = Lector["DescripcionMarca"].ToString() ?? ""
                    };
                    articulo.Precio = (decimal)Lector["Precio"];
                    articulo.Cantidad = Lector["Cantidad"] != DBNull.Value
                    ? Convert.ToInt32(Lector["Cantidad"])
                    : 0;
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
                this.CerrarConexion();
            }

        }
    }
}
