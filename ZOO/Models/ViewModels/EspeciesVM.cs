namespace ZOO.Models.ViewModels
{
    public class EspeciesVM
    {
        public int id {get; set; }
        public string nombre { get; set;} = null!;
        public List<SP> ListaAni { get; set; } = null!;   

    }
    public class SP
    {
        public int id { get; set; }
        public string nombre { get; set; } = null!;
        public int IdClase { get; set; }
    }
}
