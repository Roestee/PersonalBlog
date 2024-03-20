using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.Entities.Dtos.SummaryDtos
{
    public class SummaryUpdateDto
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
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [DisplayName("Özet Bilgisi")]
        [MinLength(100, ErrorMessage = "{0} alanı en az {1} karakter olmalıdır!")]
        public string Content { get; set; }
    }
}
