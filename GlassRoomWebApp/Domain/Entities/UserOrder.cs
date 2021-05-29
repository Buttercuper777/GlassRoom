using System;
using System.ComponentModel.DataAnnotations;

namespace GlassRoomWebApp.Domain.Entities
{
    public class UserOrder
    {
        public UserOrder() => DateUPAdded = DateTime.Now;

        [DataType(DataType.Time)]
        public DateTime DateUPAdded { get; set; }

        public Boolean Checked { get; set; }

        public int Id { get; set; }

        public float WidthVal { get; set; }

        public float HeightVal { get; set; }

        public float LengthVal { get; set; }

        public string GlassType { get; set; }

        public int GlassTh { get; set; }

        public string Fittings { get; set; }

        public string ShType { get; set; }

        public float ShPrice { get; set; }

        public string OrderNote { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        [Display(Name = "Имя")]
        public string UName { get; set; }

        [Required(ErrorMessage = "Введите номер")]
        [Display(Name = "Номер телефона")]
        public string PhoneNum { get; set; }
    }
}
