using System.ComponentModel.DataAnnotations;

namespace Projekt_.NET.Models
{
    public class Performer
    {
        public int Id { get; set; }
        [Display(Name = "Pseudonim:")]
        [Required(ErrorMessage = "Pole {0} jest obowiązkowe !")]
        [MaxLength(35, ErrorMessage = "Pole {0} nie może przekraczać 35 znaków!")]
        public string Name { get; set; }

        public ICollection<Album_Performer> Albums { get; set; }
        //public ICollection<Album> Albums { get; set; } = new List<Album>();
        // public ICollection<Album_Performer> Album_Performers { get; set; } = new List<Album_Performer>();
    }
}
