using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PersonalBlog.Entities.Dtos.ExperiencesDtos
{
    public class ExperiencesUpdateDto
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
        [DisplayName("Tecrübe Başlık")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Title { get; set; }
        //
        [DisplayName("Şirket Adı")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(100, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string CompanyName { get; set; }
        //
        [DisplayName("Çalışma Süresi")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Duration { get; set; }
        //
        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Description { get; set; }
    }
}
