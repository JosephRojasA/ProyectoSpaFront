namespace BibliotecaAPI.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nombre { get; set; } = "";
        public List<Libro> Libros { get; set; } = new();
    }
}
