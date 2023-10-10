using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projekt_.NET.Context;
using Projekt_.NET.DTO;
using Projekt_.NET.Models;
using Projekt_.NET.Services;
using Projekt_.NET.Services.Interfaces;

namespace Projekt_.NET.Pages.Performers
{
    public class CreateModel : PageModel
    {
        private readonly IPerformerService _performerService;
        public CreateModel(IPerformerService _performerService)
        {
            this._performerService = _performerService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PerformerDto Performer { get; set; } = default!;
        
        public IActionResult OnPost()
        {
           if (!ModelState.IsValid)
           {
                return Page();
           }
            _performerService.Add(Performer);
            return RedirectToPage("./Index");

        }
    }
}
