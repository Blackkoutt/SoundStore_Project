using Projekt_.NET.Models;

namespace Projekt_.NET.Repositories.Interfaces
{
    public interface IAlbum_PerformerRepository
    {
        public List<Performer> GetPerformers(int album_id);
        public List<Album> GetAlbums(int performer_id);
    }
}
