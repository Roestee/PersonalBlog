using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PersonalBlog.Entities.Dtos.HobbiesDtos
{
    public class HobbiesUpdateDto
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
        [DisplayName("İlgi Alanı")]
        [MaxLength(300, ErrorMessage = "{0} en fazla {1} karakter olmalıdır")]
        public string Text { get; set; }
    }
}
