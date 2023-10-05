namespace ZOO.Models.ViewModels
{
    public class IndexVM
    {
        public List<Ani> Ani2 { get; set; } = null!;
    }
    public class Ani
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

    }
}
