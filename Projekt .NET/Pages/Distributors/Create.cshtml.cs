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

namespace Projekt_.NET.Pages.Distributors
{
    public class CreateModel : PageModel
    {
        private readonly IDistributorService _distributorService;
        public CreateModel(IDistributorService _distributorService)
        {
            this._distributorService = _distributorService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Distributor Distributor { get; set; } = default!;

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _distributorService.Add(Distributor);
            return RedirectToPage("./Index");
        }
    }
}
