using System.ComponentModel.DataAnnotations;

namespace GlassRoomWebApp.Models
{
    public class SendMailModel
    {
        [Required]
        [Display(Name = "Имя")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Телефон")]
        public string Phone { get; set; }

    }
}
