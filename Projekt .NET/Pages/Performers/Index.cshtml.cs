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

namespace Projekt_.NET.Pages.Performers
{
    public class IndexModel : PageModel
    {
        private readonly IPerformerService _performerService;
        public IndexModel(IPerformerService _performerService)
        {
            this._performerService = _performerService;
        }

        public IList<Performer> Performer { get;set; } = default!;

        public void OnGet()
        {
            Performer = _performerService.GetAll();
        }
    }
}
