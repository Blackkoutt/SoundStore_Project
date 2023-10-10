using Projekt_.NET.Models;
using Projekt_.NET.Repositories.Interfaces;
using Projekt_.NET.Services.Interfaces;

namespace Projekt_.NET.Services
{
    public class AlbumPerformerService : IAlbumPerformerService
    {
        private readonly IAlbum_PerformerRepository _album_performerRepository;
        public AlbumPerformerService(IAlbum_PerformerRepository _album_performerRepository) 
        { 
            this._album_performerRepository = _album_performerRepository;
        }
        public List<Album> GetAlbums(int performer_id)
        {
            return _album_performerRepository.GetAlbums(performer_id);
        }

        public List<Performer> GetPerformers(int album_id)
        {
            return _album_performerRepository.GetPerformers(album_id);
            //return _album_performerRepository.GetPerformers(album_id);
        }
    }
}
