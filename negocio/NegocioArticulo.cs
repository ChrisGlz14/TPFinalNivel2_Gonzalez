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
            return db.EjecutarConsulta("SELECT Codigo, Nombre, ImagenUrl from ARTICULOS");
        }
    }
}
