using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GlassRoomWebApp.Domain.Entities
{
    public class GlassCalc
    {
        [Required]
        public int id { get; set; }

        [Required(ErrorMessage = "Введите название")]
        [Display(Name = "Стекло")]
        public string TypeGl { get; set; }

        [Required]
        public int ThGl { get; set; }

        [Required]
        public float PriceGl { get; set; }
    }
}
