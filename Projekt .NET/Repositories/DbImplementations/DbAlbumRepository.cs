using Microsoft.EntityFrameworkCore;
using Projekt_.NET.Context;
using Projekt_.NET.DTO;
using Projekt_.NET.Models;
using Projekt_.NET.Repositories.Interfaces;

namespace Projekt_.NET.Repositories.DbImplementations
{
    public class DbAlbumRepository : IAlbumRepository
    {
        private readonly ApiContext _context; 
        public DbAlbumRepository(ApiContext context)
        {
            _context = context;
        }
        public void AddAlbum(Album album, int[] Selected_PerformersIds)
        {
            _context.Albums.Add(album);
            _context.SaveChanges();
            Album a = _context.Albums.OrderByDescending(album => album.Id).FirstOrDefault();
            foreach (int SPI in Selected_PerformersIds)
            {
                var albumPerformer = new Album_Performer { AlbumId = album.Id, PerformerId = SPI };
               // Album.Performers.Add(albumPerformer);
                _context.Album_Performers.Add(albumPerformer);
            }
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var albumToDelete = GetOne(id);
            _context.Albums.Remove(albumToDelete);
            _context.SaveChanges();
        }

        public List<Album> GetAll()
        {
            return _context.Albums
                    .Include(a => a.Category)
                    .Include(a => a.Distributor)
                    .Include(a => a.Producer)
                    .Include(a => a.Performers)
                    .ThenInclude(ap => ap.Performer)
                    .ToList();
        }

        public Album GetOne(int id)
        {
             return _context.Albums
                    .Include(a => a.Category)
                    .Include(a => a.Distributor)
                    .Include(a => a.Producer).FirstOrDefault(m => m.Id == id);
        }

        public void Update(Album album, int[]? Selected_PerformersIds)
        {
            _context.Attach(album).State = EntityState.Modified;
            if(Selected_PerformersIds != null && Selected_PerformersIds.Any())
            {
                var albumPerformersToRemove = _context.Album_Performers
                                        .Where(ap => ap.AlbumId == album.Id)
                                        .ToList();

                _context.Album_Performers.RemoveRange(albumPerformersToRemove);

                foreach (int SPI in Selected_PerformersIds)
                {
                    var albumPerformer = new Album_Performer { AlbumId = album.Id, PerformerId = SPI };
                    // Album.Performers.Add(albumPerformer);
                    _context.Album_Performers.Add(albumPerformer);
                }
            }
            _context.SaveChanges();
        }
    }
}
