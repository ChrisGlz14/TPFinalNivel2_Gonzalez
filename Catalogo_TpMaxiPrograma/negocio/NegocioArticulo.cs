using baseDatos;
using Csla.Server;
using dominio;

namespace negocio
{
    public class NegocioArticulo
    {
        public List<Articulo> listar()
        {
            string consulta = "SELECT " +
                                "A.Id AS IdArticulo, " + 
                                "A.Codigo, " +
                                "A.Nombre, " +
                                "A.ImagenUrl, " +
                                "A.Precio, " +
                                "A.Descripcion AS DescripcionArticulo, " +
                                "C.Id AS IdCategoria, " +
                                "C.Descripcion AS DescripcionCategoria, " +
                                "M.Id AS IdMarca, " +
                                "M.Descripcion AS DescripcionMarca " +
                                "FROM ARTICULOS A, CATEGORIAS C, MARCAS M " +
                                "WHERE C.Id = A.IdCategoria AND M.Id = A.IdMarca";

            ConsultaDB consultaDB = new ConsultaDB();
            
            return consultaDB.EjecutarConsulta(consulta);
        }



        public void eliminarArticulo(int id)
        {

            try
            {

                AccesoDatos acceso = new AccesoDatos();

                acceso.SetConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                acceso.Comando.Parameters.AddWithValue("@Id", id);
                acceso.EjecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void modificar (Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                {
                    datos.SetConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, ImagenUrl = @imagenUrl, IdCategoria = @idCategoria, IdMarca = @idMarca Where Id = @id");

                    datos.setParametro("@codigo", art.Codigo);
                    datos.setParametro("@nombre", art.Nombre);
                    datos.setParametro("@descripcion",art.Descripcion);
                    datos.setParametro("@imagenUrl", art.ImagenUrl);
                    datos.setParametro("@idCategoria", art.Categoria.IdCategoria);
                    datos.setParametro("@idMarca",art.Marca.IdMarca);
                    datos.setParametro("@id", art.IdArticulo);
                    datos.EjecutarAccion();
                }
            }
            catch (Exception)
            {

                throw ;
            }
        }

        public void Agregar(Articulo nuevoArt)
        {
            AccesoDatos datos = new AccesoDatos();
            NegocioArticulo articulo = new NegocioArticulo();
            NegocioCategoria negocioCat = new NegocioCategoria();
            NegocioMarca NegocioMarca = new NegocioMarca(); 
            try
            {
                datos.SetConsulta("INSERT into ARTICULOS (Codigo,Nombre,Descripcion,IdCategoria,Precio ,ImagenUrl,IdMarca)values(@Codigo, @Nombre, @Descripcion, @IdCategoria, @Precio, @ImagenUrl, @IdMarca)");
                datos.setParametro("@Codigo", nuevoArt.Codigo);
                datos.setParametro("@Nombre", nuevoArt.Nombre);
                datos.setParametro("@Descripcion", nuevoArt.Descripcion);
                datos.setParametro("@IdCategoria", nuevoArt.Categoria.IdCategoria);
                datos.setParametro("@Precio", nuevoArt.Precio);
                datos.setParametro("@ImagenUrl", nuevoArt.ImagenUrl);
                datos.setParametro("@IdMarca", nuevoArt.Marca.IdMarca);
                datos.EjecutarAccion();
                
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Articulo> listarFiltro(string categoria, string marca)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT " +
                                  "A.Id AS IdArticulo, " +
                                  "A.Codigo, " +
                                  "A.Nombre, " +
                                  "A.ImagenUrl, " +
                                  "A.Precio, " +
                                  "A.Descripcion AS DescripcionArticulo, " +
                                  "C.Id AS IdCategoria, " +
                                  "C.Descripcion AS DescripcionCategoria, " +
                                  "M.Id AS IdMarca, " +
                                  "M.Descripcion AS DescripcionMarca " +
                                  "FROM ARTICULOS A, CATEGORIAS C, MARCAS M " +
                                  "WHERE C.Id = A.IdCategoria AND M.Id = A.IdMarca";

                if (categoria != null)
                {
                    switch (categoria)
                    {
                        case "Celulares":
                        case "Televisores":
                        case "Medias":
                        case "Audio":
                            consulta += " AND C.Descripcion = @categoria";
                            datos.setParametro("@categoria", categoria);
                            break;

                        default:
                            break;
                    }
                }

                if (marca != null)
                {
                    switch (marca)
                    {
                        case "Samsung":
                        case "Apple":
                        case "Sony":
                        case "Huawei":
                        case "Motorola":
                            consulta += " AND M.Descripcion = @marca";
                            datos.setParametro("@marca", marca);
                            break;

                        default:
                            break;
                    }
                }


                datos.SetConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo art = new Articulo();
                    art.IdArticulo = (int)datos.Lector["IdArticulo"];
                    art.Codigo = datos.Lector["Codigo"].ToString() ?? "";
                    art.Nombre = datos.Lector["Nombre"].ToString() ?? "";
                    art.ImagenUrl = datos.Lector["ImagenUrl"].ToString() ?? "";
                    art.Precio = (decimal)datos.Lector["Precio"];
                    art.Descripcion = datos.Lector["DescripcionArticulo"].ToString() ?? "";

                    art.Categoria = new Categoria();
                    art.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];
                    art.Categoria.DescripcionCategoria = datos.Lector["DescripcionCategoria"].ToString() ?? "";

                    art.Marca = new Marca();
                    art.Marca.IdMarca = (int)datos.Lector["IdMarca"];
                    art.Marca.DescripcionMarca = datos.Lector["DescripcionMarca"].ToString() ?? "";

                    lista.Add(art);
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

    }


}
