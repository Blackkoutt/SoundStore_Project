using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_.NET.Context;
using Projekt_.NET.Models;
using Projekt_.NET.Services;
using Projekt_.NET.Services.Interfaces;

namespace Projekt_.NET.Pages.Distributors
{
    public class DeleteModel : PageModel
    {
        private readonly IDistributorService _distributorService;
        public DeleteModel(IDistributorService _distributorService)
        {
            this._distributorService = _distributorService;
        }

        [BindProperty]
      public Distributor Distributor { get; set; } = default!;

        public void OnGet(int id)
        {
            Distributor = _distributorService.GetOne(id);
        }

        public IActionResult OnPost(int id)
        {
            _distributorService.Delete(Distributor.Id);
            return RedirectToPage("./Index");
        }
    }
}
