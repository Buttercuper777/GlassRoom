using System;
using System.ComponentModel.DataAnnotations;

namespace GlassRoomWebApp.Domain.Entities
{
    public class UserPhone
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите номар")]
        [Display(Name = "Номер телефона")]
        public string PhoneNum { get; set; }
    }
}
