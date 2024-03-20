using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Entities.Dtos.SkillsDtos
{
    public class SkillsUpdateDto
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
        [DisplayName("Yetenek Başlık")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Title { get; set; }
        //
        [DisplayName("Yetenek Yüzdesi")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [Range(0, 100, ErrorMessage = "{0} alanın değeri {1] ile {2} arasında olmalıdır!")]
        public int PercentageValue { get; set; }
    }
}
