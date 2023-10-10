using Microsoft.AspNetCore.Authorization;
using Projekt_.NET.DTO;
using Projekt_.NET.Models;
using Projekt_.NET.Repositories.Interfaces;
using Projekt_.NET.Services.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Projekt_.NET.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepository albumRepository;
        public AlbumService(IAlbumRepository albumRepository) 
        {
            this.albumRepository = albumRepository;
        }
        public int Add(AlbumDto album, int[] Selected_PerformersIds)
        {
            var newAlbum = new Album()
            {
                Title = album.Title,
                PhotoData = album.PhotoData,
                Price = album.Price,
                RelaseDate = album.RelaseDate,
                DistributorId = album.DistributorId,
                ProducerId = album.ProducerId,
                CategoryId = album.CategoryId
            };
            albumRepository.AddAlbum(newAlbum, Selected_PerformersIds);
            return album.Id;
        }

        public void Delete(int id)
        {
            albumRepository.Delete(id);
        }

        public List<Album> GetAll()
        {
            return albumRepository.GetAll();
        }

        public Album GetOne(int id)
        {
            return albumRepository.GetOne(id);
        }

        public void Update(Album album, int[]? Selected_PerformersIds)
        {
            albumRepository.Update(album, Selected_PerformersIds);
        }
    }
}
