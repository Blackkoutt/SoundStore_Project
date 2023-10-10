using Projekt_.NET.Models;

namespace Projekt_.NET.Services.Interfaces
{
    public interface IAlbumPerformerService
    {
        public List<Performer> GetPerformers(int album_id);
        public List<Album> GetAlbums(int performer_id);
    }
}
