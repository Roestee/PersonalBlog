using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PersonalBlog.Entities.Dtos.AboutMeDtos
{
    public class AboutMeAddDto
    {
        [DisplayName("İsim")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string FirstName { get; set; }
        //
        [DisplayName("Soyisim")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(30, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string LastName { get; set; }
        //
        [DisplayName("Profil Fotoğrafı")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string ImageUrl { get; set; }
        //
        [DisplayName("Meslek")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(40, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Job { get; set; }
        //
        [DisplayName("Meslek İkonu")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string JobFA { get; set; }
        //
        [DisplayName("Doğum Tarihi")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        public DateTime BirthDate { get; set; }
        //
        [DisplayName("CV Link")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string CVUrl { get; set; }
    }
}
