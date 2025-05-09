namespace PruebaTecnicaCarsales.Models
{
    

    public class EpisodeResponseDto
    {
        public Info Info { get; set; }
        public List<Episode> Results { get; set; }
    }

    public class Info
    {
        public int Count { get; set; }
        public int Pages { get; set; }
        public string Next { get; set; }
        public string Prev { get; set; }
    }

    public class Episode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AirDate { get; set; }
        public string EpisodeCode { get; set; }
    }
}
