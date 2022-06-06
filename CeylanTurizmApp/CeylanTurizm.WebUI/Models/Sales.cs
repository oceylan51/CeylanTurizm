using System.ComponentModel.DataAnnotations;

namespace CeylanTurizm.WebUI.Models
{
    public class Sales
    {
        [Required(ErrorMessage = "Başlangıç Şehrini Seçiniz")]
        public string cityStart { get; set; }
        [Required(ErrorMessage = "Bitiş Şehrini Seçiniz")]
        public string cityFinish { get; set; }
        [Required(ErrorMessage = "Seyahat Tarihini Seçiniz")]
        public string date { get; set; }
    }
}
