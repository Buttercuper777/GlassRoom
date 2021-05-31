using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GlassRoomWebApp.Domain.Entities
{
    public class FitCalc
    {
        [Required]
        public int id { get; set; }

        [Required(ErrorMessage = "Введите название")]
        [Display(Name = "Фурнитура")]
        public string TypeFit { get; set; }

        [Required]
        public float PriceFit { get; set; }

    }
}
