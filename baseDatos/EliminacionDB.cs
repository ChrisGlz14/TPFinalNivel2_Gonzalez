using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baseDatos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace baseDatos
{
    public class EliminacionDB : AccesoDatos
    {
        public void eliminarArticulo(int id)
            
        {
            AccesoDatos datos = new AccesoDatos();    



            try
            {
                datos.SetConsulta("DELETE FROM ARTICULOS WHERE Id ="  + id );
                datos.Comando.Parameters.AddWithValue("@Id", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
        
   }     


        
        
    
}
