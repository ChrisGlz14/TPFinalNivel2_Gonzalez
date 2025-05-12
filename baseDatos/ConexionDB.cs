using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using dominio;
using Microsoft.Data.SqlClient;


namespace baseDatos
{

    public class ConexionDB {
        private SqlConnection conexion;
        protected SqlCommand comando;
        protected SqlDataReader lector;
        

        public ConexionDB()
        {
            try
            {
                conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true; TrustServerCertificate=True");
                comando = new SqlCommand();
                comando.Connection = conexion;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void AbrirConexion()
        {
            if (conexion.State != System.Data.ConnectionState.Open)
                conexion.Open();
        }

        public void CerrarConexion()
        {
            if (lector != null && !lector.IsClosed)
                lector.Close();
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }

        //Esto es un objeto de tipo SqlDataReader
        public SqlDataReader EjecutarLectura(string consulta)
        {
            comando.CommandText = consulta;
            comando.CommandType = System.Data.CommandType.Text;
            AbrirConexion();
            lector = comando.ExecuteReader();
            return lector;
        }


    }
}
