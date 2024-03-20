using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PersonalBlog.Entities.Dtos.AdminDtos
{
    public class AdminAddDto
    {
        [DisplayName("E-Mail")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Email { get; set; }
        //
        [DisplayName("Şifre")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Password { get; set; }
        //
        [DisplayName("Güvenlik Sorusu")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(200, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string SecurityQuestion { get; set; }
        //
        [DisplayName("Güvenlik Şifresi")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string SecurityQuestionAnswer { get; set; }
    }
}
