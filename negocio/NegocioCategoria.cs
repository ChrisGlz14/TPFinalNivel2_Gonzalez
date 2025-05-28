using baseDatos;
using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class NegocioCategoria
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.IdCategoria = (int)datos.Lector["Id"];
                    categoria.DescripcionCategoria = (string)datos.Lector["Descripcion"];
                    lista.Add(categoria);
                }

                return lista;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

    }
}
