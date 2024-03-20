using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PersonalBlog.Entities.Dtos.SiteIdentityDtos
{
    public class SiteIdentityUpdateDto
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
        [DisplayName("Site Başlık")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Title { get; set; }
        //
        [DisplayName("Site Anahtar Kelimeler")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Keywords { get; set; }
        //
        [DisplayName("Site Açıklaması")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(512, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Description { get; set; }
        //
        [DisplayName("Logo Yazısı")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string LogoText { get; set; }
        //
        [DisplayName("Logo İconu")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string LogoFA { get; set; }
    }
}
