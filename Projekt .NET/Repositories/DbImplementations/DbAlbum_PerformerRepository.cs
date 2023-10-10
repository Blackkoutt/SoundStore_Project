using Microsoft.EntityFrameworkCore;
using Projekt_.NET.Context;
using Projekt_.NET.Models;
using Projekt_.NET.Repositories.Interfaces;

namespace Projekt_.NET.Repositories.DbImplementations
{
    public class DbAlbum_PerformerRepository : IAlbum_PerformerRepository
    {
        private readonly ApiContext _context;
        public DbAlbum_PerformerRepository(ApiContext context)
        {
            _context = context;
        }

        public List<Album> GetAlbums(int performer_id)
        {
            var performer = _context.Performers
            .Include(a => a.Albums)
            .ThenInclude(ap => ap.Album)
            .FirstOrDefault(a => a.Id == performer_id);

            if (performer != null)
            {
                var album = performer.Albums.Select(ap => ap.Album);

                return album.ToList();
            }

            return new List<Album>();
        }

        public List<Performer> GetPerformers(int album_id)
        {
            var album = _context.Albums
            .Include(a => a.Performers)
            .ThenInclude(ap => ap.Performer)
            .FirstOrDefault(a => a.Id == album_id);

            if (album != null)
            {
                var performers = album.Performers.Select(ap => ap.Performer);

                return performers.ToList();
            }

            return new List<Performer>();
        }
    }
}
