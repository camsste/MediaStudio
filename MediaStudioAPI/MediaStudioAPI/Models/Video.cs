namespace MediaStudioAPI.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; } // Preço do vídeo

        public bool IsValid()
        {
            // Regra de negócio: Verificar se o título e o diretor são válidos
            return !string.IsNullOrEmpty(Title) && !string.IsNullOrEmpty(Director);
        }
    }
}
