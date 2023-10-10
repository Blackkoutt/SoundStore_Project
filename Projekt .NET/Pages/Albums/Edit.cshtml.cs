using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekt_.NET.Context;
using Projekt_.NET.DTO;
using Projekt_.NET.Models;
using Projekt_.NET.Services;
using Projekt_.NET.Services.Interfaces;

namespace Projekt_.NET.Pages.Albums
{
    public class EditModel : PageModel
    {
        private readonly IAlbumService _albumService;
        private readonly IAlbumPerformerService _album_performerService;
        private readonly ApiContext _context;
        public EditModel(IAlbumService _albumService, IAlbumPerformerService _album_performerService, ApiContext context)
        {
            this._albumService = _albumService;
            this._album_performerService = _album_performerService;
            _context = context;
        }

        [BindProperty]
        public Album Album { get; set; } = default!;
        [Display(Name = "Wykonawcy:")]
        public List<Performer> performers = new List<Performer>();
        [BindProperty]
        public int[]? Selected_PerformersIds { get; set; }

        public IActionResult OnGet(int id)
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["DistributorId"] = new SelectList(_context.Distributors, "Id", "Name");
            ViewData["ProducerId"] = new SelectList(_context.Producers, "Id", "Name");
            ViewData["Performers"] = new MultiSelectList(_context.Performers, "Id", "Name");
            Album = _albumService.GetOne(id);
            performers = _album_performerService.GetPerformers(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            _albumService.Update(Album, Selected_PerformersIds);
            return RedirectToPage("../Index");
        }
    }
}
