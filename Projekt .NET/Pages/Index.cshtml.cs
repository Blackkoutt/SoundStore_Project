using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_.NET.Context;
using Projekt_.NET.Models;
using Projekt_.NET.Services.Interfaces;

namespace Projekt_.NET.Pages.Albums
{
    public class IndexModel : PageModel
    {
        private IAlbumService _albumService;
        public IndexModel(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public IList<Album> Album { get;set; } = default!;

        public void OnGet()
        {
            Album = _albumService.GetAll();
        }
    }
}
