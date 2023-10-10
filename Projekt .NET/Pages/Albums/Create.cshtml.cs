using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekt_.NET.Context;
using Projekt_.NET.Models;
using Projekt_.NET.DTO;
using Projekt_.NET.Services;
using Projekt_.NET.Services.Interfaces;
using Projekt_.NET.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace Projekt_.NET.Pages.Albums
{
    public class CreateModel : PageModel
    {
        private readonly ApiContext _context;
        private readonly IAlbumService albumService;
        public CreateModel(ApiContext context, IAlbumService albumService)
        {
            _context = context;
            this.albumService = albumService;
        }

        public IActionResult OnGet()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["DistributorId"] = new SelectList(_context.Distributors, "Id", "Name");
            ViewData["ProducerId"] = new SelectList(_context.Producers, "Id", "Name");
            ViewData["Performers"] = new MultiSelectList(_context.Performers, "Id", "Name");
            return Page();
        }
        [BindProperty]
        public AlbumDto Album { get; set; } = default!;
        [Required]
        [BindProperty]
        public int[] Selected_PerformersIds { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            albumService.Add(Album, Selected_PerformersIds);
            return RedirectToPage("../Index");
        }
    }
}
