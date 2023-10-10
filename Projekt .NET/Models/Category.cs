using System.ComponentModel.DataAnnotations;

namespace Projekt_.NET.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Nazwa:")]
        [Required(ErrorMessage = "Pole {0} jest obowiązkowe !")]
        [MaxLength(20, ErrorMessage = "Pole {0} nie może przekraczać 20 znaków.")]
        public string Name { get; set; }
        public ICollection<Album> Albums { get; set; } = new List<Album>();
    }
}
