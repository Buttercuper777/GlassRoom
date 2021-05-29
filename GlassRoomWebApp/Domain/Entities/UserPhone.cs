using System;
using System.ComponentModel.DataAnnotations;

namespace GlassRoomWebApp.Domain.Entities
{
    public class UserPhone
    {
        public UserPhone() => DateUPAdded = DateTime.Now;

        [DataType(DataType.Time)]
        public DateTime DateUPAdded { get; set; }

        public Boolean Checked { get;  set;}

        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите номер")]
        [Display(Name = "Номер телефона")]
        public string PhoneNum { get; set; }
    }
}
