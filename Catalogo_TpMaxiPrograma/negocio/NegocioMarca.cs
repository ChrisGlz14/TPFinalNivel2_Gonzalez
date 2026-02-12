using baseDatos;
using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace negocio
{
    public class NegocioMarca
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.IdMarca = (int)datos.Lector["Id"];
                    marca.DescripcionMarca = (string)datos.Lector["Descripcion"];
                    lista.Add(marca);
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
