using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad alanı boş olamaz.")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Telefon alanı boş olamaz.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="Email alanı boş olamaz.")]
        [EmailAddress(ErrorMessage ="Email adresi formatına uygun bir email adresi girmelisiniz.")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Katılım alanı girmelisiniz.")]
        public bool? WillAttend { get; set; }
    }
}