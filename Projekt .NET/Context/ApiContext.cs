using Microsoft.EntityFrameworkCore;
using Projekt_.NET.Extenssions;
using Projekt_.NET.Models;
using System.Security.Cryptography.X509Certificates;
using Projekt_.NET.DTO;

namespace Projekt_.NET.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }
        public DbSet<Album> Albums {get; set;}
        public DbSet<Album_Performer> Album_Performers { get; set;}
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<Performer> Performers { get; set; }    
        public DbSet<Producer> Producers { get; set; }
        //public DbSet <Users> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album_Performer>().ToTable("Album_Performers");
            modelBuilder.Entity<Album_Performer>().HasKey(p => new { p.PerformerId, p.AlbumId });
            modelBuilder.Entity<Album_Performer>()
                .HasOne(x => x.Performer)
                .WithMany(x => x.Albums)
                .HasForeignKey(x => x.PerformerId);
            modelBuilder.Entity<Album_Performer>()
                .HasOne(x => x.Album)
                .WithMany(x => x.Performers)
                .HasForeignKey(x => x.AlbumId);
            modelBuilder.Seed();
        }
        public DbSet<Projekt_.NET.DTO.AlbumDto> AlbumDto { get; set; } = default!;
    }
    
}
