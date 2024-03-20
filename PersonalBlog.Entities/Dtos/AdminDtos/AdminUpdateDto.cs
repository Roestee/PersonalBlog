using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PersonalBlog.Entities.Dtos.AdminDtos
{
    public class AdminUpdateDto
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
