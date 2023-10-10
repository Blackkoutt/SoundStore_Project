using System.ComponentModel.DataAnnotations;

namespace Projekt_.NET.DTO
{
    public class AlbumDto
    {
        [Display(Name = "Id:")]
        public int Id { get; set; }
        [Display(Name = "Tytuł:")]
        [Required(ErrorMessage = "Pole {0} jest obowiązkowe !")]
        [MaxLength(25, ErrorMessage = "Pole {0} nie może przekraczać 25 znaków!")]
        public string Title { get; set; }
        [Display(Name = "Ścieżka do zdjęcia:")]
        [Required(ErrorMessage = "Pole {0} jest obowiązkowe !")]
        [MaxLength(15, ErrorMessage = "Pole {0} nie może przekraczać 15 znaków!")]
        public string PhotoData { get; set; }
        [Display(Name = "Cena:")]
        [Required(ErrorMessage = "Pole {0} jest obowiązkowe !")]
        [RegularExpression("^(\\d|,)*\\d*$", ErrorMessage = "Wartość {0} musi być większa od 0!")]
        public decimal Price { get; set; }
        [Display(Name = "Data premiery:")]
        [Required(ErrorMessage = "Pole {0} jest obowiązkowe !")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Podaj poprawną datę!")]
        public DateTime RelaseDate { get; set; }
        
        [Display(Name = "Dystrybutor:")]
        [Required(ErrorMessage = "Pole {0} jest obowiązkowe !")]
        public int DistributorId { get; set; }
        [Display(Name = "Producent:")]
        [Required(ErrorMessage = "Pole {0} jest obowiązkowe !")]
        public int ProducerId { get; set; }
        [Display(Name = "Kategoria:")]
        [Required(ErrorMessage = "Pole {0} jest obowiązkowe !")]
        public int CategoryId { get; set; }
    }
}
