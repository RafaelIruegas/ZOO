namespace ZOO.Models.ViewModels
{
    public class Especie
    {
        public List<Esp> espe { get; set; } = null!;
    }
    public class Esp 
    {
        public string nombre { get; set; } = null!;
        public int id { get; set; }
        public double? peso { get; set; }
        public int? tamaño { get; set; }
        public string habitad { get; set; } = null!;
        public string descripcion { get; set;} = null!;
        public string especie { get; set; } = null!;
    }
}
