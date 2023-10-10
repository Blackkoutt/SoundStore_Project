using System.ComponentModel.DataAnnotations;

namespace Projekt_.NET.Models
{
    public class Producer
    {
        public int Id { get; set; }
        [Display(Name = "Nazwa:")]
        [Required(ErrorMessage = "Pole {0} jest obowiązkowe !")]
        [MaxLength(35, ErrorMessage = "Pole {0} nie może przekraczać 35 znaków!")]
        public string Name { get; set; }
        public ICollection<Album> Albums { get; set; } = new List<Album>();
    }
}
