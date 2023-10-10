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
    public class IndexModel : PageModel
    {
        private readonly IDistributorService _distributorService;
        public IndexModel(IDistributorService _distributorService)
        {
            this._distributorService = _distributorService;
        }

        public IList<Distributor> Distributor { get;set; } = default!;

        public void OnGet()
        {
            Distributor = _distributorService.GetAll();
        }
    }
}
