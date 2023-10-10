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

namespace Projekt_.NET.Pages.Producers
{
    public class DeleteModel : PageModel
    {
        private readonly IProducerService _producerService;
        public DeleteModel(IProducerService _producerService)
        {
            this._producerService = _producerService;
        }

        [BindProperty]
      public Producer Producer { get; set; } = default!;

        public void OnGet(int id)
        {
            Producer = _producerService.GetOne(id);
        }

        public IActionResult OnPost(int id)
        {
            _producerService.Delete(Producer.Id);
            return RedirectToPage("./Index");
        }
    }
}
