using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_.NET.DAL;

namespace Projekt_.NET.Models
{
    public class MyPageModel : PageModel
    {
        public ShoppingCart shoppingCart;

        public MyPageModel() 
        {
            shoppingCart = new ShoppingCart();
        }
        public void LoadCart()
        {
            string? cookie = Request.Cookies["shoppingcart"];
            shoppingCart.Load(cookie);
        }
        public void SaveCart()
        {
            string newCookie = shoppingCart.Save();
            Response.Cookies.Delete("shoppingcart");
            Response.Cookies.Append("shoppingcart", newCookie);
        }
    }
}
