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

namespace Projekt_.NET.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ICategoryService _categoryService;
        public IndexModel(ICategoryService _categoryService)
        {
            this._categoryService = _categoryService;
        }

        public IList<Category> Category { get;set; } = default!;

        public void OnGet()
        {
            Category = _categoryService.GetAll();
        }
    }
}
