using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_.NET.Context;
using Projekt_.NET.Models;
using Projekt_.NET.Services.Interfaces;

namespace Projekt_.NET.Pages.Albums
{
    public class DeleteModel : PageModel
    {
        private readonly IAlbumService _albumService;
        private readonly IAlbumPerformerService _album_performerService;

        public DeleteModel(IAlbumService _albumService, IAlbumPerformerService _album_performerService)
        {
            this._albumService = _albumService;
            this._album_performerService = _album_performerService;
        }

      [BindProperty]
      public Album Album { get; set; } = default!;
      public List<Performer> performers = new List<Performer>();

        public void OnGet(int id)
        {
            Album = _albumService.GetOne(id);
            performers = _album_performerService.GetPerformers(id);
        }
        public IActionResult OnPost() 
        {
            _albumService.Delete(Album.Id);
            return RedirectToPage("../Index");
        }
    }
}
