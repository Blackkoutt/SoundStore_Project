using System.ComponentModel.DataAnnotations;

namespace Projekt_.NET.DTO
{
    public class PerformerDto
    {
        public int Id { get; set; }
        [Display(Name = "Pseudonim:")]
        [Required(ErrorMessage = "Pole {0} jest obowiązkowe !")]
        public string Name { get; set; }
    }
}
