using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PersonalBlog.Entities.Dtos.ArticleDtos
{
    public class ArticleAddDto
    {
        [DisplayName("Makale Başlık")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Title { get; set; }
        //
        [DisplayName("Kısa İçerik")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(500, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string ShortContent { get; set; }
        //
        [DisplayName("İçerik")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        public string Content { get; set; }
        //
        [DisplayName("Makale Resim")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(250, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string Thumbnail { get; set; }
        //
        [DisplayName("SEO Anahtar Kelimeler")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(150, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string SeoTags { get; set; }
        //
        [DisplayName("SEO Açıklaması")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        [MaxLength(500, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        public string SeoDescription { get; set; }
        //
        [DisplayName("Kategori")]
        [Required(ErrorMessage = "{0} alanı zorunlu bir alandır!")]
        public int CategoryId { get; set; }
    }
}
