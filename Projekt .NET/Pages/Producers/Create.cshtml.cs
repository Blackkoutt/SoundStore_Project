using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projekt_.NET.Context;
using Projekt_.NET.Models;
using Projekt_.NET.Services;
using Projekt_.NET.Services.Interfaces;

namespace Projekt_.NET.Pages.Producers
{
    public class CreateModel : PageModel
    {
        private readonly IProducerService _producerService;
        public CreateModel(IProducerService _producerService)
        {
            this._producerService = _producerService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Producer Producer { get; set; } = default!;

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _producerService.Add(Producer);
            return RedirectToPage("./Index");
        }
    }
}
