using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PersonalBlog.Entities.Dtos.HomePageSlidersDtos
{
    public class HomePageSlidersAddDto
    {
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Title { get; set; }
        //
        [DisplayName("Kısa İçerik")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(500, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string ShortContent { get; set; }
        //
        [DisplayName("İçerik")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        public string Content { get; set; }
    }
}
