using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.Entities.Dtos.HobbiesDtos
{
    public class HobbiesAddDto
    {
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [DisplayName("İlgi Alanı")]
        [MaxLength(300, ErrorMessage = "{0} en fazla {1} karakter olmalıdır")]
        public string Text { get; set; }
    }
}
