using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.Entities.Dtos.SocialMediaAccountsDtos
{
    public class SocialMediaAccountsAddDto
    {
        [DisplayName("Sosyal Medya Hesabı")]
        [Required(ErrorMessage = "{0} alanı boş olamaz!")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla 30 karakter uzunluğunda olmalıdır!")]
        public string Account { get; set; }
        //
        [DisplayName("Sosyal Medya Hesabı İkonu")]
        [Required(ErrorMessage = "{0} alanı boş olamaz!")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla 150 karakter uzunluğunda olmalıdır!")]
        public string AccountFA { get; set; }
        //
        [DisplayName("Sosyal Medya Hesabın Link'i")]
        [Required(ErrorMessage = "{0} alanı boş olamaz!")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla 150 karakter uzunluğunda olmalıdır!")]
        public string AccountUrl { get; set; }
    }
}
