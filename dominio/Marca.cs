namespace dominio
{
    public class Marca
    {
        public int IdMarca { get; set; }
        public string DescripcionMarca { get; set; }


        public override string ToString()
        {
            return DescripcionMarca;
        }

    }
}
