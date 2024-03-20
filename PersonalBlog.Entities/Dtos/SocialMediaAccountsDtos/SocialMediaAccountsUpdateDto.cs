using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PersonalBlog.Entities.Dtos.SocialMediaAccountsDtos
{
    public class SocialMediaAccountsUpdateDto
    {
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        public int Id { get; set; }
        //
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [DisplayName("Aktif Olsun mu?")]
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [DisplayName("Silinsin mi?")]
        public bool IsDelete { get; set; }
        //
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
