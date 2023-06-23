using System.ComponentModel.DataAnnotations;

namespace SunshineWax.Models.BookingModels
{
    public class Sunshiners
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public List<Days>? AvailableDays { get; set; }
    }
}
