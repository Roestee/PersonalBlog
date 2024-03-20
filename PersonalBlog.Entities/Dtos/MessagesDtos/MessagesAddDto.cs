using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PersonalBlog.Entities.Dtos.MessagesDtos
{
    public class MessagesAddDto
    {
        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string FirstName { get; set; }
        //
        [DisplayName("Soyad")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string LastName { get; set; }
        //
        [DisplayName("E-Mail")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Email { get; set; }
        //
        [DisplayName("Konu")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(20, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Subject { get; set; }
        //
        [DisplayName("Mesaj")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(512, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Text { get; set; }
    }
}
