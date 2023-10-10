using Projekt_.NET.DTO;
using Projekt_.NET.Models;

namespace Projekt_.NET.Services.Interfaces
{
    public interface IAlbumService
    {
        public int Add(AlbumDto album, int[] Selected_PerformersIds);
        public Album GetOne(int id);
        public void Delete(int id);
        public void Update(Album album, int[]? Selected_PerformersIds);
        public List<Album> GetAll();
    }
}
