using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_.NET.Models;

namespace Projekt_.NET.Pages.ShoppingCart
{
    public class RemoveElementFromCartModel : MyPageModel
    {
        [BindProperty(SupportsGet =true)]
        public int id { get; set; }
        public IActionResult OnGet()
        {
            LoadCart();
            shoppingCart.Remove(id);
            SaveCart();
            return RedirectToPage("ShoppingCart");
        }
    }
}
