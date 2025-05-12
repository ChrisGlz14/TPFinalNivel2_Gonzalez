namespace dominio
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public string ImagenUrl { get; set; }
        public double Precio { get; set; }


    
    }

}
