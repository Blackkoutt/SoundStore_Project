using Projekt_.NET.Models;

namespace Projekt_.NET.Repositories.Interfaces
{
    public interface IAlbumRepository
    {
        void AddAlbum (Album album, int[] SelectedPerformersIds);
        Album GetOne(int id);
        void Delete(int id);
        public void Update(Album album, int[]? Selected_PerformersIds);
        public List<Album> GetAll();
    }
}
