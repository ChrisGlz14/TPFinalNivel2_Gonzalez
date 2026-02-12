

namespace dominio
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string DescripcionCategoria { get; set; }


        public override string ToString()
        {
            return DescripcionCategoria;
        }

    }


}
