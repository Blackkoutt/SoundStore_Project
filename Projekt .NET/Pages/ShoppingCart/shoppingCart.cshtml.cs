using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt_.NET.Models;
using Projekt_.NET.Services.Interfaces;

namespace Projekt_.NET.Pages.ShoppingCart
{
    public class shoppingCartModel : MyPageModel
    {
        public List<Album> albumList;
        private IAlbumService albumService;
        public bool anyDeleted;
        public shoppingCartModel(IAlbumService albumService)
        {
            this.albumService = albumService;
        }
        public void OnGet()
        {
            LoadCart();
            var albums = albumService.GetAll();
            var AlbumID = shoppingCart.List();

            albumList = new List<Album>();
            anyDeleted = false;
            for(int i = AlbumID.Count -1; i>=0; i--)
            {
                bool found = false;
                for(int j = 0; j < albums.Count; j++)
                {
                    if (albums[j].Id == AlbumID[i])
                    {
                        found= true;
                        albumList.Add(albums[j]);
                        break;
                    }
                }
                if(found == false)
                {
                    anyDeleted = true;
                    AlbumID.RemoveAt(i);
                }
                
            }
            albumList.Reverse();
            SaveCart();

        }
        public IActionResult OnPost()
        {
            LoadCart();
            shoppingCart.Clear();
            SaveCart();
            return RedirectToPage("shoppingCart");
        }
    }
}
