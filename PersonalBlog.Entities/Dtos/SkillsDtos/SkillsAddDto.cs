using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.Entities.Dtos.SkillsDtos
{
    public class SkillsAddDto
    {
        [DisplayName("Yetenek Başlık")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Title { get; set; }
        //
        [DisplayName("Yetenek Yüzdesi")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [Range(0,100, ErrorMessage = "{0} alanın değeri {1] ile {2} arasında olmalıdır!")]
        public int PercentageValue { get; set; }
    }
}
