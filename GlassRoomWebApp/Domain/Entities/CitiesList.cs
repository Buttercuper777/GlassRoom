using System;
using System.ComponentModel.DataAnnotations;

namespace GlassRoomWebApp.Domain.Entities
{
    public class CitiesList
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Заполните название города")]
        [Display(Name = "Название города")]
        public string CityName { get; set; }

    }
}
