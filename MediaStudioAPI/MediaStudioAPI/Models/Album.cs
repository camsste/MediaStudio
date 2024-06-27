namespace MediaStudioAPI.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; } // Preço do álbum

        public bool IsValid()
        {
            // Regra de negócio: Verificar se o título e o artista são válidos
            return !string.IsNullOrEmpty(Title) && !string.IsNullOrEmpty(Artist);
        }
    }
}
