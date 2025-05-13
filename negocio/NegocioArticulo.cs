using baseDatos;
using dominio;




namespace negocio
{
    public class NegocioArticulo
    {

        //Metodo para listar todos
        public List<Articulo> listarTodos()
        {
            ConsultaDB db = new ConsultaDB();
            return db.EjecutarConsulta("SELECT " +
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
                    "WHERE C.Id = A.Id AND C.Id = M.Id");
        }

        

    }
}
