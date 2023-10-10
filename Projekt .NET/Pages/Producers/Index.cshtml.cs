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

namespace Projekt_.NET.Pages.Producers
{
    public class IndexModel : PageModel
    {
        private readonly IProducerService _producerService;
        public IndexModel(IProducerService _producerService)
        {
            this._producerService = _producerService;
        }

        public IList<Producer> Producer { get;set; } = default!;

        public void OnGet()
        {
            Producer = _producerService.GetAll();
        }
    }
}
