
namespace dominio
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Categoria Categoria { get; set; }
        public Marca Marca { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }



        public override string ToString()
        {
            return $"Precio: ${Precio}";
        }

         
        }

   

}
