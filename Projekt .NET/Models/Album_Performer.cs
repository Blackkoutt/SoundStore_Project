namespace Projekt_.NET.Models
{
    public class Album_Performer
    {
        public int PerformerId { get; set; }
        public int AlbumId { get; set; }
        public Performer Performer { get; set; }
        public Album Album { get; set; }
    }
}
